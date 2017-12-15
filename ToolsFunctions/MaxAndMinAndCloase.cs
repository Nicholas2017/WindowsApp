using DefineData;
using System.Windows.Forms;

namespace ToolsFunctions
{
    public class MaxAndMinAndCloase
    {
        public static void MinMaxCloseClickMeans(Form Frm_Tem, Operatetype op)
        {
            switch (op)
            {
                //最小化
                case Operatetype.min:
                    Frm_Tem.WindowState = FormWindowState.Minimized;
                    break;
                //最大化
                case Operatetype.max:
                    {
                        if (Frm_Tem.WindowState == FormWindowState.Maximized)
                            Frm_Tem.WindowState = FormWindowState.Normal;
                        else
                            Frm_Tem.WindowState = FormWindowState.Maximized;
                        break;
                    }
                //关闭
                case Operatetype.close:
                    Frm_Tem.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
