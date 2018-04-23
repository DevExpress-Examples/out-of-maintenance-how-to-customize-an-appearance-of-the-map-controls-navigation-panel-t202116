using System;
using System.Windows.Forms;

namespace NavigationPanelOptions {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        #region #NavigationPanelOptions
        private void Form1_Load(object sender, EventArgs e) {
            mapControl1.NavigationPanelOptions.XCoordinatePattern = "{CP}{D}.{M}.{S:4}";
            mapControl1.NavigationPanelOptions.YCoordinatePattern = "{CP}{D}.{M}.{S:4}";
            mapControl1.NavigationPanelOptions.ShowKilometersScale = false;
            mapControl1.NavigationPanelOptions.ShowMilesScale = false;
            mapControl1.NavigationPanelOptions.ShowScrollButtons = false;
        }
        #endregion #NavigationPanelOptions
    }
}
