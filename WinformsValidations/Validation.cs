using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinformsValidations
{
    public class Validation
    {
        public Validation()
        {
            VType = ValidationType.Required;
        }
        public Control control { get; set; }
        public string Message { get; set; }  
        public ValidationType VType { get; set; }
    }
}
