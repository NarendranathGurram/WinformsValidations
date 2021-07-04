using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsValidations
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {

                
            }
        }

        private void Vform_Load(object sender, EventArgs e)
        {
            BindCombobox();
            FormValidationlist.Add(new Validation() { control = txtFName, Message = "First name Required" });
            FormValidationlist.Add(new Validation() { control = txtLName, Message = "Last name Required" });
            FormValidationlist.Add(new Validation() { control = cmbGender, Message = "Please select Gender" });

        }
        private void BindCombobox()
        {
            Dictionary<int, string> dGender = new Dictionary<int, string>();
            dGender.Add(0, "Select");
            dGender.Add(1, "Female");
            dGender.Add(2, "Male");
            cmbGender.DataSource = new BindingSource(dGender, null);
            cmbGender.DisplayMember = "Value";
            cmbGender.ValueMember = "Key";
        }
    }
}
