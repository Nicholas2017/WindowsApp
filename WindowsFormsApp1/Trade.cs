using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Trade : UserControl
    {
        private Color color;
        public Trade()
        {
            InitializeComponent();
        }
        public Trade( Color color)
        {
            this.color = color;
            InitializeComponent();
        }
        private void Trade_Load(object sender, EventArgs e)
        {
            trackBar1.BackColor = this.color;
            trackBar2.BackColor = this.color;
            dataGridView1.BackgroundColor = this.color;
        }
    }
}
