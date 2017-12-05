using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsApp.WindosStatusEnum;

namespace WindowsApp
{
    public partial class MainWindow : Form
    {
        #region 全局变量定义区
        AutoSizeFormClass asc = new AutoSizeFormClass();
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标记是否为左键

        #endregion

        public MainWindow()
        {
            InitializeComponent();  
        }

        #region 窗体自由移动 & 最大化 &最小化
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            MaxAndMinAndCloase.MinMaxCloseClickMeans(this, Operatetype.max);
        }


        private void pictureBox_Min_Click(object sender, EventArgs e)
        {
            MaxAndMinAndCloase.MinMaxCloseClickMeans(this, Operatetype.min);
        }
        #endregion

        #region 自适应调用事件

        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            //asc.controlAutoSize(this);
        }


        #endregion

        #region 防止闪屏
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion

        #region 主窗体 load事件 加在子控件 商品&交易 

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Commodity commodity = new Commodity();
            commodity.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            splitContainer1.Panel1.Controls.Add(commodity);

            Trade trade = new Trade();
            trade.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            splitContainer1.Panel2.Controls.Add(trade);
        }
        #endregion
    }
}
