namespace BookAPI.Communication.Request
{
    public class RequestCreateBook
    {
        public string Titúlo { get; set; } = string.Empty;
        public double Custo { get; set; }
        public string gênero { get; set; } = string.Empty;
        public double QuantidadeEstoque { get; set; }
        public string AutorLivro { get; set; } = string.Empty;
    }
}
