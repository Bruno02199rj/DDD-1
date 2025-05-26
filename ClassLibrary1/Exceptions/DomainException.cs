using System;

namespace ECommerce.Dominio.Excecoes
{
    public class DomainException : Exception
    {
        public DomainException(string mensagem) : base(mensagem)
        {
        }
    }
}