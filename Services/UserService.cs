using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UserModule.Entity;
using UserModule.Infra.Interfaces;
using UserModule.ValueObjects;

namespace UserModule.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> RegisterUserAsync(string name, string email, string cpf, DateTime dateOfBirth, string phoneNumber)
        {
            var user = new User(name, new EmailVO(email), new CpfVO(cpf), new DateOfBirthVO(dateOfBirth), phoneNumber);
            await _userRepository.AddAsync(user);
            return user;
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            return await _userRepository.GetByIdAsync(id);
        }
    }

}
