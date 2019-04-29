using ControlListView.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlListView.Models
{
    public class NumberList
    {
        public List<NumberModel> Numbers
        {
            get { return this.GenerateNumberModel(); }
        }
        private List<NumberModel> GenerateNumberModel()
        {
            Random r = new Random();
            List<NumberModel> data = new List<NumberModel>();
            for (int i = 1; i <= 20; i++)
            {
                NumberModel model = new NumberModel();
                model.Value = r.Next(-20, 20);
                data.Add(model);
            }
            return data;
        }
        private List<int> GenerateNumbers()
        {
            Random r = new Random();
            List<int> data = new List<int>();
            for (int i = 1; i <= 20; i++)
            {
                int n = r.Next(-20, 20);
                data.Add(n);
            }
            return data;
        }
    }
}
