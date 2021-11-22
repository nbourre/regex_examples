using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace regex.Validations
{
    public class PostalCodeValidationRule : ValidationRule
    {
        Regex pattern = new Regex(@"[A-z]\d[A-z][ -]?\d[A-z]\d",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var text = (string)value;
            if (pattern.Match(text).Success)
            {
                return new ValidationResult(true, null);
            }

            return new ValidationResult(false, null);
        }
    }
}
