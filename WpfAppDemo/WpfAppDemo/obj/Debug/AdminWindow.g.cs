﻿#pragma checksum "..\..\AdminWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DB603BD3963E8BD8EDB08E17B4C97D5E293DDD75DB403973E102AD924D5A03DA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfAppDemo;


namespace WpfAppDemo {
    
    
    /// <summary>
    /// AdminWindow
    /// </summary>
    public partial class AdminWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Boreder_Move;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TAuth;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Shutdown;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBAdmin;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BEnter;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid_ShowInfo;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BUpdate;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BEnd;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfAppDemo;component/adminwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminWindow.xaml"
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
            this.Boreder_Move = ((System.Windows.Controls.Border)(target));
            
            #line 12 "..\..\AdminWindow.xaml"
            this.Boreder_Move.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Boreder_Move_MouseDown_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TAuth = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.Button_Shutdown = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\AdminWindow.xaml"
            this.Button_Shutdown.Click += new System.Windows.RoutedEventHandler(this.Button_Shutdown_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CBAdmin = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\AdminWindow.xaml"
            this.CBAdmin.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CBAdmin_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BEnter = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\AdminWindow.xaml"
            this.BEnter.Click += new System.Windows.RoutedEventHandler(this.BEnter_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DataGrid_ShowInfo = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.BUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\AdminWindow.xaml"
            this.BUpdate.Click += new System.Windows.RoutedEventHandler(this.BUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BEnd = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\AdminWindow.xaml"
            this.BEnd.Click += new System.Windows.RoutedEventHandler(this.BEnd_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

