using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace szkolkarz.view
{
    public partial class DetailsInformation : Form
    {
        public DetailsInformation()
        {
            InitializeComponent();
        }

        public void loadDataToGridView(List<V_FULL_SOWN_LOG> data)
        {
            try
            {
                this.sownLogDataGridView.DataSource = data;
            }
            catch (DataException e)
            {
                MessageBox.Show(e.Message, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
        }

        private void eksportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
