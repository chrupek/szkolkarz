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

        public void loadDataToGridView(List<ADM_SOWN_LOG> data)
        {
            this.sownLogDataGridView.DataSource = data;
        }

    }
}
