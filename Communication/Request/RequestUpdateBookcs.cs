namespace BookAPI.Communication.Request
{
    public class RequestUpdateBookcs
    {
        public string Titúlo { get; set; } = string.Empty;
        public double Custo { get; set; }
        public string gênero { get; set; } = string.Empty;
        public double QuantidadeEstoque { get; set; }
        public string AutorLivro { get; set; } = string.Empty;
    }
}
