using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_6115261019_w10
{
    class Person
    {
        private string code;
        private string workOwnerName;
        private string workName;
        public Person(string code, string workOwnerName, string workName)
        {
            this.Code = code;
            this.WorkOwnerName = workOwnerName;
            this.WorkName = workName;
        }
        public string Code { 
            get => code; 
            set => code = value; 
        }
        public string WorkOwnerName { 
            get => workOwnerName; 
            set => workOwnerName = value; 
        }
        public string WorkName { 
            get => workName; 
            set => workName = value; 
        }
    }
}
