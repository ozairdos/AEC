using System.Text.Json.Nodes;

namespace AeC_API.NET.Repositories.Entities
{
    public class Clima
    {
        public int Id { get; set; }
        public string NomeRota { get; set; }
        public string JsonData { get; set; }
        public DateTime DataHora { get; set; }
    }
}
