using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsValidations
{
    public partial class BaseForm : Form
    {
        protected  List<Validation> FormValidationlist;
        public BaseForm()
        {
            InitializeComponent();
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
            List<Control> _invalidcontrols = new List<Control>();

            foreach (Validation vald in FormValidationlist.Where(p => p.VType == ValidationType.Required).ToList())
            {
                if (vald.control is TextBox)
                {
                    if (string.IsNullOrEmpty(vald.control.Text.Trim()))
                    {
                        sb.Append(vald.Message);
                        sb.Append("\r\n");
                        _isvalid = false;
                        _invalidcontrols.Add(vald.control);
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
                        _invalidcontrols.Add(vald.control);
                        continue;
                    }
                }
            }            
            if (!_isvalid)
            {
                MessageBox.Show(sb.ToString(), "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _invalidcontrols.FirstOrDefault().Focus();
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

