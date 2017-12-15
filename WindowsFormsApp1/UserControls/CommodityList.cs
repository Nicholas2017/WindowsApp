using System;
using System.Drawing;
using System.Windows.Forms;
using HttpHelper;
using System.Collections;
using System.Data;
using DefineData;

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            //HttpHelper1.testGet(BindingData bindData);
        }

        #region 绑定数据--商品行情列表
        public void BindingDataGrid(DataTable dataTable)
        {
            dataGridView1.DataSource = dataTable;
        }
   
        #endregion
    }
}
