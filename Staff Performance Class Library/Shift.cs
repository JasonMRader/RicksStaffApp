using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Performance_Class_Library
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
        public void AddEmployeeShift(EmployeeShift employeeShift)
        {
            // Set the Shift property of the EmployeeShift to this Shift
            employeeShift.Shift = this;

            // Add the EmployeeShift to the Shift's EmployeeShifts list
            EmployeeShifts.Add(employeeShift);
        }
        public float AverageRating
        {
            get
            {
                if (EmployeeShifts.Count == 0) return 0;
                else
                {
                    float totalRating = 0;
                    foreach (EmployeeShift employeeShift in EmployeeShifts)
                    {
                        employeeShift.UpdateShiftRating();
                        {
                            totalRating += employeeShift.ShiftRating;
                        }
                    }
                    var avgRating = totalRating / EmployeeShifts.Count;
                    return avgRating;
                }

            }
        }
        //public DateTime DateTime
        //{
        //    get { return Date.FromDateTime(this.Date); }
        //    set { Date = DateOnly.FromDateTime(value); }
        //}
        public string DateString
        {
            get { return Date.ToString("MM/dd/yyyy"); }
            set
            {
                var dateTime = DateTime.Parse(value);

                Date = DateOnly.FromDateTime(dateTime);
            }
            //set { Date = DateOnly.Parse(value, IFormatProvider? provider); }
        }
        public DateTime DateAsDateTime
        {
            get { return new DateTime(Date.Year, Date.Month, Date.Day, 0, 0, 0); }
            set
            {
                Date = DateOnly.FromDateTime(value);
            }

        }
    }
}
