﻿#pragma checksum "..\..\..\ucObaveza.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FA2CFE0BC5CC27496E667DDC82CA7830DFD00413"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace ToDo {
    
    
    /// <summary>
    /// ucObaveza
    /// </summary>
    public partial class ucObaveza : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\ucObaveza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mniPromjeniStatus;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\ucObaveza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mniIzmjeniObavezu;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\ucObaveza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mniObrisiObavezu;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\ucObaveza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Okvir;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\ucObaveza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgSlika;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\ucObaveza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblNaziv;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\ucObaveza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblOpis;
        
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
            System.Uri resourceLocater = new System.Uri("/ToDo;component/ucobaveza.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ucObaveza.xaml"
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
            this.mniPromjeniStatus = ((System.Windows.Controls.MenuItem)(target));
            
            #line 10 "..\..\..\ucObaveza.xaml"
            this.mniPromjeniStatus.Click += new System.Windows.RoutedEventHandler(this.mniPromjeniStatus_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mniIzmjeniObavezu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 11 "..\..\..\ucObaveza.xaml"
            this.mniIzmjeniObavezu.Click += new System.Windows.RoutedEventHandler(this.mniIzmjeniObavezu_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.mniObrisiObavezu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 12 "..\..\..\ucObaveza.xaml"
            this.mniObrisiObavezu.Click += new System.Windows.RoutedEventHandler(this.mniObrisiObavezu_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Okvir = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.imgSlika = ((System.Windows.Controls.Image)(target));
            
            #line 25 "..\..\..\ucObaveza.xaml"
            this.imgSlika.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.imgSlika_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblNaziv = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lblOpis = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

