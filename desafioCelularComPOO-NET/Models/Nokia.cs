
namespace desafioCelularComPOO_NET.Models
{
    internal class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarApp(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia...");
        }

    }
}
