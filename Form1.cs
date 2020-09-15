using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_6115261019_w10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            private void Form1_Load(object sender, EventArgs e)
            {

            }
            private void btnShow_Click(object sender, EventArgs e)
            {
                string code = txtNum.Text;
                string name = txtName.Text;
                string work = txtWork.Text;
                string page = txtPage.Text;
                string paper = txtDocument.Text;
                string date = txtDate.Text;
                string qualityLavel = txtQuality.Text;
                string weight = txtWeight.Text;
                Person per = new Person(code, name, work);
                Paper pa = new Paper(page, paper, date, qualityLavel, weight);
                lblDisplay.Text = per.Code + " " + per.WorkOwnerName + " " + per.WorkName + " " +
                    pa.Page + " " + pa.PaperName + " " + pa.Date + " " + pa.QulityLavel + " " + pa.Weight;
            }
        }
    }
}
