using site_crawler_auditor.UIComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace site_crawler_auditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        internal URLTextBox? urlTextBox;

        public MainWindow()
        {
            InitializeComponent();
            LoadElementsIntoComponents();
        }

        private void LoadElementsIntoComponents()
        {
            urlTextBox = new URLTextBox((TextBox)this.FindName("URLTextBox"));
        }
    }
}
