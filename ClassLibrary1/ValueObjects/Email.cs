using System;
using System.Text.RegularExpressions;

namespace ECommerce.Dominio.ValueObjects
{
    public sealed class Email : IEquatable<Email>
    {
        public string Endereco { get; }

        public Email(string endereco)
        {
            if (string.IsNullOrWhiteSpace(endereco))
                throw new ArgumentException("Email não pode ser vazio.");

            if (!ValidarEmail(endereco))
                throw new ArgumentException("Email inválido.");

            Endereco = endereco;
        }

        private bool ValidarEmail(string email)
        {
            
            var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return regex.IsMatch(email);
        }


        public override bool Equals(object? obj) => Equals(obj as Email);

        public bool Equals(Email? other)
        {
            if (other is null) return false;
            return Endereco.Equals(other.Endereco, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode() => Endereco.ToLowerInvariant().GetHashCode();

        public override string ToString() => Endereco;
    }
}
