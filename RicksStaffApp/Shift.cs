using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksStaffApp
{
    public class Shift
    {
        public Shift() { }
        public int ID { get; set; }
        public DateOnly Date { get; set; }
        private bool isAm;
        public bool IsAm
        {
            get { return isAm; }
            set
            {
                isAm = value;
                isPm = !value;
            }
        }

        private bool isPm;
        public bool IsPm
        {
            get { return isPm; }
            set
            {
                isPm = value;
                isAm = !value;
            }
        }
        public List<EmployeeShift> EmployeeShifts { get; set; }
        //public DateTime DateTime
        //{
        //    get { return Date.FromDateTime(this.Date); }
        //    set { Date = DateOnly.FromDateTime(value); }
        //}
        public string DateString
        {
            get { return Date.ToString("MM/dd/yyyy");}
            set
            {
                var dateTime = DateTime.Parse(value);

                Date = DateOnly.FromDateTime(dateTime);
            }
            //set { Date = DateOnly.Parse(value, IFormatProvider? provider); }
        }
    }
}
