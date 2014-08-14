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

        private void DetailsInformation_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
