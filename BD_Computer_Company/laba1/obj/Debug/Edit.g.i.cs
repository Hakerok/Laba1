﻿#pragma checksum "..\..\Edit.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5174AC97E9EF2B2B81BDE53C42D03DD9"
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
using System.Windows.Forms.Integration;
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


namespace laba1 {
    
    
    /// <summary>
    /// Window2
    /// </summary>
    public partial class Window2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label sp;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox typejob;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox castomer;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox malfunction;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox master;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox telephone;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox spareparts;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox discount;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox adress;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btOK;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SP;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox SPCH;
        
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
            System.Uri resourceLocater = new System.Uri("/laba1;component/edit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Edit.xaml"
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
            this.sp = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.typejob = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.castomer = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\Edit.xaml"
            this.castomer.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.castomer_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.malfunction = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.master = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.telephone = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\Edit.xaml"
            this.telephone.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.telephone_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.spareparts = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.discount = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.adress = ((System.Windows.Controls.ComboBox)(target));
            
            #line 55 "..\..\Edit.xaml"
            this.adress.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.adress_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btOK = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\Edit.xaml"
            this.btOK.Click += new System.Windows.RoutedEventHandler(this.add_edit_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 63 "..\..\Edit.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Сlean_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 64 "..\..\Edit.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 65 "..\..\Edit.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 14:
            this.SP = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\Edit.xaml"
            this.SP.Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 15:
            this.SPCH = ((System.Windows.Controls.CheckBox)(target));
            
            #line 67 "..\..\Edit.xaml"
            this.SPCH.Unchecked += new System.Windows.RoutedEventHandler(this.SPCH_Unchecked);
            
            #line default
            #line hidden
            
            #line 67 "..\..\Edit.xaml"
            this.SPCH.Checked += new System.Windows.RoutedEventHandler(this.SPCH_Checked_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
