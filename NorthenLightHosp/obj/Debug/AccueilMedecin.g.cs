﻿#pragma checksum "..\..\AccueilMedecin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6E4CB91F5EFB6E4795BF0D0E47AF7ECF7D999A26"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NorthenLightHosp;
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


namespace NorthenLightHosp {
    
    
    /// <summary>
    /// AccueilMedecin
    /// </summary>
    public partial class AccueilMedecin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\AccueilMedecin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblGreeting;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AccueilMedecin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AccueilMedecin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRecherche;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AccueilMedecin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboPatient;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AccueilMedecin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AccueilMedecin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgPatients;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\AccueilMedecin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConge;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\AccueilMedecin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgHistorique;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\AccueilMedecin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
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
            System.Uri resourceLocater = new System.Uri("/NorthenLightHosp;component/accueilmedecin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AccueilMedecin.xaml"
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
            this.lblGreeting = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.txtRecherche = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cboPatient = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\AccueilMedecin.xaml"
            this.cboPatient.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.dgPatients = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.btnConge = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\AccueilMedecin.xaml"
            this.btnConge.Click += new System.Windows.RoutedEventHandler(this.btnConge_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dgHistorique = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

