// Define um namespace chamado "GerenciamentoDeLivros", que é usado para organizar classes relacionadas em um contêiner lógico.
namespace GerenciamentoDeEmails
{
    public class EmailValidator
    {
        // Método que valida se um email contém "@" e "."
        public bool ValidarEmail(string email)
        {
            // Verifica se o email contém "@" e "."
            return email.Contains("@") && email.Contains(".");
        }
    }
}

