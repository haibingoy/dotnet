namespace BusyCursor
{
    public class Cursor : ICursor
    {
        public System.Windows.Input.Cursor ApplicationCursor
        {
            get { return System.Windows.Input.Mouse.OverrideCursor; }
            set { System.Windows.Input.Mouse.OverrideCursor = value; }
        }
    }
}