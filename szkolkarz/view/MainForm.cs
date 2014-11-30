using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using szkolkarz.core;
using szkolkarz.view;
using DotSpatial.Data;
using DotSpatial.Symbology;
using System.Data.SqlClient;


namespace szkolkarz.forms.main
{
    public partial class MainForm : Form
    {
        private bool infoON { get; set; }
        DBController dbController;
        
        public MainForm()
        {
            
            InitializeComponent();
            customizeToolStrip();
            dbController = new DBController();

        }

        private void customizeToolStrip()
        {
            removeUnusedControls();
            translateControls();

        }

        public void removeUnusedControls()
        {

            this.spatialToolStrip.Items.RemoveByKey("cmdNew");
            this.spatialToolStrip.Items.RemoveByKey("cmdOpen");
            this.spatialToolStrip.Items.RemoveByKey("cmdSave");
            this.spatialToolStrip.Items.RemoveByKey("cmdPrint");
            this.spatialToolStrip.Items.RemoveByKey("cmdMeasure");
            this.spatialToolStrip.Items.RemoveByKey("cmdTable");
            this.spatialToolStrip.Items.RemoveByKey("cmdInfo");
        }

        public void translateControls()
        {
            ToolStripItem[] items;

            items = this.spatialToolStrip.Items.Find("cmdAddData", false);
            items[0].ToolTipText = "Otwórz mapę";

            items = this.spatialToolStrip.Items.Find("cmdPan", false);
            items[0].ToolTipText = "Uchwyć";

            items = this.spatialToolStrip.Items.Find("cmdSelect", false);
            items[0].ToolTipText = "Zaznacz";

            items = this.spatialToolStrip.Items.Find("cmdZoom", false);
            items[0].ToolTipText = "Powiększ";
            items[0].Image = szkolkarz.Properties.Resources.zoom_in;

            items = this.spatialToolStrip.Items.Find("cmdZoomOut", false);
            items[0].ToolTipText = "Pomniejsz";
            items[0].Image = szkolkarz.Properties.Resources.zoom_out;

            items = this.spatialToolStrip.Items.Find("cmdZoomPrevious", false);
            items[0].ToolTipText = "Powiększ do poprzedniego zakresu";

            items = this.spatialToolStrip.Items.Find("cmdZoomNext", false);
            items[0].ToolTipText = "Powiększ do następnego zakresu";

            items = this.spatialToolStrip.Items.Find("cmdMaxExtents", false);
            items[0].ToolTipText = "Dopasuj do rozmiaru mapy";

            items = null;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void infoStripButton_Click(object sender, EventArgs e)
        {
            if (!this.Cursor.Equals(Cursors.Cross))
            {
                mainMap.FunctionMode = DotSpatial.Controls.FunctionMode.Select;
                this.mainMap.Cursor = Cursors.Cross;
                this.Cursor = Cursors.Cross;
                infoON = true;

            }
            else
            {
                mainMap.FunctionMode = DotSpatial.Controls.FunctionMode.None;
                this.Cursor = Cursors.Arrow;
                this.mainMap.Cursor = Cursors.Hand;
                infoON = false;
            }
        }

        private void mainMap_Click(object sender, EventArgs e)
        {
            if (infoON)
            {
                DetailsInformation detailsInfoWindow = new DetailsInformation();

                try
                {
                    List<IFeature> featureList = new List<IFeature>();
                    FeatureLayer featureLayer = mainMap.Layers[0] as FeatureLayer;
                    ISelection selectedFeature = featureLayer.Selection;
                    try
                    {
                        featureList = selectedFeature.ToFeatureList();
                        List<int> rows = featureList.ConvertAll(f => (int) f.Fid);
                        //String rowId = featureList[0].Fid.ToString(); //get selected row id

                        List<V_FULL_SOWN_LOG> queryResult = dbController.getSownHistory(rows);
                        detailsInfoWindow.loadDataToGridView(queryResult);
                        detailsInfoWindow.Show();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Błąd pobierania danych z bazy", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //TODO add logging error into file
                    }

                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Błąd wczytywania mapy", "BŁĄD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
