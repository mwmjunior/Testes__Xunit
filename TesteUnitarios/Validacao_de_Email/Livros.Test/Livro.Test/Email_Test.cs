using GerenciamentoDeEmails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

// Define um namespace chamado "Email.Test", que organiza as classes de teste relacionadas à validação de emails.
namespace Email.Test
{
    // Define uma classe pública chamada "Email_Test". Esta classe contém métodos de teste unitário para verificar o comportamento do código de validação de emails.
    public class Email_Test
    {
        // Define um campo somente leitura (readonly) do tipo EmailValidator. Este campo é usado para armazenar uma instância do validador de email.
        private readonly EmailValidator _emailValidator;

        // Construtor da classe "Email_Test". É executado quando uma nova instância da classe é criada.
        public Email_Test()
        {
            // Inicializa o validador de email atribuindo uma nova instância de "EmailValidator" ao campo "_emailValidator".
            _emailValidator = new EmailValidator();
        }

        // Define um teste que será executado com diferentes conjuntos de dados.
        // O atributo [Theory] indica que este método pode ser executado várias vezes com diferentes entradas de dados.
        [Theory]
        [InlineData("teste@exemplo.com", true)] // Email válido, espera-se que a validação retorne true
        [InlineData("email.sem.arroba.com", false)] // Falta "@", espera-se que a validação retorne false
        [InlineData("email@sem.ponto", false)] // Falta ".", espera-se que a validação retorne false
        [InlineData("email@.com", false)] // Falta parte do domínio, espera-se que a validação retorne false
        [InlineData("email@exemplo.", false)] // Falta parte do domínio, espera-se que a validação retorne false
        [InlineData("", false)] // Email vazio, espera-se que a validação retorne false
        [InlineData("email@exemplo.com.br", true)] // Email válido com TLD mais longo, espera-se que a validação retorne true

        // Método que executa o teste de validação de email.
        // Recebe dois parâmetros: um email e o resultado esperado da validação.
        public void ValidarEmail_DeveRetornarResultadoCorreto(string email, bool resultadoEsperado)
        {
            // Act: Chama o método "ValidarEmail" do validador de email, passando o email fornecido como parâmetro.
            bool resultado = _emailValidator.ValidarEmail(email);

            // Assert: Verifica se o resultado retornado pelo método "ValidarEmail" é igual ao resultado esperado.
            // Se o resultado não for igual ao esperado, o teste falha.
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
