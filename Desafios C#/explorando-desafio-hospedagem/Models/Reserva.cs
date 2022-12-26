namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTADO*
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTADO*
                throw new Exception ("Número de hóspedes superior a capacidade total");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            //Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTADO*
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Retorna o valor da diária
            // *IMPLEMENTADO*
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTADO*
            if (DiasReservados >= 10)
            {
                valor -= decimal.Multiply(valor,0.10M);
            }

            return valor;
        }
    }
}
