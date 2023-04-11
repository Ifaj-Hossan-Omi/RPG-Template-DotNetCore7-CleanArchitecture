namespace RPG.Domain.DTO.User;

public class UserRegisterRequestDto
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}