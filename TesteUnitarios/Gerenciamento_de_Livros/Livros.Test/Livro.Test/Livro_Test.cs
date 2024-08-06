using GerenciamentoDeLivros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


// Define um namespace chamado "Livro.Test", que organiza as classes de teste relacionadas ao gerenciamento de livros.
namespace Livro.Test
{
    // Define uma classe pública chamada "Livro_Test". Esta classe contém métodos de teste unitário para verificar o comportamento do código.
    public class Livro_Test
    {

        // Marca o método "AdicionarLivro" como um teste unitário usando o atributo [Fact].
        // O XUnit executa este método como um teste.
        [Fact]
        public void AdicionarLivro()
        {
            // Arrange: Configura o ambiente de teste.
            // Cria uma lista de livros vazia que será usada para adicionar o livro.
            var listaDeLivros = new List<Livros>();

            // Cria uma instância da classe "Livros" com o título "Pai Rico Pai Pobre" e o autor "Robert Kiyosak".
            var livro = new Livros("Harry Potter e a Pedra Filosofal", " J. K. Rowling");

            // Act: Executa a ação a ser testada.
            // Adiciona o livro à lista de livros.
            listaDeLivros.Add(livro); // linha omitida não adiciona o livro à lista 

            // Assert: Verifica o resultado da ação.
            // Verifica se o livro está presente na lista de livros.
            // Se o livro não estiver na lista, o teste falhará.
            Assert.Contains(livro, listaDeLivros);
        }
    }
}

