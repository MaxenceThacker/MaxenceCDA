﻿#pragma checksum "..\..\..\ArticleWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2A2F891D3D5A82D4EA5223A0FF57BE5AF2DF5015"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using GestionProjet;
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


namespace GestionProjet {
    
    
    /// <summary>
    /// ArticleWindow
    /// </summary>
    public partial class ArticleWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\ArticleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Ajouter;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\ArticleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Modifier;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\ArticleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Supprimer;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\ArticleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Dupliquer;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\ArticleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Vider;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\ArticleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid listeProduits;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\ArticleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Category;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\ArticleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Typesproduit;
        
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
            System.Uri resourceLocater = new System.Uri("/GestionProjet;component/articlewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ArticleWindow.xaml"
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
            this.Btn_Ajouter = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\ArticleWindow.xaml"
            this.Btn_Ajouter.Click += new System.Windows.RoutedEventHandler(this.Btn_Ajouter_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Btn_Modifier = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\ArticleWindow.xaml"
            this.Btn_Modifier.Click += new System.Windows.RoutedEventHandler(this.Btn_Modifier_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Btn_Supprimer = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\ArticleWindow.xaml"
            this.Btn_Supprimer.Click += new System.Windows.RoutedEventHandler(this.Btn_Supprimer_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Btn_Dupliquer = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\ArticleWindow.xaml"
            this.Btn_Dupliquer.Click += new System.Windows.RoutedEventHandler(this.Btn_Dupliquer_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Btn_Vider = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\ArticleWindow.xaml"
            this.Btn_Vider.Click += new System.Windows.RoutedEventHandler(this.Btn_Vider_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.listeProduits = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.Btn_Category = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\ArticleWindow.xaml"
            this.Btn_Category.Click += new System.Windows.RoutedEventHandler(this.Btn_Category_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Btn_Typesproduit = ((System.Windows.Controls.Button)(target));
            
            #line 110 "..\..\..\ArticleWindow.xaml"
            this.Btn_Typesproduit.Click += new System.Windows.RoutedEventHandler(this.Btn_Typesproduit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

