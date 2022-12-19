namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementado
            Console.WriteLine("Informe a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
            
        }

        public void RemoverVeiculo()
        {
            //Implementado
            Console.WriteLine("Informe a placa do veículo que deseja remover: ");

            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {   
                 Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                decimal horas = 0;
                decimal valorTotal = 0;

                horas = Convert.ToDecimal(Console.ReadLine());
                valorTotal = precoInicial + (precoPorHora * horas);

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                //Implementado
                Console.WriteLine("Os veículos estacionados são:");
                foreach(string placaVeic in veiculos){
                    Console.WriteLine(placaVeic.ToString());
                }
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
