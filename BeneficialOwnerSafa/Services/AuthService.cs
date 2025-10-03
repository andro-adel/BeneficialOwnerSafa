using BeneficialOwnerSafa.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BeneficialOwnerSafa.Services
{
    public class AuthService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthService(AppDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        // ✅ تسجيل الدخول
        public async Task<bool> LoginAsync(string identity, string password)
        {
            // نجيب المستخدم من الجدول
            var user = await _context.NonprofitsUsers
                .FirstOrDefaultAsync(u => u.Identity == identity && u.Password == password);

            if (user == null)
                return false; // بيانات غلط

            // Claims (المعلومات اللي هتتحط في الـ Cookie)
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Name ?? ""),
                new Claim(ClaimTypes.Email, user.Email ?? ""),
                new Claim("Identity", user.Identity)
            };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                IsPersistent = true, // الجلسة تفضل لو قفل البراوزر
                ExpiresUtc = DateTimeOffset.UtcNow.AddHours(8)
            };

            // نسجل الدخول
            await _httpContextAccessor.HttpContext!.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

            return true;
        }

        // ✅ تسجيل الخروج
        public async Task LogoutAsync()
        {
            await _httpContextAccessor.HttpContext!
                .SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }

        // ✅ هل المستخدم داخل؟
        public bool IsAuthenticated()
        {
            return _httpContextAccessor.HttpContext!.User.Identity?.IsAuthenticated ?? false;
        }

        // ✅ نجيب المستخدم الحالي
        public string? GetCurrentIdentity()
        {
            return _httpContextAccessor.HttpContext!.User.Identity?.Name;
        }

        public string? GetCurrentUserId()
        {
            return _httpContextAccessor.HttpContext!.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
