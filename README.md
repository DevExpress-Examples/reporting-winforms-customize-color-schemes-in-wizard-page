<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/180373107/23.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830428)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Reporting for WinForms - How to Customize the "Choose a Report Color Scheme" Wizard Page

This example demonstrates how to customize the [Choose a Report Color Scheme](https://docs.devexpress.com/XtraReports/400389/visual-studio-report-designer/report-wizard/table-report/choose-a-report-color-scheme) wizard page in WinForms applications.

## Implementation Details

Below are the main steps to change the color scheme set on the Report Wizard page:

1. Implement the [IColorSchemeStorage](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Wizards.ColorSchemes.IColorSchemeStorage) interface to create a storage for the wizard's custom color schemes.
2. Use the [AddColorScheme](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Wizards.ColorSchemes.IColorSchemeStorage.AddColorScheme(DevExpress.XtraReports.Wizards.ColorSchemes.ColorScheme)) method to add custom color schemes to the created storage.
3. Add a custom service that implements the [IWizardCustomizationService](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Wizards.IWizardCustomizationService) interface.
4. Register the custom color scheme storage in the [CustomizeReportWizard](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Wizards.IWizardCustomizationService.CustomizeReportWizard(IWizardCustomization-XtraReportModel-)) method.
5. Call the [XRDesignMdiController.AddService](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UserDesigner.XRDesignMdiController.AddService.overloads) method to register the created service.

## Files to Review

* [Form1.cs](./CS/CustomColorSchemes/Form1.cs) (VB: [Form1.vb](./VB/CustomColorSchemes/Form1.vb))
* [CustomColorSchemeStorage.cs](./CS/CustomColorSchemes/CustomColorSchemeStorage.cs) (VB: [CustomColorSchemeStorage.vb](./VB/CustomColorSchemes/CustomColorSchemeStorage.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-customize-color-schemes-in-wizard-page&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-customize-color-schemes-in-wizard-page&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
