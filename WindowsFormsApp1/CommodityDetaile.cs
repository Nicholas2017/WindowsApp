using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class CommodityDetaile : UserControl
    {
        private Color color;
        public CommodityDetaile()
        {
            InitializeComponent();
        }
        public CommodityDetaile( Color color)
        {
            this.color = color;
            InitializeComponent();
        }

        private void CommodityDetaile_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }
    }
}
