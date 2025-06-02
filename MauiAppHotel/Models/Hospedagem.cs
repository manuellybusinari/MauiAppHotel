namespace MauiAppHotel.Models 
{
    public class Hospedagem
    {
        public Quarto QuartoSelecionado { get; set; }
        public int QtdAdultos { get; set; }
        public int QtdCriancas { get; set; }
        public DateTime DataCheckin { get; set; }
        public DateTime DataCheckout { get; set; }
        public int Estadia
        { get => DataCheckout.Subtract(DataCheckin).Days;}
        public double ValorTotal
        { get
            {
                double valor_adultos = QtdAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double valor_criancas = QtdCriancas * QuartoSelecionado.ValorDiariaCrianca;

                double total = (valor_adultos + valor_criancas * Estadia);

                    return total;
            }
        }

    }
}
