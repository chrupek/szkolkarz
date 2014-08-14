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
        DBController appController;

        public MainForm()
        {
            
            InitializeComponent();
            customizeToolStrip();
            mainMap.FunctionMode = DotSpatial.Controls.FunctionMode.Select;
            //customizeMap();
            appController = new DBController();

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
            this.spatialToolStrip1.Items.RemoveByKey("cmdInfo");

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

            items = this.spatialToolStrip1.Items.Find("cmdMaxExtents", false);
            items[0].ToolTipText = "Dopasuj do rozmiaru mapy";
        }

        private void customizeMap()
        {
            //this.mainMap.DataBindings.Add
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mainMap_MouseClicked(object sender, MouseEventArgs e)
        {
            
            if (this.mainMap.Layers.Count.Equals(0))
                return;
            List<IFeature> featureList = new List<IFeature>();
            FeatureLayer featureLayer = mainMap.Layers[0] as FeatureLayer;
            ISelection selection = featureLayer.Selection;
            try
            {
                String rowId = featureList[0].ToString();
                featureList = selection.ToFeatureList();
                List<ADM_SOWN_LOG> queryResult = appController.getSownHistory(rowId);
                this.mainMap.DataBindings.Add(new Binding("dataSource", queryResult, "ADM_SOWN_LOG"));

            }
            catch
            {

            }
        }
    }
}
