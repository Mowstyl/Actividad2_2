using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2_2
{
    class Worker : Person
    {
        private static int count;
        public string[] phone;
        public int salary;
        public string job;
        public string notes;
        public bool active;

        public Worker()
        {
            id = count;
            count++;
            phone = new string[2];
            active = false;
        }

        public override int getId()
        {
            return id;
        }

        public override string ToString()
        {
            if (active)
                return id+" - "+surname+", "+name;
            else
                return "BAJA - " + surname + ", " + name;
        }
    }
}
