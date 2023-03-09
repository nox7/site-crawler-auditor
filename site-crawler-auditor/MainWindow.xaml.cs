using site_crawler_auditor.UIComponents.CrawlGrid;
using site_crawler_auditor.UIComponents.CrawlingProgressGrid;
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

        // Follow singleton pattern. Allows access to the UI components
        private static MainWindow? Instance { get; set; }

        internal URLTextBox? urlTextBox;
        internal CrawlButton? crawlButton;
        internal CrawlGrid? crawlGrid;
        internal CrawlingProgressGrid? crawlingProgressGrid;

        public static MainWindow? GetInstance()
        {
            return MainWindow.Instance;
        }

        public MainWindow()
        {
            InitializeComponent();
            LoadElementsIntoComponents();
            MainWindow.Instance = this;
        }

        private void LoadElementsIntoComponents()
        {
            urlTextBox = new URLTextBox((TextBox)this.FindName("URLTextBox"));
            crawlButton = new CrawlButton((Button)this.FindName("CrawlButton"));
            crawlGrid = new CrawlGrid((Grid)this.FindName("CrawlGrid"));
            crawlingProgressGrid = new CrawlingProgressGrid((Grid)this.FindName("CrawlingProgressGrid"));
        }

        internal CrawlGrid GetCrawlGrid()
        {
            return this.crawlGrid!;
        }

        internal CrawlingProgressGrid GetCrawlProgressGrid()
        {
            return this.crawlingProgressGrid!;
        }
    }
}
