using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserModule.ValueObjects
{
    public class EmailVO
    {
        public string Address { get; private set; }

        public EmailVO(string address)
        {
            if (!IsValid(address))
                throw new ArgumentException("Email inválido.");

            Address = address;
        }

        private bool IsValid(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
