using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksStaffApp
{
    public class Position
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
        private string excelRange;
        public string ExcelRange
        {
            get
            {
                return excelRange;
            }
            set
            {
                excelRange = value;
                var cells = value.Split(':');
                if (cells.Length == 2)
                {
                    ExcelStartCell = cells[0];
                    ExcelEndCell = cells[1];
                }
            }
        }

        public string ExcelStartCell { get; private set; }
        public string ExcelEndCell { get; private set; }

        

        public string GetExcelRange()
        {
            return $"{ExcelStartCell}:{ExcelEndCell}";
        }

        public void SetExcelRange(string startCell, string endCell)
        {
            ExcelStartCell = startCell;
            ExcelEndCell = endCell;
            excelRange = GetExcelRange();
        }

    }
}
