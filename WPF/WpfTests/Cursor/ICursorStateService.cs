using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusyCursor
{
    public interface ICursorStateService
    {
        ICursor Cursor { get; }

        void SetCursorBusy();

        void SetCursorFreeNormal();

        void SetCursorFreeForce();

        void FinishForcedFreeCursor();
    }
}
