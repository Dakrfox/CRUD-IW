using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_IW.Model
{
    internal class Client
    {
        private string names;
        private string lastnames;
        private string document;
        private int age; 
        private string sex;
        private string address;

        public Client()
        {
            this.names = "";
            this.lastnames = "";
            this.document = "";
            this.age = 0;
            this.sex = "";
            this.address = "";
        }

        public string Names { get => names; set => names = value; }
        public string Lastnames { get => lastnames; set => lastnames = value; }
        public int Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Document { get => document; set => document = value; }
    }
}
