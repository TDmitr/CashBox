﻿#pragma checksum "..\..\PrintCheck.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "71DD8CA0AD722B3F531081D2EF7CBBF2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Cashbox;
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


namespace Cashbox {
    
    
    /// <summary>
    /// PrintCheck
    /// </summary>
    public partial class PrintCheck : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\PrintCheck.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PABox;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\PrintCheck.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PA;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\PrintCheck.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Total;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\PrintCheck.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Count;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\PrintCheck.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TotalResult;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\PrintCheck.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NumberResult;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\PrintCheck.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pay;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\PrintCheck.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Print;
        
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
            System.Uri resourceLocater = new System.Uri("/Cashbox;component/printcheck.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PrintCheck.xaml"
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
            
            #line 8 "..\..\PrintCheck.xaml"
            ((Cashbox.PrintCheck)(target)).Loaded += new System.Windows.RoutedEventHandler(this.PrintCheck_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PABox = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\PrintCheck.xaml"
            this.PABox.KeyDown += new System.Windows.Input.KeyEventHandler(this.PABox_OnKeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PA = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Total = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Count = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.TotalResult = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.NumberResult = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Pay = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\PrintCheck.xaml"
            this.Pay.Click += new System.Windows.RoutedEventHandler(this.Pay_OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Print = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

