﻿

#pragma checksum "D:\Github\DungeonWorldMaster\Dungeon World Master\Dungeon World Master\CustomControls\HexagonGrid.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5CA8597B344FFC0E26458E51D452C88F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dungeon_World_Master.CustomControls
{
    partial class HexagonGrid : global::Windows.UI.Xaml.Controls.UserControl, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 18 "..\..\..\CustomControls\HexagonGrid.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.hexagon2_Tapped;
                 #line default
                 #line hidden
                #line 18 "..\..\..\CustomControls\HexagonGrid.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerEntered += this.hexagon2_PointerEntered;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

