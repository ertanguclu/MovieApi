using Microsoft.AspNetCore.Identity;
using MovieApi.Application.Features.CQRSDesignPattern.Commands.UserRegisterCommands;
using MovieApi.Persistence.Context;
using MovieApi.Persistence.Identity;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.UserRegisterHandlers
{
    public class CreateUserRegisterCommandHandler
    {
        private readonly MovieContext _context;
        private readonly UserManager<AppUser> _userManager;

        public CreateUserRegisterCommandHandler(MovieContext context, UserManager<AppUser> signInManager)
        {
            _context = context;
            _userManager = signInManager;
        }

        public async Task Handle(CreateUserRegisterCommand command)
        {
            var user = new AppUser
            {
                UserName = command.Username,
                Email = command.Email,
                Name = command.Name,
                Surname = command.Surname
            };
            await _userManager.CreateAsync(user, command.Password);//Şifre hashleme işlemi Identity tarafından yapılır.bu yüzden appuser dahil edilmez.

        }
    }
}
