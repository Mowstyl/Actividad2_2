using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2_2
{
    abstract class Person
    {
        protected int id;
        public string dni;
        public string name;
        public string surname;
        public string province;
        public string town;
        public string startDate;
        public string endDate;
        public string accountNumber;

        public Person() { }

        public abstract int getId();
    }
}
