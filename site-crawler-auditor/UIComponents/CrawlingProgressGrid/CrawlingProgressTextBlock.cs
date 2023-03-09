using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace site_crawler_auditor.UIComponents.CrawlingProgressGrid;

internal class CrawlingProgressTextBlock
{

    public TextBlock element;

    public CrawlingProgressTextBlock(TextBlock textBlock)
    {
        element = textBlock;
    }
}
