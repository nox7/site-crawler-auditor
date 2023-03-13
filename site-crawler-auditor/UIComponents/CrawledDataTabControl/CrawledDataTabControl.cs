using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace site_crawler_auditor.UIComponents.CrawledDataTabControl;

internal class CrawledDataTabControl
{

    public TabControl element;

    public CrawledDataTabControl(TabControl element)
    {
        this.element = element;
    }
}
