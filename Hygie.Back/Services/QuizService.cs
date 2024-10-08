using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Hygie.Model;

namespace Hygie.Back.Services
{
    public class QuizService
    {
        public QuizService() { }

        public Contenu GetContenu()
        {
            string pathJson = "..\\Hygie.Back\\Data\\questions.json";
            string json = System.IO.File.ReadAllText(pathJson);

            Contenu contenu = System.Text.Json.JsonSerializer.Deserialize<Contenu>(json);

            return contenu;
        }
    }
}
