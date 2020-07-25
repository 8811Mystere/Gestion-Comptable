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
    public partial class Imprimer : Form
    {
        public Imprimer()
        {
            InitializeComponent();
        }

        private void Imprimer_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'DataSet2.DataTable'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.DataTableTableAdapter.Fill(this.DataSet2.DataTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
