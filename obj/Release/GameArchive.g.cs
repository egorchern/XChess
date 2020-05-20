﻿#pragma checksum "..\..\GameArchive.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "294DC98312A6E271E20628FFEF12CB2E3286277CDBC972E372847737D47D0C88"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Project_ChessWithInterface;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Project_ChessWithInterface {
    
    
    /// <summary>
    /// GameArchive
    /// </summary>
    public partial class GameArchive : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\GameArchive.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Project_ChessWithInterface.GameArchive GameArchiveWindow;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\GameArchive.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Games_lst;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\GameArchive.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Reset_btn;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\GameArchive.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\GameArchive.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameSearch_txt;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\GameArchive.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Copy;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\GameArchive.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DateSearch_txt;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\GameArchive.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Copy1;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\GameArchive.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MoveCountSearch_txt;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\GameArchive.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Search_btn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\GameArchive.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DisplayRecord_btn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\GameArchive.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back_btn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Project_ChessWithInterface;component/gamearchive.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GameArchive.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.GameArchiveWindow = ((Project_ChessWithInterface.GameArchive)(target));
            
            #line 8 "..\..\GameArchive.xaml"
            this.GameArchiveWindow.Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Games_lst = ((System.Windows.Controls.ListBox)(target));
            
            #line 10 "..\..\GameArchive.xaml"
            this.Games_lst.Loaded += new System.Windows.RoutedEventHandler(this.Games_list_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Reset_btn = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\GameArchive.xaml"
            this.Reset_btn.Click += new System.Windows.RoutedEventHandler(this.Reset_btn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.NameSearch_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.label_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.DateSearch_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.label_Copy1 = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.MoveCountSearch_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.Search_btn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\GameArchive.xaml"
            this.Search_btn.Click += new System.Windows.RoutedEventHandler(this.Search_btn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.DisplayRecord_btn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\GameArchive.xaml"
            this.DisplayRecord_btn.Click += new System.Windows.RoutedEventHandler(this.DisplayRecord_btn_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Back_btn = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\GameArchive.xaml"
            this.Back_btn.Click += new System.Windows.RoutedEventHandler(this.Back_btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
