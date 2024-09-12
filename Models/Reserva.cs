namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; private set; }
        public Suite Suite { get; private set; }
        public int DiasReservados { get; private set; }

        public Reserva()
        {
            Hospedes = new List<Pessoa>();
        }

        public Reserva(int diasReservados) : this()
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite != null && hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else if (Suite == null)
            {
                throw new InvalidOperationException("A suíte deve ser cadastrada antes de cadastrar os hóspedes.");
            }
            else
            {
                throw new InvalidOperationException("A quantidade de hóspedes excede a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor *= 0.9m; // Desconto de 10%
            }

            return valor;
        }
    }
}
