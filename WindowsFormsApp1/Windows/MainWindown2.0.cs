using CCWin;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class MainWindown2 : Skin_Color
    {
        #region 全局变量定义区
        Color color = Color.FromArgb(64,64,64);             //设置窗体主色调
        Commodity commodity;                                //商品控件
        Trade trade;                                        //交易控件
        #endregion


        public MainWindown2()
        {
            InitializeComponent();
        }

        private void MainWindown2_Load(object sender, System.EventArgs e)
        {
            this.BackColor = color;
            this.CaptionBackColorBottom = color;
            this.CaptionBackColorTop = color;

            commodity = new Commodity(this.BackColor);
            commodity.Dock = DockStyle.Fill;
            this.splitContainer1.Panel1.Controls.Add(commodity);

            trade = new Trade(this.BackColor);
            trade.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(trade);
        }
    }
}
