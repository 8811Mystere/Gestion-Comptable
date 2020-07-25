using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace push
{
    public partial class acceuilbon : Form
    {
        public acceuilbon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operations frm = new Operations();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            users frm = new users();
            panel3.Controls.Clear();
            panel3.Controls.Add(frm);
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            compte2 frm = new compte2();
            panel3.Controls.Clear();
            panel3.Controls.Add(frm);
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            souscompte2 frm = new souscompte2();
            panel3.Controls.Clear();
            panel3.Controls.Add(frm);
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            structure2 frm = new structure2();
            panel3.Controls.Clear();
            panel3.Controls.Add(frm);
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
            acceuilbon frm = new acceuilbon();
            frm.Show();
        }
    }
}
