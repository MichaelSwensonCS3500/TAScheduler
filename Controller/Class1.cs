using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teaching_Assistant;

namespace Controller
{
    public class Class1
    {
        private List<Labs> labs;
        private List<TA> assistants;

        public delegate List<Labs> OnCheckBoxPopulation();
        public event OnCheckBoxPopulation addLabs;


    }
}
