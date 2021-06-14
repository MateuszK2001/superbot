using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superbot.Models.Commands
{
    interface IHavingMouseBtn
    {
        MouseButtons button { get; set; }
    }
}
