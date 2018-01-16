using DefineData;
using System;
using System.Drawing;
using System.Windows.Forms;
using ToolsFunctions;

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

        Rectangle lastrect = new Rectangle();               //记录上次窗体的大小
        bool isMax = false;
        double formoldwidth;                                //窗体原始宽度   
        double formoldheight;                               //窗体原始高度 
        #endregion

        public MainWindow() 
        {
            InitializeComponent();  
        }

        #region 缩放时，控制控件的比例
        private void MainWindow_Resize(object sender, EventArgs e)
        {
            double scalex;  //水平伸缩比   
            double scaley;  //垂直伸缩比   
            long i;
            int temppos;
            string temptag;
            double[] pos = new double[4];   //pos数组保存当前控件的left,top,width,height    

            scalex = (double)this.Width / formoldwidth;
            scaley = (double)this.Height / formoldheight;
            foreach (Control ctrl in this.Controls)
            {
                temptag = ctrl.Tag.ToString();
                for (i = 0; i <= 3; i++)
                {
                    temppos = temptag.IndexOf(" ");
                    if (temppos > 0)
                    {
                        pos[i] = Convert.ToDouble(temptag.Substring(0, temppos));   //从Tag中取出参数   
                        temptag = temptag.Substring(temppos + 1);
                    }
                    else
                        pos[i] = 0;
                }
                ctrl.Left = (int)(pos[0] * scalex);
                ctrl.Top = (int)(pos[1] * scaley);
                ctrl.Width = (int)(pos[2] * scalex);
                ctrl.Height = (int)((double)ctrl.Width / pos[3]);   //高度由宽高比算出   
            }
        }
        #endregion      

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
            if (isMax)
            {   
                this.Width = lastrect.Width;
                this.Height = lastrect.Height;
                isMax = false;
                Console.WriteLine("正常");
                Console.WriteLine(lastrect.Width + "|" + lastrect.Height);
            }
            else
            {
                lastrect.Width = this.Width;
                lastrect.Height = this.Height;
                this.Width = Screen.PrimaryScreen.WorkingArea.Width;
                this.Height = Screen.PrimaryScreen.WorkingArea.Height;
                isMax = true;
                Console.WriteLine("最大化");
            }
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

        #region 主窗体 load事件 加在子控件 商品&交易 设置背景主色调

        private void MainWindow_Load(object sender, EventArgs e)
        {

            double scalewh;     //控件宽高比    

            formoldwidth = (double)this.Width;
            formoldheight = (double)this.Height;
            foreach (Control ctrl in this.Controls)
            {
                scalewh = (double)ctrl.Width / (double)ctrl.Height;
                ctrl.Tag = ctrl.Left + " " + ctrl.Top + " " + ctrl.Width + " " + scalewh.ToString() + " ";     //将控件的Left,Top,Width,宽高比放入控件的Tag内   
            }


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
