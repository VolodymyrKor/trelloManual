﻿#pragma checksum "..\..\..\Pages\RegistrationPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "61F40649E8D9E43B3A082E75DA0A373D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ManagmentManual.Pages;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace ManagmentManual.Pages {
    
    
    /// <summary>
    /// RegistrationPage
    /// </summary>
    public partial class RegistrationPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\Pages\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackToStartPage;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Pages\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border MainWrapper;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Pages\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StudentNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\Pages\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StudentSurnameTextBox;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\Pages\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StudentMiddleNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\Pages\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StudentEmailTextBox;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\Pages\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox StudentPasswordTextBox;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\..\Pages\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox StudentPassword2TextBox;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\..\Pages\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegisterStudentButton;
        
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
            System.Uri resourceLocater = new System.Uri("/ManagmentManual;component/pages/registrationpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\RegistrationPage.xaml"
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
            this.BackToStartPage = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Pages\RegistrationPage.xaml"
            this.BackToStartPage.Click += new System.Windows.RoutedEventHandler(this.BackToStartPage_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainWrapper = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.StudentNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.StudentSurnameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.StudentMiddleNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.StudentEmailTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.StudentPasswordTextBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 8:
            this.StudentPassword2TextBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 9:
            this.RegisterStudentButton = ((System.Windows.Controls.Button)(target));
            
            #line 185 "..\..\..\Pages\RegistrationPage.xaml"
            this.RegisterStudentButton.Click += new System.Windows.RoutedEventHandler(this.RegisterStudentButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

