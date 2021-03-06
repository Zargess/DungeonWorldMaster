﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Dungeon_World_Master.CustomControls {
    public sealed partial class HexagonGrid : UserControl {
        public HexagonGrid() {
            this.InitializeComponent();
        }

        private void hexagon2_Tapped(object sender, TappedRoutedEventArgs e) {
            Debug.WriteLine("Tapped");
        }

        private void hexagon2_PointerEntered(object sender, PointerRoutedEventArgs e) {
            Debug.WriteLine("Entered");
        }
    }
}
