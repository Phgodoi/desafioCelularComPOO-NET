
namespace desafioCelularComPOO_NET.Models
{
    internal class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarApp(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no seu Iphone...");
        }
    }
}
