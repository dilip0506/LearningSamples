using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    public class RoundingAttribute : Attribute {
        private int _decimallength;
        public RoundingAttribute(int DecimalLength) {
            this._decimallength = DecimalLength;
            var pInfo = typeof(Messages).GetProperties();
            var v = pInfo[1].GetType().Name;
        }
        private decimal _owner;
        public decimal Owner
        {
            get
            {
                return _owner;
            }
            set
            {
                _owner = decimal.Round(value, this._decimallength, MidpointRounding.AwayFromZero);
            }
        }
    }

    public class Messages
    {
 
        public string Id { get; set; }
        [Rounding(2)]
        public decimal Owner { get; set; }
        public string Text { get; set; }
    }
}
