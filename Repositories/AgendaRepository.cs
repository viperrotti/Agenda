using AgendaDeAulas.Models;
using MySql.Data.MySqlClient;

namespace AgendaDeAulas.Repositories
{
    public class AgendaRepository
    {
        public async Task AgendaAula(Agenda novaAgenda)
        {
            string connectionString = "Server=mysql;Port=3306;Database=agenda;User=root;Password=admin;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "INSERT INTO Agenda(nome,data,professorId) VALUES(@nome, @data, @professorId)";
                comm.Parameters.AddWithValue("@nome", novaAgenda.Nome);
                comm.Parameters.AddWithValue("@data", novaAgenda.Data);
                comm.Parameters.AddWithValue("@professorId", novaAgenda.ProfessorId);
                await comm.ExecuteNonQueryAsync();
                
            }
            catch (Exception ex)
            {

                throw;
            }   
            finally
            {
                conn.Close();
            }
        }
    }
}
