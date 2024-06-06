using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Model_Validation.Models
{
    public class evencreditlimit1:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            decimal cl=Convert.ToDecimal(value);
            if (cl % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}