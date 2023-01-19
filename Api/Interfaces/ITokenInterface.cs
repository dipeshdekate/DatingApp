using Api.Entities;

namespace Api.Interfaces
{
    public interface ITokenInterface
    {
        string CreateToken(AppUser user);
    }
}