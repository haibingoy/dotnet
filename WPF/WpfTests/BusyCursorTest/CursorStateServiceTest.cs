using System;
using System.Windows.Input;
using BusyCursor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusyCursorTest
{
    [TestClass]
    public class CursorStateServiceTest
    {
        [TestMethod]
        public void Construction_Null_CursorIsArrow()
        {
            CursorStateService cursorStateService = new CursorStateService();
            Assert.AreEqual(Cursors.Arrow, cursorStateService.Cursor.ApplicationCursor);
        }

        [TestMethod]
        public void SetBusyNormal_Once_CursorIsWait()
        {
            CursorStateService cursorStateService = new CursorStateService();
            cursorStateService.SetCursorBusy();
            Assert.AreEqual(Cursors.Wait, cursorStateService.Cursor.ApplicationCursor);
        }

        [TestMethod]
        public void SetBusyNormal_MoreThanOneTime_CursorIsWait()
        {
            CursorStateService cursorStateService = new CursorStateService();
            cursorStateService.SetCursorBusy();
            cursorStateService.SetCursorBusy();
            cursorStateService.SetCursorBusy();
            Assert.AreEqual(Cursors.Wait, cursorStateService.Cursor.ApplicationCursor);
        }

        [TestMethod]
        public void SetBusyNormal_OnceAndSetFreeTimeOnce_CursorIsArrow()
        {
            CursorStateService cursorStateService = new CursorStateService();
            cursorStateService.SetCursorBusy();
            cursorStateService.SetCursorFreeNormal();
            Assert.AreEqual(Cursors.Arrow, cursorStateService.Cursor.ApplicationCursor);
        }

        [TestMethod]
        public void SetBusyNormal_OnceAndSetFreeTimeMoreThanOnce_CursorIsArrow()
        {
            CursorStateService cursorStateService = new CursorStateService();
            cursorStateService.SetCursorBusy();
            cursorStateService.SetCursorFreeNormal();
            cursorStateService.SetCursorFreeNormal();
            Assert.AreEqual(Cursors.Arrow, cursorStateService.Cursor.ApplicationCursor);
        }

        [TestMethod]
        public void SetBusyNormal_MoreThanOneTimeAndSetFreeTimeOnce_CursorIsWait()
        {
            CursorStateService cursorStateService = new CursorStateService();
            cursorStateService.SetCursorBusy();
            cursorStateService.SetCursorBusy();
            cursorStateService.SetCursorBusy();
            cursorStateService.SetCursorFreeNormal();
            Assert.AreEqual(Cursors.Wait, cursorStateService.Cursor.ApplicationCursor);
        }

        [TestMethod]
        public void SetBusyNormal_MoreThanOneTimeAndSetFreeTimeSameTimes_CursorIsArrow()
        {
            CursorStateService cursorStateService = new CursorStateService();
            cursorStateService.SetCursorBusy();
            cursorStateService.SetCursorBusy();
            cursorStateService.SetCursorFreeNormal();
            cursorStateService.SetCursorFreeNormal();
            Assert.AreEqual(Cursors.Arrow, cursorStateService.Cursor.ApplicationCursor);
        }

        [TestMethod]
        public void SetBusyNormal_MoreThanOneTimeAndSetFreeForceOnce_CursorIsArrow()
        {
            CursorStateService cursorStateService = new CursorStateService();
            cursorStateService.SetCursorBusy();
            cursorStateService.SetCursorBusy();
            cursorStateService.SetCursorFreeForce();
            Assert.AreEqual(Cursors.Arrow, cursorStateService.Cursor.ApplicationCursor);
        }

        [TestMethod]
        public void SetBusyNormal_MoreThanOneTimeAndSetFreeForceOnceThenFinishForedFree_CursorIsWait()
        {
            CursorStateService cursorStateService = new CursorStateService();
            cursorStateService.SetCursorBusy();
            cursorStateService.SetCursorBusy();
            cursorStateService.SetCursorFreeForce();
            cursorStateService.FinishForcedFreeCursor();
            Assert.AreEqual(Cursors.Wait, cursorStateService.Cursor.ApplicationCursor);
        }

        [TestMethod]
        public void SetBusyNormal_ComplexFlow_CursorIsWait()
        {
            CursorStateService cursorStateService = new CursorStateService();
            cursorStateService.SetCursorBusy();
            cursorStateService.SetCursorBusy();
            cursorStateService.SetCursorFreeForce();
            cursorStateService.FinishForcedFreeCursor();
            cursorStateService.SetCursorFreeNormal();
            Assert.AreEqual(Cursors.Wait, cursorStateService.Cursor.ApplicationCursor);
        }

        [TestMethod]
        public void SetBusyNormal_ComplexFlow_CursorIsArrow()
        {
            CursorStateService cursorStateService = new CursorStateService();
            cursorStateService.SetCursorBusy();
            cursorStateService.SetCursorBusy();
            cursorStateService.SetCursorFreeForce();
            cursorStateService.FinishForcedFreeCursor();
            cursorStateService.SetCursorFreeNormal();
            cursorStateService.SetCursorFreeNormal();
            Assert.AreEqual(Cursors.Arrow, cursorStateService.Cursor.ApplicationCursor);
        }
    }
}
