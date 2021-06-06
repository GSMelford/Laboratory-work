using System.Windows;
using System.Windows.Input;

namespace Lab_17
{
    public static class MousePosition
    {
        private static Point _mousePosition;
        
        public static int X
        {
            get
            {
                SetPosition();
                return (int)_mousePosition.X;
            }
        }
        
        public static int Y
        {
            get
            {
                SetPosition();
                return (int)_mousePosition.Y;
            }
        }

        private static void SetPosition()
        {
            _mousePosition  = Mouse.GetPosition(Application.Current.MainWindow);
        }
    }
}