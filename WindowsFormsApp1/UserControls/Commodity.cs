using DefineData;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsApp
{

    public partial class Commodity : UserControl
    {
        private Color color;
        public Commodity()
        {
            InitializeComponent();
        }
        public Commodity(Color color)
        {
            this.color = color;
            InitializeComponent();
        }

        CommodityDetaile commodityDetaile = null;
        public void chgSpiChg()
        {
            Console.WriteLine(splitContainer1.Panel2.Controls.Count);
            if (splitContainer1.Panel2.Controls.Count < 2)
            {
                commodityDetaile = new CommodityDetaile(this.color);
                commodityDetaile.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(commodityDetaile);
            }
            commodityDetaile.BringToFront();
        }


        CommodityList commodityList;
        private void Commodity_Load(object sender, EventArgs e)
        {
            commodityList = new CommodityList(this.color,new CommodityChgDelegate(this.chgSpiChg));
            commodityList.Dock = DockStyle.Fill;
            this.BackColor = Color.Transparent;
            splitContainer1.Panel2.Controls.Add(commodityList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            commodityList.BringToFront();
        }
    }
}
