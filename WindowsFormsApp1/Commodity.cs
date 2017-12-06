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
        private void Commodity_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = this.color;
        }
    }
}
