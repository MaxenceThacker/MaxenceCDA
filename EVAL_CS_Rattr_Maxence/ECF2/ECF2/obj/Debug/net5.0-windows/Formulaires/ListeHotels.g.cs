﻿#pragma checksum "..\..\..\..\Formulaires\ListeHotels.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8B767997BC0B44D0F06DAC05F90EA042D8D66E52"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using ECF2.Formulaires;
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


namespace ECF2.Formulaires {
    
    
    /// <summary>
    /// ListeHotels
    /// </summary>
    public partial class ListeHotels : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Formulaires\ListeHotels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgListeHotels;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Formulaires\ListeHotels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_ajouterArticle;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Formulaires\ListeHotels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_modifierArticle;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Formulaires\ListeHotels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_supprimerArticle;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Formulaires\ListeHotels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_retour;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ECF2;component/formulaires/listehotels.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Formulaires\ListeHotels.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DgListeHotels = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.btn_ajouterArticle = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\Formulaires\ListeHotels.xaml"
            this.btn_ajouterArticle.Click += new System.Windows.RoutedEventHandler(this.btnActions_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_modifierArticle = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\Formulaires\ListeHotels.xaml"
            this.btn_modifierArticle.Click += new System.Windows.RoutedEventHandler(this.btnActions_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_supprimerArticle = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\Formulaires\ListeHotels.xaml"
            this.btn_supprimerArticle.Click += new System.Windows.RoutedEventHandler(this.btnActions_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_retour = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\Formulaires\ListeHotels.xaml"
            this.btn_retour.Click += new System.Windows.RoutedEventHandler(this.Retour);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

