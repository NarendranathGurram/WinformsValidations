using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsValidations
{
    public class BaseForm : Form
    {
        protected List<Validation> FormValidationlist;

        public BaseForm()
        {
            FormValidationlist = new List<Validation>();
        }
        /// <summary>
        /// validate the form and Show alert
        /// </summary>
        /// <returns></returns>
        protected bool ValidateForm()
        {
            StringBuilder sb = new StringBuilder();
            bool _isvalid = true;

            foreach (Validation vald in FormValidationlist.Where(p => p.VType == ValidationType.Required).ToList())
            {
                if (vald.control is TextBox)
                {
                    if (string.IsNullOrEmpty(vald.control.Text.Trim()))
                    {
                        sb.Append(vald.Message);
                        sb.Append("\r\n");
                        _isvalid = false;
                        continue;
                    }
                }
                if (vald.control is ComboBox)
                {
                    ComboBox objcmb = (ComboBox)vald.control;
                    if (Convert.ToInt32(objcmb.SelectedValue) == 0)
                    {
                        sb.Append(vald.Message);
                        _isvalid = false;
                        sb.Append("\r\n");
                        continue;
                    }
                }
            }
            MessageBox.Show(sb.ToString(), "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!_isvalid)
            {
                FormValidationlist.FirstOrDefault().control.Focus();
            }
            return _isvalid;
        }
    }

    /// <summary>
    /// Validation Enum Type
    /// </summary>

    public enum ValidationType
    {
        Required = 532,
        Custom = 533
    }


}
