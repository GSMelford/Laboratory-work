using System.Windows;

namespace Lab_17
{
    public static class WindowSize
    {
        public static int Width
        {
            get
            {
                if (Application.Current.MainWindow != null) return (int) Application.Current.MainWindow.ActualWidth;
                return 0;
            }
        }

        public static int Height
        {
            get
            {
                if (Application.Current.MainWindow != null) return (int) Application.Current.MainWindow.ActualHeight;
                return 0;
            }
        }
    }
}