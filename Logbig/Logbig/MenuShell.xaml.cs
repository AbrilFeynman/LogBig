﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Logbig
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuShell : Shell
    {
        public MenuShell()
        {
            InitializeComponent();
        }
    }
}