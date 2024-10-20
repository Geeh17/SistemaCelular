namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Marca { get; set; }  
        public string Modelo { get; set; }    
        public int Armazenamento { get; set; } 
        public int Bateria { get; set; }  

        public Smartphone(string numero, string marca, string modelo, int armazenamento, int bateria)
        {
            Numero = numero;
            Marca = marca;
            Modelo = modelo;
            Armazenamento = armazenamento;
            Bateria = bateria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
