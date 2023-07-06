using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreBoard
{
   public class Swimmer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Genders Gender { get; set; }
        public int Score { get; set; }
         
        public enum Genders
        {
            Male,
            Female

        }
    }
}

