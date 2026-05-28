using ClubFlow.Data;
using ClubFlow.Interfaces;
using ClubFlow.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ClubFlow.Repository
{
    public class UserRepository : IUserRepository
    {
        public readonly ClubFlowDBContext _context;
        public readonly IPasswordHasher<User> _passwordHasher;

        public UserRepository(ClubFlowDBContext context, IPasswordHasher<User> passwordHasher)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _passwordHasher = passwordHasher ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<(bool Success, string ErrorMessage)> RegisterUserAsync(RegisterLoginModel model, User user)
        {
            if (model is null) return (false, "Model is null");
            if (user is null) return (false, "User is null");

            //Normalize and validate input
            var username = model.UserName?.Trim();
            var email = model.Email?.Trim().ToLowerInvariant();
            var confirmEmail = model.ConfirmEmail?.Trim().ToLowerInvariant();

            if (string.IsNullOrWhiteSpace(username)) return (false, "Username fehlt.");
            if (string.IsNullOrWhiteSpace(email)) return (false, "E-Mail fehlt.");
            if (email != confirmEmail) return (false, "E-Mails stimmen nicht überein.");

            //Check if username or email already exists (case-insensitive)
            var exists = await _context.tb_users.AnyAsync(u => u.UserName.ToLower() == username.ToLower() || u.Email.ToLower() == email);
            if (exists) return (false, "Benutzername oder E-Mail bereits vergeben.");

            //Mapping and Hashing
            user.UserName = username;
            user.Email = email;
            user.Password = _passwordHasher.HashPassword(user, model.Password);

            user.FirstName = (user.FirstName ?? string.Empty).Trim();
            user.LastName = (user.LastName ?? string.Empty).Trim();

            _context.tb_users.Add(user);

            try
            {
                await _context.SaveChangesAsync();
                return (true, string.Empty);
            }
            catch (DbUpdateException ex)
            {
                //Logging optional: Log the exception details for debugging
                return (false, ex.Message + "\n\n Fehler bei der Registrierung. Bitte versuchen Sie es später erneut.");

            }
        }
    }
}
