using MagicVilla_WebAPI.Models.Dto;
using MagicVilla_WebAPI.Models;

namespace MagicVilla_WebAPI.Repository.IRepostiory
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<LocalUser> Register(RegisterationRequestDTO registerationRequestDTO);
    }
}
