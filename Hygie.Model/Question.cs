using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hygie.Model
{
    public class Question
    {
        public int Id { get; set; }

        public string Intitule { get; set; }

        [JsonPropertyName("ScoreTotal")]
        public int Score { get; set; }

        public List<Reponse> Reponses { get; set; }

        public void RecalculateScore()
        {
            var indice = 6 / 10;
            if(this.Reponses.Count > 0)
            {
                foreach (var rep in this.Reponses)
                {
                    if (rep.Score == 10)
                        rep.Score = rep.Score * indice;
                }
            }
        }

    }
}
