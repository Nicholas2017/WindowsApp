using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace HttpHelper
{
    public class UnPackageData
    {
        /**
         * 将行情数据解析为datagridview的数据
         **/
        public static DataTable CommodityListDataGridView(string quoteStr)
        {
            ArrayList arrayList = new ArrayList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Contract");
            dt.Columns.Add("ContractName");
            dt.Columns.Add("NewPrice");
            dt.Columns.Add("UpAdDown");
            dt.Columns.Add("BuyPrice");
            dt.Columns.Add("BuyCount");
            dt.Columns.Add("SellPrice");
            dt.Columns.Add("SellCount");
            dt.Columns.Add("Volume");
            dt.Columns.Add("Positions");
            dt.Columns.Add("UpStopPrice");
            dt.Columns.Add("DownStopPrice");
            dt.Columns.Add("TodayOpenPrice");
            dt.Columns.Add("TodayClosePrice");
            dt.Columns.Add("YestedaySettlement");
            dt.Columns.Add("TopPrice");

            if (quoteStr.Length >= 23)                          //没有行情：?({success:true,data:'a,a,a,a;b,b,b,b;c,c,c,c'
            {
                string[] str = quoteStr.Split('\'');            //所有商品行情数据
                if (str[1] != null)
                {
                    string[] allCommodity = str[1].Split(';');    //每个商品的行情数据 a,a,a,a;b,b,b,b;c,c,c,c
                    foreach (string oneCommodity in allCommodity)
                    {
                        DataRow row = dt.NewRow();
                        string[] queteCommodity = oneCommodity.Split(',');

                        //把解析出来的行情信息绑定到dataGridview，此处必须严格按照约定一一对应；
                        row["Contract"] = queteCommodity[0];//合约
                        row["NewPrice"] = queteCommodity[9];//最新价
                        row["SellPrice"] = queteCommodity[1];//卖价
                        row["SellCount"] = queteCommodity[2];//卖量
                        row["BuyPrice"] = queteCommodity[3];//买价
                        row["BuyCount"] = queteCommodity[4];//买量
                        row["TodayOpenPrice"] = queteCommodity[6];//今开盘
                        row["TopPrice"] = queteCommodity[7];//最高价
                        row["YestedaySettlement"] = queteCommodity[16];//昨结算
                        row["Volume"] = queteCommodity[13];//总手数
                        row["Positions"] = queteCommodity[14];//总手数
                        row["UpStopPrice"] = queteCommodity[17];//涨停价
                        row["DownStopPrice"] = queteCommodity[18];//跌停价

                        dt.Rows.Add(row);
                    }
                }
            }        
            else
            {
                MessageBox.Show("行情数据为空");
                return null;
            }
            return dt;
        }
    }
}
