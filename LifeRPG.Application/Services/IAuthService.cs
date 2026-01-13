using LifeRPG.Application.DTOs;
using LifeRPG.Domain.Entities;

namespace LifeRPG.Application.Services;

public interface IAuthService
{
    Task RegisterAsync(RegisterRequest request);
    Task<User> LoginAsync(LoginRequest request);
}
