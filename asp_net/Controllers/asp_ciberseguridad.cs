using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using asp_net;

namespace asp_net.Controllers
{
    public class HomeController : Controller
    {
        MySqlConnection con = new MySqlConnection(@"")
        









        private readonly MySqlConnection db;

        public HomeController()
        {
            string connectionString = "server=localhost;database=ciberseguridad;uid=root;password=TfK4D6V69EW#";
            db = new MySqlConnection(connectionString);
        }


        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult InsertData(string nombre, bool antivirus)
        {

            FormModel formModel = new FormModel();

            FormModel.Nombre usuario = new Nombre { C_nombre = nombre };

            // Add the object to the DbContext and save changes to insert into the database
            db.usuario.Add(usuario);
            db.SaveChanges();

            formModel.Antivirus antivirusData = new Antivirus { C_antivirus = antivirus };

            // Add the object to the DbContext and save changes to insert into the database
            db.antivirus.Add(antivirusData);
            db.SaveChanges();

            ViewBag.Message = "Data inserted successfully!";
            return View("Index");
        }

            // Create new instances of your model classes
            //formModel.Nombre nombre = new Nombre { C_nombre = nombre };
            //Antivirus antivirusData = new Antivirus { C_antivirus = antivirus };

            // Add the objects to the DbContext and save changes to insert into the database
            //db.usuarios.Add(nombre);
            //db.antivirus.Add(antivirusData);
            //db.SaveChanges();

            //ViewBag.Message = "Data inserted successfully!";
            //return View("Index");




            

    }
}