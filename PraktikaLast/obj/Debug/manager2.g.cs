﻿#pragma checksum "..\..\manager2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1A22F5F736D732DB74134B45A27DFC9A806B4C9BB81D3B600114D90DD0CB74CE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using PraktikaLast;
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


namespace PraktikaLast {
    
    
    /// <summary>
    /// manager2
    /// </summary>
    public partial class manager2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\manager2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_roli;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\manager2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_sotrudniki;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\manager2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid RoliGrid;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\manager2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_udalenie;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\manager2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_izmena;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\manager2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_dobavit;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\manager2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nazvaniebox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\manager2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox stoimostbox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\manager2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox kolichestvobox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\manager2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo;
        
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
            System.Uri resourceLocater = new System.Uri("/PraktikaLast;component/manager2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\manager2.xaml"
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
            this.button_roli = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\manager2.xaml"
            this.button_roli.Click += new System.Windows.RoutedEventHandler(this.button_roli_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Button_sotrudniki = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.RoliGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 14 "..\..\manager2.xaml"
            this.RoliGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RoliGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Button_udalenie = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\manager2.xaml"
            this.Button_udalenie.Click += new System.Windows.RoutedEventHandler(this.Button_udalenie_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button_izmena = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\manager2.xaml"
            this.button_izmena.Click += new System.Windows.RoutedEventHandler(this.button_izmena_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Button_dobavit = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\manager2.xaml"
            this.Button_dobavit.Click += new System.Windows.RoutedEventHandler(this.Button_dobavit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.nazvaniebox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.stoimostbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.kolichestvobox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.combo = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

