using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RicercaSostituzioni
{
    public partial class frmGestioneSostituzioni : Form
    {
        public frmGestioneSostituzioni()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'cesarDataSet.dtUtenti'. È possibile spostarla o rimuoverla se necessario.
            this.taUtenti.Fill(this.cesarDataSet.dtUtenti);

        }

        private void dgUtenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
