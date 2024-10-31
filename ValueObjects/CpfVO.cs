using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModule.ValueObjects
{
    public class CpfVO
    {
        public string Value { get; private set; }

        public CpfVO(string cpf)
        {
            if (!IsValid(cpf))
                throw new ArgumentException("CPF inválido.");

            Value = cpf;
        }

        private bool IsValid(string cpf)
        {
            // Lógica de validação de CPF
            return cpf.Length == 11; // Exemplo básico
        }
    }
}
