using System.Windows;

namespace IoCBox
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2(IVm vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
