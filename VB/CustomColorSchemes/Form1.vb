Imports DevExpress.XtraReports.Wizards
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace CustomColorSchemes
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()

            'Register the wizard customization service.
            reportDesigner1.AddService(GetType(IWizardCustomizationService), New WizardCustomizationService())
        End Sub
    End Class
End Namespace
