using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinformsValidations
{
    public partial class Form2 : BaseForm
    {
        public Form2()
        {
            InitializeComponent();
            FormValidationlist.Add(new Validation() { control = txtEmail, Message = "Please enter  Email id" });
            FormValidationlist.Add(new Validation() { control = txtLPhone, Message = "Please enter Phone Number" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                MessageBox.Show("data Saved");
            }
        }
    }
}
