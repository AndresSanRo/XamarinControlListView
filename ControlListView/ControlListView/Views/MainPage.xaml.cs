using ControlListView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlListView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public List<PageMenu> Menu { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Menu = new List<PageMenu>();
            PageMenu home = new PageMenu()
            {
                Title = "Home",
                Page = typeof(ChildPage)
            };
            PageMenu multTable = new PageMenu()
            {
                Title = "multTable",
                Page = typeof(MultTable)
            };
            PageMenu numberConverter = new PageMenu()
            {
                Title = "numberConverter",
                Page = typeof(NumberConverter)
            };
            Menu.Add(home);
            Menu.Add(multTable);
            Menu.Add(numberConverter);
            this.lsvMenu.ItemsSource = Menu;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ChildPage)));
            this.lsvMenu.ItemSelected += LsvMenu_ItemSelected;
        }

        private void LsvMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            PageMenu page = e.SelectedItem as PageMenu;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page.Page));
            IsPresented = false;
        }
    }
}