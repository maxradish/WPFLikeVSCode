﻿#pragma checksum "..\..\..\..\Controls\MyDateTimeControl\myTimePicker.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11EECF1A4A1D67F564B3039109E4098A2A8AE503"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Alarm.Main.Controls;
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


namespace Alarm.Main.Controls {
    
    
    /// <summary>
    /// myTimePicker
    /// </summary>
    public partial class myTimePicker : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\..\Controls\MyDateTimeControl\myTimePicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridPPP;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Controls\MyDateTimeControl\myTimePicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border1;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Controls\MyDateTimeControl\myTimePicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTimeValue;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Controls\MyDateTimeControl\myTimePicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button iconButton1;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\Controls\MyDateTimeControl\myTimePicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Highlight;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\..\Controls\MyDateTimeControl\myTimePicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border DisabledVisual;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\Controls\MyDateTimeControl\myTimePicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popChioce;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFVsCode;component/controls/mydatetimecontrol/mytimepicker.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Controls\MyDateTimeControl\myTimePicker.xaml"
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
            
            #line 9 "..\..\..\..\Controls\MyDateTimeControl\myTimePicker.xaml"
            ((Alarm.Main.Controls.myTimePicker)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gridPPP = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.border1 = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.txtTimeValue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.iconButton1 = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\..\Controls\MyDateTimeControl\myTimePicker.xaml"
            this.iconButton1.Click += new System.Windows.RoutedEventHandler(this.iconButton1_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Highlight = ((System.Windows.Controls.Border)(target));
            return;
            case 7:
            this.DisabledVisual = ((System.Windows.Controls.Border)(target));
            return;
            case 8:
            this.popChioce = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

