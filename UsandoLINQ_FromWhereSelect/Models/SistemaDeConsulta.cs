using System;

namespace UsandoLINQ_FromWhereSelect.Models
{
    internal class SistemaDeConsulta
    {
        public SistemaDeConsulta()
        {

        }
        //Crie a lista de produtos e faça uma consulta usando o LINQ
        //corrija o que for necessário
        List<Produto> produtos = new List<Produto>
           {
           new Produto(321, "Maquineta", "Média", 110 ),
           new Produto(322, "Martelo", "Média", 150 ),
           new Produto(323, "Chave De Fenda", "Baixa", 84),
           new Produto(324, "Martelete", "Alta", 350)

           };
         
        public void IdDeConsulta()
        {
            Console.WriteLine("## Digite o Id do produto que deseja consultar: ##");
            int idConsulta = Convert.ToInt32(Console.ReadLine());

            ConsultarProdutoId(idConsulta);
        }

        public void ConsultarProdutoId(int id)
        {
            Console.WriteLine("\n");
            Console.WriteLine("## CONSULTA DE PRODUTO ##");
            Console.WriteLine("\n");
            var numFilter = from p in produtos
                            where p.Id == id
                            select p;

            //Como usar o método LINQ ; LINQ em método.
            // a forma maus simples de fazer usando o próprio método SingleOrDefault
            // var produto = produtos.SingleOrDefault(a => a.Id == id);

            //verificação de produto:
            if (numFilter is null)
            {
                Console.WriteLine("ERRO: Produto não existe na lista de produtos.");
            }
            else
            {
                foreach (var filter in numFilter)
                {
                    Console.WriteLine($" Produto Consultado, Id: {filter.Id}");
                   Console.WriteLine($" Nome: {filter.Nome}, preço: {filter.Preco}, Categoria: {filter.Categoria}. ");
                }

            }


        }
    }
}


