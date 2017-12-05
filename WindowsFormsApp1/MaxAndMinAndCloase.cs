using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsApp.WindosStatusEnum;

namespace WindowsApp
{
    class MaxAndMinAndCloase
    {
        public static void MinMaxCloseClickMeans(Form Frm_Tem, WindosStatusEnum.Operatetype op)
        {
            switch (op)
            {
                //最小化
                case WindosStatusEnum.Operatetype.min:
                    Frm_Tem.WindowState = FormWindowState.Minimized;
                    break;
                //最大化
                case WindosStatusEnum.Operatetype.max:
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
