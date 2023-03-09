using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace site_crawler_auditor.UIComponents.CrawlGrid
{
    internal class URLTextBox
    {

        public TextBox element;

        public URLTextBox(TextBox textBox) {
            element = textBox;
            element.GotFocus += onGotFocus;
        }

        public void onGotFocus(object sender, RoutedEventArgs e)
        {
            this.element.Text = "";
        }
    }
}
