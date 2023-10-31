namespace AeC_API.NET.Repositories.Entities
{
    public class Log
    {
        public int Id { get; set; }
        public string NomeRota { get; set; }
        public string DescricaoErro { get; set; }
        public DateTime DataHora { get; set; }
    }
}
