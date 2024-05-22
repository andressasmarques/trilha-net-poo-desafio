namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; private set; }
        public string Modelo { get; private set; }
        public string Imei { get; private set; }
        public int Memoria { get; private set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine($"{Modelo} está ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"{Modelo} está recebendo uma ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
