using UsandoLINQ_FromWhereSelect;


Console.WriteLine("gg");
//Crie a lista de produtos e faça uma consulta usando o LINQ
//corrija o que for necessário
List<Produto> produtos = new List<Produto>
{
    new Produto(321, "Maquineta", "Média", 110 ),
    new Produto(322, "Martelo", "Média", 150 ),
    new Produto(323, "Chave De Fenda", "Baixa", 84),
    new Produto(324, "Martelete", "Alta", 350)

};

int numDeBusca = 15;
//testando consulta LINQ em array do tipo int
int[] numbers = {10, 15 , 20 , 25 , 30, 35 , 40, 45, 50};

var numQuery = from num in numbers
               where num % 2 == 0
               select num;

foreach (var num in numQuery)
{
    Console.WriteLine(num);
}


