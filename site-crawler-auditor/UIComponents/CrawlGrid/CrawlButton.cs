using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace site_crawler_auditor.UIComponents.CrawlGrid
{
    internal class CrawlButton
    {

        public Button element;

        public CrawlButton(Button button)
        {
            element = button;
            element.Click += onClick;
        }

        public void onClick(object sender, RoutedEventArgs e)
        {
            MainWindow.GetInstance()!.GetCrawlGrid().element.Visibility = Visibility.Collapsed;
            MainWindow.GetInstance()!.GetCrawlProgressGrid().element.Visibility = Visibility.Visible;
        }
    }
}
