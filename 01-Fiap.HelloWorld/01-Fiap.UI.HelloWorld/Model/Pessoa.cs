using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI.HelloWorld.Model
{
    class Pessoa
    {
        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        public Pessoa()
        {

        }

        //Atributo - Field/Campo
        private string _nome;

        //Gets e Sets - Propriedades
        public int Idade { get; set; }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
    }
}
