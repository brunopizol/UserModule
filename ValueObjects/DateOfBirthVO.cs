using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModule.ValueObjects
{
    public class DateOfBirthVO
    {
        public DateTime Value { get; private set; }

        public DateOfBirthVO(DateTime dateOfBirth)
        {
            if (dateOfBirth > DateTime.UtcNow)
                throw new ArgumentException("Data de nascimento inválida.");

            Value = dateOfBirth;
        }
    }
}
