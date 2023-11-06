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
                comm.CommandText = "INSERT INTO Agenda(hora,data,professorId) VALUES(@hora, @data, @professorId)";
                comm.Parameters.AddWithValue("@hora", novaAgenda.Hora);
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

        public async Task<List<Aula>> GetAgenda()
        {
            List<Aula> aulas = new();
            
            string connectionString = "Server=mysql;Port=3306;Database=agenda;User=root;Password=admin;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT ag.id, pr.nome, pr.materia, ag.`data`, ag.hora FROM Agenda ag, Professor pr WHERE ag.professorId = pr.id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {

                        while (await reader.ReadAsync())
                        {
                            aulas.Add(new Aula()
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                NomeProf = reader["nome"].ToString(),
                                Materia = reader["materia"].ToString(),
                                Data = reader["data"].ToString(),
                                Hora = reader["hora"].ToString()
                            });
                        }
                    }
                }
            }

            return aulas;
        }

        public async Task DeletaAula(int id)
        {
            string connectionString = "Server=mysql;Port=3306;Database=agenda;User=root;Password=admin;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "DELETE FROM Agenda WHERE id = @id";
                comm.Parameters.AddWithValue("@id", id);
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
