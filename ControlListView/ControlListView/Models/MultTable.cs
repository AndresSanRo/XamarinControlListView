using ControlListView.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlListView.Models
{
    public class MultTable
    {
        public int Number { get; set; }
        public List<MultTableModel> Table {
            get {
                return GenerateTable();
            }            
        }
        public List<MultTableModel> GenerateTable()
        {
            List<MultTableModel> numbers = new List<MultTableModel>();
            for (int i = 1; i <= 10 ; i++)
            {
                MultTableModel mtm = new MultTableModel();
                mtm.Value = this.Number * i;
                numbers.Add(mtm);
            }
            return numbers;
        }
        public MultTable()
        {
            Number = 5;
        }
    }
}
