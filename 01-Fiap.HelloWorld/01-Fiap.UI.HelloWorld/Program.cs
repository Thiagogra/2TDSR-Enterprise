using System;
using _01_Fiap.UI.HelloWorld.Model;

namespace _01_Fiap.UI.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar uma classe Pessoa Fisica
            PessoaFisica pf = new PessoaFisica();
            //Atribuir um valor para o nome
            pf.Nome = "Aula 01";
            pf.Status = EstadoCivil.Casado;
            //Exibir o valor do nome
            Console.WriteLine(pf.Nome);

            //Instanciar uma outra pesso fisica
            PessoaFisica pf2 = new PessoaFisica()
            {
                Nome = "Teste",
                Rg = "13131313-5"
            };

        }
    }
}
