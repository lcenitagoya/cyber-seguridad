using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data;

namespace asp_net.Controllers
{
    [ApiController]
    [Route("api/formularios")]
    public class ciberseg
    {
        private readonly MySqlConnection connection;

        public ciberseg()
        {
            string connectionString = "server=localhost;database=ciberseguridad;uid=root;password=TfK4D6V69EW#;";
            connection = new MySqlConnection(connectionString);
        }

        [HttpGet]
        public async Task<IActionResult> GetAnswer(int threadId)
        {
            try
            {
                var query = "SELECT * FROM formularios";
                var command = new MySqlCommand(query, connection);
                var answers = new List<Formulario>();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var formulario = new Formulario
                        {
                            id = reader.GetInt32("id"),
                            idOP = reader.GetInt32("idOp"),
                            Answ = reader.GetString("Answ"),
                        };

                        answers.Add(answer);
                    }

                }

                return Ok(answers);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> NewAnswer(Answer respuesta)
        {
            var insertQuery = "INSERT INTO respuestas (threadId, usuarioId, contenido) VALUES (@ThreadId, @UsuarioId, @Contenido)";
            await connection.ExecuteAsync(insertQuery, respuesta);
            return Ok();
        }

    }
}