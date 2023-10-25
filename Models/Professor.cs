namespace AgendaDeAulas.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Materia { get; set; } = string.Empty;
    }
}
