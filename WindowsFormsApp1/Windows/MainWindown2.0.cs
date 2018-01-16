using CCWin;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class MainWindown2 : Skin_Color
    {
        #region 全局变量定义区
        Color color = Color.FromArgb(0,0,0);             //设置窗体主色调
        Commodity commodity;                                //商品控件
        Trade trade;                                        //交易控件
        #endregion

        #region 防止闪屏
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;
        //        return cp;
        //    }
        //}

        //protected override void WndProc(ref Message m)
        //{

        //    if (m.Msg == 0x0014) // 禁掉清除背景消息  

        //        return;

        //    base.WndProc(ref m);

        //}
        protected override CreateParams CreateParams
        {
            get
            {

                CreateParams cp = base.CreateParams;

                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED    

                if (this.IsXpOr2003 == true)
                {
                    cp.ExStyle |= 0x00080000;  // Turn on WS_EX_LAYERED  
                    this.Opacity = 1;
                }

                return cp;

            }

        }  //防止闪烁  

        private Boolean IsXpOr2003
        {
            get
            {
                OperatingSystem os = Environment.OSVersion;
                Version vs = os.Version;

                if (os.Platform == PlatformID.Win32NT)
                    if ((vs.Major == 5) && (vs.Minor != 0))
                        return true;
                    else
                        return false;
                else
                    return false;
            }
        }

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
