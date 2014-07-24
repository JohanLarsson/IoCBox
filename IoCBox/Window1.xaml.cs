using System.Windows;

namespace IoCBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1(IVm vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
