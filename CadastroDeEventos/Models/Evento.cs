namespace CadastroDeEventos.Models
{
    public class Evento
    {
        public Locais LocalEscolhido {  get; set; }
        public int QntPessoas { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal {  get; set; }

        public int Tempo
        {
            get => DataFinal.Subtract(DataInicio).Days;
        }
        public double ValorTotal
        {
           get
            {
                double ValorPorPessoa = QntPessoas * LocalEscolhido.ValorPorPessoa;

                double total = (ValorPorPessoa) * Tempo;

                return total;

            }

        }
    }
}
