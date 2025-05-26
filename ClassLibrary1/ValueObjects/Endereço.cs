

namespace ECommerce.Dominio.ValueObjects
{
    public sealed class Endereco : IEquatable<Endereco>
    {
        public string Rua { get; }
        public string Numero { get; }
        public string Bairro { get; }
        public string Cidade { get; }
        public string Estado { get; }
        public string Cep { get; }

        public Endereco(string rua, string numero, string bairro, string cidade, string estado, string cep)
        {
            if (string.IsNullOrWhiteSpace(rua)) throw new ArgumentException("Rua é obrigatória.");
            if (string.IsNullOrWhiteSpace(numero)) throw new ArgumentException("Número é obrigatório.");
            if (string.IsNullOrWhiteSpace(bairro)) throw new ArgumentException("Bairro é obrigatório.");
            if (string.IsNullOrWhiteSpace(cidade)) throw new ArgumentException("Cidade é obrigatória.");
            if (string.IsNullOrWhiteSpace(estado)) throw new ArgumentException("Estado é obrigatório.");
            if (string.IsNullOrWhiteSpace(cep)) throw new ArgumentException("CEP é obrigatório.");

            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }

        public override bool Equals(object? obj) => Equals(obj as Endereco);

        public bool Equals(Endereco? other)
        {
            if (other is null) return false;

            return Rua == other.Rua &&
                   Numero == other.Numero &&
                   Bairro == other.Bairro &&
                   Cidade == other.Cidade &&
                   Estado == other.Estado &&
                   Cep == other.Cep;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Rua, Numero, Bairro, Cidade, Estado, Cep);
        }

        public override string ToString()
        {
            return $"{Rua}, {Numero} - {Bairro}, {Cidade} - {Estado}, CEP: {Cep}";
        }
    }
}
