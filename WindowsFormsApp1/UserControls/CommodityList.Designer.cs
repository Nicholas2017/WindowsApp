namespace WindowsApp
{
    partial class CommodityList
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Contract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpAndDown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Positions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpStopPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DownStopPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TodayOpenPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TodayClosePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YestedaySettlement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Contract,
            this.ContractName,
            this.NewPrice,
            this.UpAndDown,
            this.BuyPrice,
            this.BuyCount,
            this.SellPrice,
            this.SellCount,
            this.Volume,
            this.Positions,
            this.UpStopPrice,
            this.DownStopPrice,
            this.TodayOpenPrice,
            this.TodayClosePrice,
            this.YestedaySettlement,
            this.TopPrice});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(778, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // Contract
            // 
            this.Contract.DataPropertyName = "Contract";
            this.Contract.HeaderText = "合约";
            this.Contract.Name = "Contract";
            this.Contract.ReadOnly = true;
            // 
            // ContractName
            // 
            this.ContractName.HeaderText = "合约名";
            this.ContractName.Name = "ContractName";
            this.ContractName.ReadOnly = true;
            // 
            // NewPrice
            // 
            this.NewPrice.HeaderText = "最新价";
            this.NewPrice.Name = "NewPrice";
            this.NewPrice.ReadOnly = true;
            // 
            // UpAndDown
            // 
            this.UpAndDown.HeaderText = "涨跌";
            this.UpAndDown.Name = "UpAndDown";
            this.UpAndDown.ReadOnly = true;
            // 
            // BuyPrice
            // 
            this.BuyPrice.HeaderText = "买价";
            this.BuyPrice.Name = "BuyPrice";
            this.BuyPrice.ReadOnly = true;
            // 
            // BuyCount
            // 
            this.BuyCount.HeaderText = "买量";
            this.BuyCount.Name = "BuyCount";
            this.BuyCount.ReadOnly = true;
            // 
            // SellPrice
            // 
            this.SellPrice.HeaderText = "卖价";
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.ReadOnly = true;
            // 
            // SellCount
            // 
            this.SellCount.HeaderText = "卖量";
            this.SellCount.Name = "SellCount";
            this.SellCount.ReadOnly = true;
            // 
            // Volume
            // 
            this.Volume.HeaderText = "成交量";
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            // 
            // Positions
            // 
            this.Positions.HeaderText = "持仓量";
            this.Positions.Name = "Positions";
            this.Positions.ReadOnly = true;
            // 
            // UpStopPrice
            // 
            this.UpStopPrice.HeaderText = "涨停价";
            this.UpStopPrice.Name = "UpStopPrice";
            this.UpStopPrice.ReadOnly = true;
            // 
            // DownStopPrice
            // 
            this.DownStopPrice.HeaderText = "跌停价";
            this.DownStopPrice.Name = "DownStopPrice";
            this.DownStopPrice.ReadOnly = true;
            // 
            // TodayOpenPrice
            // 
            this.TodayOpenPrice.HeaderText = "今开盘";
            this.TodayOpenPrice.Name = "TodayOpenPrice";
            this.TodayOpenPrice.ReadOnly = true;
            // 
            // TodayClosePrice
            // 
            this.TodayClosePrice.HeaderText = "今收盘";
            this.TodayClosePrice.Name = "TodayClosePrice";
            this.TodayClosePrice.ReadOnly = true;
            // 
            // YestedaySettlement
            // 
            this.YestedaySettlement.HeaderText = "昨结算";
            this.YestedaySettlement.Name = "YestedaySettlement";
            this.YestedaySettlement.ReadOnly = true;
            // 
            // TopPrice
            // 
            this.TopPrice.HeaderText = "最高价";
            this.TopPrice.Name = "TopPrice";
            this.TopPrice.ReadOnly = true;
            // 
            // CommodityList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CommodityList";
            this.Size = new System.Drawing.Size(778, 318);
            this.Load += new System.EventHandler(this.CommodityList_Load);
            this.DoubleClick += new System.EventHandler(this.CommodityList_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contract;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpAndDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Positions;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpStopPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DownStopPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TodayOpenPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TodayClosePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn YestedaySettlement;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopPrice;
    }
}
