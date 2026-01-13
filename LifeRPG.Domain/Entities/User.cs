namespace LifeRPG.Domain.Entities;

public class User
{
    public Guid Id { get; set; }

    public string Username { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public int Level { get; set; } = 1;

    public int XP { get; set; } = 0;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
