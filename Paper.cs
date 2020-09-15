using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_6115261019_w10
{
    class Paper
    {
        private string paperName;
        private string page;
        private string date;
        private string qulityLavel;
        private string weight;
        public Paper(string paperName, string page, string date, string qulityLavel, string weight)
        {
            this.PaperName = paperName;
            this.Page = page;
            this.Date = date;
            this.QulityLavel = qulityLavel;
            this.Weight = weight;
        }
        public string PaperName { 
            get => paperName; 
            set => paperName = value; 
        }
        public string Page { 
            get => page; 
            set => page = value; 
        }
        public string Date { 
            get => date; 
            set => date = value; 
        }
        public string QulityLavel { 
            get => qulityLavel; 
            set => qulityLavel = value; 
        }
        public string Weight { 
            get => weight; 
            set => weight = value; 
        }
    }
}
