using AgendaDeAulas.Models;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace AgendaDeAulas.Repositories
{
    public class ProfessorRepository
    {
        public async Task<List<Professor>> GetProfessores()
        {
            List<Professor> professores = new();
            
            string connectionString = "Server=mysql;Port=3306;Database=agenda;User=root;Password=admin;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Professor";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {

                        while (await reader.ReadAsync())
                        {
                            professores.Add(new Professor()
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nome = reader["nome"].ToString(),
                                Materia = reader["materia"].ToString(),
                                Url = reader["url"].ToString(),
                            });
                        }
                    }
                }
            }

            return professores;
        }
    }
}
