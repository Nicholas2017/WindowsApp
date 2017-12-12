using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class MainWindow : Form
    {
        #region 全局变量定义区
        Point mouseOff;                                     //鼠标移动位置变量
        bool leftFlag;                                      //标记是否为左键

        Commodity commodity;                                //商品控件
        Trade trade;                                        //交易控件
        Color MyBackColor = Color.FromArgb(30, 30, 30);     //主色调
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MaxAndMinAndCloase.MinMaxCloseClickMeans(this, Operatetype.close);
        }
        #endregion

        #region 自适应调用事件

        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            //asc.controlAutoSize(this);
        }


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
        #endregion

        #region 主窗体 load事件 加在子控件 商品&交易 设置背景主色调
                
        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.BackColor = MyBackColor;

            commodity = new Commodity(this.BackColor);
            commodity.Dock = DockStyle.Fill;
            this.splitContainer1.Panel1.Controls.Add(commodity);

            trade = new Trade(this.BackColor);
            trade.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(trade);
        }
        #endregion

        #region 锁定按钮事件
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Invoke(new EventHandler(delegate {
            if (button1.Text.Equals("锁定"))
                {
                    this.commodity.Enabled = false;
                    this.trade.Enabled = false;
                    button1.Text = "解锁";
                }
                else
                {
                    this.commodity.Enabled = true;
                    this.trade.Enabled = true;
                    button1.Text = "锁定";
                }
            }));
        }
        #endregion
    }
}
