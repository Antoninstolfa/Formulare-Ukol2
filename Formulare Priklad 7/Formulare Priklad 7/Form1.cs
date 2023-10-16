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

            int x = (int)numericUpDown1.Value;
            int y = (int)numericUpDown2.Value;

            form2.Size = new Size(x, y);
            form2.Text = textBox1.Text;
            form2.BackColor = colorDialog1.Color;

            Button zpet = new Button();
            zpet.DialogResult = DialogResult.OK;
            zpet.Location = new Point(10,10);
            zpet.Size = new Size(60, 20);
            zpet.Text = "Zpět";
            zpet.BackColor = Color.White;
            zpet.ForeColor = Color.Black;

            Button konec = new Button();
            konec.DialogResult = DialogResult.Cancel;
            konec.Location = new Point(10, 35);
            konec.Size = new Size(60, 20);
            konec.Text = "Konec";
            konec.BackColor = Color.White;
            konec.ForeColor = Color.Black;

            if(checkBox1.Checked == true)
            {
                form2.FormBorderStyle = FormBorderStyle.FixedDialog;
            }

            form2.Controls.Add(zpet);
            form2.Controls.Add(konec);

            this.Hide();

            if(form2.ShowDialog() == DialogResult.OK)
            {
                form2.Close();
                this.Show();    
            }
            else
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
    }
}
