﻿#pragma checksum "..\..\..\Select_Sort.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14D41602478769CE55E81413F5A93E11D714DEA4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Finance_Manager_Design;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Finance_Manager_Design {
    
    
    /// <summary>
    /// Select_Sort
    /// </summary>
    public partial class Select_Sort : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\Select_Sort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_day;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Select_Sort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_week;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Select_Sort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_month;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Select_Sort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_year;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Select_Sort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_all_time;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Select_Sort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_range;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Finance_Manager_Design;component/select_sort.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Select_Sort.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.b_day = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Select_Sort.xaml"
            this.b_day.Click += new System.Windows.RoutedEventHandler(this.b_day_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.b_week = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Select_Sort.xaml"
            this.b_week.Click += new System.Windows.RoutedEventHandler(this.b_week_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.b_month = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Select_Sort.xaml"
            this.b_month.Click += new System.Windows.RoutedEventHandler(this.b_month_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.b_year = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Select_Sort.xaml"
            this.b_year.Click += new System.Windows.RoutedEventHandler(this.b_year_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.b_all_time = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Select_Sort.xaml"
            this.b_all_time.Click += new System.Windows.RoutedEventHandler(this.b_all_time_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.b_range = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Select_Sort.xaml"
            this.b_range.Click += new System.Windows.RoutedEventHandler(this.b_range_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

