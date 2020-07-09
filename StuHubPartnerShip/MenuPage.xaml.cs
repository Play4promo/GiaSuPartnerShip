using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using StuHubPartnerShip.Models;
using Xamarin.Forms;

namespace StuHubPartnerShip
{
    public partial class MenuPage : ContentPage
    {
        ObservableCollection<Food> foodLists = new ObservableCollection<Food>();
        public MenuPage()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#fe8c00");
            Food hamuburger = new Food();
            hamuburger.FoodName = "Hamburger";
            hamuburger.FoodPrice = 54;
            Food pizza = new Food();
            pizza.FoodName = "Pizza";
            pizza.FoodPrice = 99;
            foodLists.Add(hamuburger);
            foodLists.Add(pizza);
            MenuList.ItemsSource = foodLists;
        }
    }
}
