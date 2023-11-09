
using desafioCelularComPOO_NET.Models;


Console.WriteLine("Selecione a marca do Smartphone que deseja cadastrar");
Console.WriteLine("1 - Nokia");
Console.WriteLine("2 - Iphone");
string escolha = Console.ReadLine();

Smartphone smartphone = Smartphone.CriarSmartphone(escolha);



if (smartphone != null)
{
    Console.WriteLine("Informe o Aplicativo que deseja Instalar? ");
    smartphone.InstalarApp(Console.ReadLine());
}


Console.WriteLine("Deseja realizar uma ligação? ");
Console.WriteLine("Digite \n S - Sim \n N - Não");

string resposta = Console.ReadLine().ToUpper();

if (resposta == "S")
{
    smartphone.Ligar();
}
else
{
    smartphone.ReceberLigacao();
}



