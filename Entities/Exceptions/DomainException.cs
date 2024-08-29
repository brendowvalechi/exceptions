
namespace exeptions.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) //Herdando a mensagem de ApplicationException que é a mensagem de erro padrão do sistema.
        {                                                      //Como tem parametro message no base, se tiver uma mensagem criada para o erro, será escrita, senão vai a mensagem do sistema
        }
    }
}