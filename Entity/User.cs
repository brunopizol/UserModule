using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UserModule.ValueObjects;

namespace UserModule.Entity
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public EmailVO Email { get; private set; }
        public CpfVO Cpf { get; private set; }
        public DateOfBirthVO DateOfBirth { get; private set; }
        public string PhoneNumber { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public User(string name, EmailVO email, CpfVO cpf, DateOfBirthVO dateOfBirth, string phoneNumber)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            Cpf = cpf;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            CreatedAt = DateTime.UtcNow;
        }
    }

}
