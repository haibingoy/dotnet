using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Input = System.Windows.Input;

namespace BusyCursor
{
    public interface ICursor
    {
        Input.Cursor ApplicationCursor { get; set; }
    }
}
