﻿using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;

namespace PluginDeployer
{
    [Guid("f4c786fd-06cb-458e-94e1-d5d55b9fa9d7")]
    public sealed class MyToolWindow : ToolWindowPane
    {
        public MyToolWindow() :
            base(null)
        {
            Caption = Resources.ToolWindowTitle;
            BitmapResourceID = 301;
            BitmapIndex = 1;
            Content = new PluginList();
        }
    }
}
