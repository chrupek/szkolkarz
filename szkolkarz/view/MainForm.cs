using DotSpatial.Data;
using DotSpatial.Symbology;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using szkolkarz.core;
using szkolkarz.core.utils;
using szkolkarz.view;


namespace szkolkarz.forms.main
{
    public partial class MainForm : Form
    {
        private bool infoON { get; set; }
        protected String[] itemsToRemoveByKeys = { "cmdNew", "cmdOpen", "cmdSave", "cmdPrint", "cmdMeasure", "cmdTable", "cmdInfo"};
        protected Dictionary<String, String> valuesToTranslate;
        private DBController dbController;
        

        
        public MainForm()
        {
            
            InitializeComponent();
            customizeToolStrip();
            dbController = new DBController();

        }

        private void customizeToolStrip()
        {
            removeUnusedControls();
            translateControls("polish");

        }

        public void removeUnusedControls()
        {
            for (int i=0; i<itemsToRemoveByKeys.Length; ++i)
                this.spatialToolStrip.Items.RemoveByKey(itemsToRemoveByKeys[i]);
        }

        public void translateControls(string language)
        {
            ToolStripItem[] items;
            TranslationManager translationManager = new TranslationManager();
            valuesToTranslate = translationManager.getTranslations(language);
            foreach (KeyValuePair<string, string> pair in valuesToTranslate)
            {
                items = this.spatialToolStrip.Items.Find(pair.Key, false);
                items[0].ToolTipText = pair.Value;
                if(pair.Key =="cmdZoom")   
                {
                    items[0].Image = szkolkarz.Properties.Resources.zoom_in;
                }
                if (pair.Key == "cmdZoomOut")
                {
                    items[0].Image = szkolkarz.Properties.Resources.zoom_out;
                }
            }
        
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
                List<IFeature> featureList = new List<IFeature>();
                ISelection selectedFeature = null;
                DetailsInformation detailsInfoWindow = new DetailsInformation();

                try
                {
 
                    FeatureLayer featureLayer = mainMap.Layers[0] as FeatureLayer;
                    selectedFeature = featureLayer.Selection;
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Błąd wczytywania mapy", "BŁĄD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    featureList = selectedFeature.ToFeatureList();
                    List<int> rows = featureList.ConvertAll(f => (int) f.Fid);
                    //String rowId = featureList[0].Fid.ToString(); //get selected row id

                    List<V_FULL_SOWN_LOG> queryResult = dbController.getSownHistory(rows);
                    detailsInfoWindow.loadDataToGridView(queryResult);
                    detailsInfoWindow.Show();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Błąd pobierania danych z bazy", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorLoger.writeErrorToFile(ex);
                }

            }
        }

    }
}
