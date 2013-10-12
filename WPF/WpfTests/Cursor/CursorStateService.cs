using System;
using System.Windows.Input;

namespace BusyCursor
{
    public class CursorStateService : ICursorStateService
    {
        private ICursor _myCursor;
        private int _nestedLevel;

        public CursorStateService()
        {
            _myCursor = new Cursor();
            _myCursor.ApplicationCursor = Cursors.Arrow;
        }

        public void SetCursorBusy()
        {
            SetBusyState(true, false);
        }

        public void FinishForcedFreeCursor()
        {
            SetBusyState(true, false);
        }

        public void SetCursorFreeNormal()
        {
            SetBusyState(false, false);
        }

        public void SetCursorFreeForce()
        {
            SetBusyState(false, true);
        }

        public ICursor Cursor
        {
            get { return _myCursor; }
        }

        private void SetBusyState(bool busy, bool isForce)
        {
            if (busy)
            {
                _nestedLevel++;
                _myCursor.ApplicationCursor = Cursors.Wait;
            }
            else
            {
                _nestedLevel--;
                if (_nestedLevel == 0 || isForce)
                {
                    _myCursor.ApplicationCursor = Cursors.Arrow;
                }
            }
        }
    }
}