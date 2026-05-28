using System.Threading.Tasks;
using ClubFlow.Models;

namespace ClubFlow.Interfaces
{
    public interface IUserRepository
    {
        Task<(bool Success, string ErrorMessage)> RegisterUserAsync(RegisterLoginModel model, User user);
    }
}
