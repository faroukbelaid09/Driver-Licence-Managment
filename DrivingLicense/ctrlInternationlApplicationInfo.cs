using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class ctrlInternationlApplicationInfo : UserControl
    {
        public ctrlInternationlApplicationInfo()
        {
            InitializeComponent();
        }

        private void LoadDate()
        {
            InternationalAppIDValue.Text = "";
            AppDateValue.Text = "";
            IssueDateValue.Text = "";
            FeesValue.Text = "";
            InternationalLicenseIDValue.Text = "";
            LocalLicenseIDValue.Text = "";
            ExpDateValue.Text = "";
            CreatedByValue.Text = "";
        }
    }
}
