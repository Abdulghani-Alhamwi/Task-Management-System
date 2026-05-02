using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_Project.Screens
{
    internal class clsResponsiveDesign
    {
        public static Panel GetResponsiveDesign(Size PanelSize)
        {
            return new Panel
            {
                Size = PanelSize,
                Dock = DockStyle.Top,
                BackColor = Color.Transparent,
                AutoScroll = true 
            };
        }
    }
}
