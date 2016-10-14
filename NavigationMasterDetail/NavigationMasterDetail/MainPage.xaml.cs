using NavigationMasterDetail.MenuItems;
using NavigationMasterDetail.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationMasterDetail {

    public partial class MainPage : MasterDetailPage {

        public List<MasterPageItem> menuList { get; set; }

        public MainPage() {

            InitializeComponent();

            menuList = new List<MasterPageItem>();

            // Creating our pages for menu navigation
            // Here you can define title for item, 
            // icon on the left side, and page that you want to open after selection
            var page1 = new MasterPageItem() { Title = "Item 1", Icon = "itemIcon1.png", TargetType = typeof(TestPage1) };
            var page2 = new MasterPageItem() { Title = "Item 2", Icon = "itemIcon2.png", TargetType = typeof(TestPage2) };
            var page3 = new MasterPageItem() { Title = "Item 3", Icon = "itemIcon3.png", TargetType = typeof(TestPage3) };
            var page4 = new MasterPageItem() { Title = "Item 4", Icon = "itemIcon4.png", TargetType = typeof(TestPage1) };
            var page5 = new MasterPageItem() { Title = "Item 5", Icon = "itemIcon5.png", TargetType = typeof(TestPage2) };
            var page6 = new MasterPageItem() { Title = "Item 6", Icon = "itemIcon6.png", TargetType = typeof(TestPage3) };
            var page7 = new MasterPageItem() { Title = "Item 7", Icon = "itemIcon7.png", TargetType = typeof(TestPage1) };
            var page8 = new MasterPageItem() { Title = "Item 8", Icon = "itemIcon8.png", TargetType = typeof(TestPage2) };
            var page9 = new MasterPageItem() { Title = "Item 9", Icon = "itemIcon9.png", TargetType = typeof(TestPage3) };

            // Adding menu items to menuList
            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);
            menuList.Add(page5);
            menuList.Add(page6);
            menuList.Add(page7);
            menuList.Add(page8);
            menuList.Add(page9);

            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;

            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(TestPage1)));
        }

        // Event for Menu Item selection, here we are going to handle navigation based
        // on user selection in menu ListView
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e) {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
