﻿

#pragma checksum "C:\Users\hamza\documents\visual studio 2013\Projects\toyota\toyota\starter.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5E79CBFC8206865F80D4ED6ADEF084E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace toyota
{
    partial class BlankPage1 : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 27 "..\..\starter.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.playSlideshow_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 28 "..\..\starter.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.pauseSlideshow_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 29 "..\..\starter.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.previousItem_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 30 "..\..\starter.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.nextItem_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


