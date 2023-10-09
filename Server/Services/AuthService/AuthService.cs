using BlazorEComm.Shared.Messages;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.AuthService;

public class AuthService : IAuthService
{
    private readonly IRepository _repository;
    private readonly IUserExtensionRepository _userExtensionRepository;
    private readonly IPasswordService _passwordService;
    private readonly ITokenService _tokenService;

    public AuthService(IRepository repository, IUserExtensionRepository userExtensionRepository, ITokenService tokenService, IPasswordService passwordService)
    {
        _repository = repository;
        _userExtensionRepository = userExtensionRepository;
        _tokenService = tokenService;
        _passwordService = passwordService;
    }

    public async Task<ServiceResponse<string>> Register(User user, string password, CancellationToken cancellationToken)
    {
        if (await _userExtensionRepository.UserExists(user.Email, cancellationToken))
        {
            return new ServiceResponse<string>
            {
                Succes = !ConstantServerServices.IsSucces,
                Message = MessagesServerServices.MessageUserExist
            };
        }

        _passwordService.CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
        user.PasswordSalt = passwordSalt;
        user.PasswordHash = passwordHash;


        var added = _repository.Add(user);
        if (added)
        {
            added = await _repository.SaveChangesAsync(cancellationToken);
        }

        return added ?
            new()
            {
                Data = user.Id.ToString(),
                Message = MessagesServerServices.MessageRegisterSucces
            } :
            new ServiceResponse<string>
            {
                Succes = !ConstantServerServices.IsSucces,
                Message = MessagesServerServices.MessageUserNotAdded
            };
    }
  
    public async Task<ServiceResponse<string>> Login(string email, string password, CancellationToken cancellationToken)
    {
        var response = new ServiceResponse<string>();

        var user = await _userExtensionRepository.GetUserByEmail(email, cancellationToken); 
        if (user == null)
        {
            response.Succes = !ConstantServerServices.IsSucces;
            response.Message = MessagesServerServices.MessageUserNotFound;

            return response;
        }

        if (!_passwordService.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
        {
            response.Succes = !ConstantServerServices.IsSucces;
            response.Message = MessagesServerServices.MessageWrongPassword;

            return response;
        }

        response.Data = _tokenService.CreateToken(user);
        return response;
    }   
}