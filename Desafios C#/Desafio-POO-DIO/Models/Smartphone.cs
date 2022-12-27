namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // Implementado - propriedades faltantes de acordo com o diagrama
        protected string Modelo;
        protected string IMEI;
        protected int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            //Implementado
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void infoSmartphone()
        {   
            Console.Write("Informações do produto\n");
            Console.WriteLine($"Numero: " + Numero);
            Console.WriteLine($"Modelo: " + Modelo);
            Console.WriteLine($"Memória: " + Memoria);
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}