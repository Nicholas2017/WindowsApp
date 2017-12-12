using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsApp
{  
    public partial class CommodityList : UserControl
    {
        
        private Color color;
        private CommodityChgDelegate chd;
        public CommodityList()
        {
            InitializeComponent();
        }
        public CommodityList(Color color, CommodityChgDelegate chd)
        {
            this.color = color;
            this.chd = chd;
            InitializeComponent();
        }
        private void CommodityList_DoubleClick(object sender, EventArgs e)
        {
            chd();
        }

        private void CommodityList_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }
    }
}
