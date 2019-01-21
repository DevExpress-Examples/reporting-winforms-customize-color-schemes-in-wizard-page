using DevExpress.XtraReports.Wizards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomColorSchemes
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();

            //Register the wizard customization service.
            reportDesigner1.AddService(typeof(IWizardCustomizationService), new WizardCustomizationService());
        }
    }
}
