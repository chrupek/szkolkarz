using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using szkolkarz.core;
using DotSpatial.Data;
using DotSpatial.Symbology;


namespace szkolkarz.forms.main
{
    public partial class MainForm : Form
    {
        Controller appController;

        public MainForm()
        {
            
            InitializeComponent();
            customizeToolStrip();
            appController = new Controller();
            appController.createConnection();

        }

        private void customizeToolStrip()
        {
            ToolStripItem[] items;
            this.spatialToolStrip1.Items.RemoveByKey("cmdNew");
            this.spatialToolStrip1.Items.RemoveByKey("cmdOpen");
            this.spatialToolStrip1.Items.RemoveByKey("cmdSave");
            this.spatialToolStrip1.Items.RemoveByKey("cmdPrint");
            this.spatialToolStrip1.Items.RemoveByKey("cmdMeasure");
            this.spatialToolStrip1.Items.RemoveByKey("cmdTable");

            //translate tooltips
            items = this.spatialToolStrip1.Items.Find("cmdAddData", false);
            items[0].ToolTipText = "Otwórz mapę";

            items = this.spatialToolStrip1.Items.Find("cmdPan", false);
            items[0].ToolTipText = "Uchwyć";

            items = this.spatialToolStrip1.Items.Find("cmdSelect", false);
            items[0].ToolTipText = "Zaznacz";

            items = this.spatialToolStrip1.Items.Find("cmdZoom", false);
            items[0].ToolTipText = "Powiększ";
            items[0].Image = szkolkarz.Properties.Resources.zoom_in;

            items = this.spatialToolStrip1.Items.Find("cmdZoomOut", false);
            items[0].ToolTipText = "Pomniejsz";
            items[0].Image = szkolkarz.Properties.Resources.zoom_out;

            items = this.spatialToolStrip1.Items.Find("cmdZoomPrevious", false);
            items[0].ToolTipText = "Powiększ do poprzedniego zakresu";

            items = this.spatialToolStrip1.Items.Find("cmdZoomNext", false);
            items[0].ToolTipText = "Powiększ do następnego zakresu";

            items = this.spatialToolStrip1.Items.Find("cmdInfo", false);
            items[0].ToolTipText = "Infromacje";
            items[0].Image = szkolkarz.Properties.Resources.indeks;

            items = this.spatialToolStrip1.Items.Find("cmdMaxExtents", false);
            items[0].ToolTipText = "Dopasuj do rozmiaru mapy";
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void map1_MouseClicked(object sender, MouseEventArgs e)
        {
            if (this.map1.Layers.Count.Equals(0))
                return;
            List<IFeature> featureList = new List<IFeature>();
            FeatureLayer featureLayer = map1.Layers[0] as FeatureLayer;
            ISelection selection = featureLayer.Selection;
            try
            {
                featureList = selection.ToFeatureList();
                for (int i = 0; i < selection.Count; i++)
                {
                   Console.WriteLine(featureList[i].Fid.ToString() + " FID"); //FID

                   Console.WriteLine(featureList[i].DataRow.ItemArray.GetValue(0).ToString() + " ATTRIBUTE"); //attribute
                }



            }
            catch
            {
            }
        }
    }
}
