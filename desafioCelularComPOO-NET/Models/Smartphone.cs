
namespace desafioCelularComPOO_NET.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private string Memoria { get; set; }

        //Implementado

        public Smartphone(string numero,string modelo, string imei, string memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            //Implementado
        }

        public void Ligar()
        {
            Console.WriteLine("Chamando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligãção...");
        }

        public static Smartphone CriarSmartphone(string escolha)
        {
            Console.WriteLine("Informe o numero do aparelho: ");
            string numAparelho = Console.ReadLine();
            Console.WriteLine("Informe o Modelo: ");
            string modelAparelho = Console.ReadLine();
            Console.WriteLine("Informe o Imei: ");
            string imeiAparelho = Console.ReadLine();
            Console.WriteLine("Informe a Memoria: ");
            string memoAparelho = Console.ReadLine();

            Console.Clear();

            switch (escolha)
            {
                case "1":
                return new Nokia(numero: numAparelho, modelo: modelAparelho, imei: imeiAparelho, memoria: memoAparelho);

                case "2":
                return new Iphone(numero: numAparelho, modelo: modelAparelho, imei: imeiAparelho, memoria: memoAparelho);

                default:
                    Console.WriteLine("Opção inválida, verifique!"); 
                return null;
            }
        }

        public abstract void InstalarApp(string nomeApp);

    }
}