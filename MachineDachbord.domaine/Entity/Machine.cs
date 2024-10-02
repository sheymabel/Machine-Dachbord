using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineDachbord.domaine.Entity
{
    internal class Machine
    {
        public int IdMachine { get; set; }

        public DateTime DateTemperature { get; set; }

        public double Temperature { get; set; }

        public Machine(int idMachine, DateTime dateTemperature, double temperature)
        {
            IdMachine = idMachine;
            DateTemperature = dateTemperature;
            Temperature = temperature;
        }
    }
}
