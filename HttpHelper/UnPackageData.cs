using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpHelper
{
    public class UnPackageData
    {
        /**
         * 将行情数据解析为datagridview的数据
         **/
        
        public static ArrayList CommodityList_DataGridView(string quoteStr)
        {
            string[] quo = null;
            ArrayList al = new ArrayList();
            if (quoteStr != null)
            {
                string[] str = quoteStr.Split('\'');
                if (str[1] != null)
                {
                    quo = str[1].Split(';');
                }
            }
            else
            {

            }
            
            foreach (string item in quo)
            {
                //Console.WriteLine(item.ToArray());
                //al.AddRange(item.ToList());
                //item.Split(',');
                // al.AddRange(item.Split(','));
                //al.Add(item);
                //al.AddRange(item.ToList());
                //Console.WriteLine(item);
                al.AddRange(item.ToArray());
            }
            Console.WriteLine("======:" + al);
            //foreach (var item in al)
            //{
            //    Console.WriteLine("======:" + al);
            //}
            String s = "HG1803,3.0410,9,3.0405,15,3.0535,3.0565,3.0645,3.0320,3.0410,0.0000,3.0535,29660,0,134754,0,3.0535,3.2535,2.8535,1513234879000,-20.0,20.0,1513234879000;YM1803,24674,9,24672,7,24646,24650,24680,24635,24673,0,24646,8183,0,132187,0,24646,25845,23387,1513234882000,-20.0,20.0,1513234882000";

            Console.WriteLine(s.Split(','));
            
            return al;
        }
    }
}
