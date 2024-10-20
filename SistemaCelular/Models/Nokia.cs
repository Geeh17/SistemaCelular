namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string marca, string modelo, int armazenamento, int bateria)
            : base(numero, marca, modelo, armazenamento, bateria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia {Modelo}");
        }
    }
}
