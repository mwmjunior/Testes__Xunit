using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define um namespace chamado "GerenciamentoDeLivros", que é usado para organizar classes relacionadas em um contêiner lógico.
namespace GerenciamentoDeLivros
{
    // Define uma classe pública chamada "Livros". Esta classe será acessível a partir de outros códigos que usam este namespace.
    public class Livros
    {

        // Define uma propriedade pública do tipo string chamada "Titulo".
        // Esta propriedade representa o título de um livro e pode ser lida ou modificada a partir de fora da classe.
        public string Titulo { get; set; }

        // Define uma propriedade pública do tipo string chamada "Autor".
        // Esta propriedade representa o autor de um livro e também pode ser lida ou modificada a partir de fora da classe.
        public string Autor { get; set; }




        // Define um construtor para a classe "Livros" que aceita dois parâmetros: "titulo" e "autor".
        // O construtor é chamado quando uma nova instância da classe "Livros" é criada.

        public Livros(string titulo, string autor)
        {
            // Atribui o valor do parâmetro "titulo" à propriedade "Titulo" da instância atual da classe.
            Titulo = titulo;

            // Atribui o valor do parâmetro "autor" à propriedade "Autor" da instância atual da classe.
            Autor = autor;
        }
    }
}

