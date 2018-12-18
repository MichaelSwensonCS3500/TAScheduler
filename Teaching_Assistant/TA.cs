using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teaching_Assistant
{
    public class TA
    {
        private bool senior;
        private string firstName;
        private string lastName;
        private List<Labs> daysAvailable = new List<Labs>();

        public TA(bool senior, string firstName, string lastName, List<Labs> daysAvailable)
        {
            this.senior = senior;
            this.firstName = firstName;
            this.lastName = lastName;
            this.daysAvailable = daysAvailable;
        }

        public TA(string firstName, string lastName, bool senior)
        {
            this.senior = senior;
            this.firstName = firstName;
            this.lastName = lastName;
            this.daysAvailable = null;
        }
    }

}
