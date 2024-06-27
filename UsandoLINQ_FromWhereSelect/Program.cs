using UsandoLINQ_FromWhereSelect;
using UsandoLINQ_FromWhereSelect.Models;

SistemaDeConsulta SystemConsult = new SistemaDeConsulta();

SystemConsult.IdDeConsulta();

//-------------------------------------------------------------
int numDeBusca = 15;
//testando consulta LINQ em array do tipo int
int[] numbers = {10, 15 , 20 , 25 , 30, 35 , 40, 45, 50};
               //from: define a origem, qual fonte de dados iremos tratar.
var numQuery = from num in numbers
               //where: define uma condição que queremos filtrar com os dados que estamos recebendo.
               where num % 2 == 0
               //select: selecionamos o que queremos como retorno
               select num;

Console.WriteLine("\n");
Console.WriteLine("_________________________________________________________________________________________________");
Console.WriteLine("\n");
foreach (var num in numQuery)
{
    Console.WriteLine(num);
}


