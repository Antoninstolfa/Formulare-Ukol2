using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulare_Priklad_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form();

            Button zpet = new Button();
            zpet.Location = new Point(10,10);
            zpet.Size = new Size(60, 20);
            zpet.Text = "Zpět";



        }
    }
}
