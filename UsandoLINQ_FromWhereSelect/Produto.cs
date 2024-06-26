using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoLINQ_FromWhereSelect
{
    internal class Produto
    {
        public Produto(int id, string nome, string categoria, int preco) 
        {
            Id = id;
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int Preco { get; set; }             
    }
}
