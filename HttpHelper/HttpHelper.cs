using JumpKick.HttpLib;
using System;
using System.Data;

namespace HttpHelper
{
    public class HttpHelper1
    {
        public static void testGet( )
        {
            DataTable dt;
            Http.Get("http://10.12.179.128:8480/quote.jsp?callback=%3F&code=HG1803%2CYM1803%2CNQ1803%2CBP1803%2CEC1803%2CMDAX1712%2CCL1801%2CGC1802%2CSI1803%2CHSI1712%2CMHI1712%2CCN1712%2CDAX1712%2CRB1801%2CPP1805%2CNI1801%2CCU1801%2CAG1712%2CAU1802%2CSR801%2CRU1805%2CTF1512%2CIF1712%2CIC1712%2CIH1712&").OnSuccess(result =>
            {
               dt = UnPackageData.CommodityListDataGridView(result);
            }).OnFail(webexception =>
            {
                Console.Write(webexception.Message);
            }).Go();

        }
    }
}