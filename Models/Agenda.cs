namespace AgendaDeAulas.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        public int ProfessorId { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set; } = string.Empty;
    }
}
