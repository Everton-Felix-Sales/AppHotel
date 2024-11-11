namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto QuartoSelecionado { get; set; }
        public int QntAdultos { get; set; }
        public int QntCriancas { get; set; }
        public int QntMonstros { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public int Estadia
        {
            get => DataCheckOut.Subtract(DataCheckIn).Days;
        }
        public double ValorTotal
        {
            get
            {
                double valor_adultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double valor_criancas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;
                double valor_monstros = QntMonstros * QuartoSelecionado.ValorDiariaMonstro;
                double total = (valor_adultos + valor_criancas + valor_monstros) * Estadia;

                return total;
            }
        }
    }
}