using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Xamarin.Forms;

namespace StuHubPartnerShip
{
    public partial class FB : ContentPage
    {
        ObservableCollection<string> list = new ObservableCollection<string>();
        public FB()
        {
            InitializeComponent();
            list.Add("#C79AD7");
            list.Add("#CCEF5C");
            list.Add("#FFFFFF");
            list.Add("000000");
            LV.ItemsSource = list;
        }

        async void ListView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            bool answer = await DisplayAlert("Question?", "Anh Quân Cute " + e.SelectedItem.ToString(), "Yes", "No");
            Debug.WriteLine("Answer: " + answer);
            if (answer == true)
            {
                LV.BackgroundColor = Color.FromHex(e.SelectedItem.ToString());
            }
        }

        void LV_Scrolled(System.Object sender, Xamarin.Forms.ScrolledEventArgs e)
        {
            Debug.WriteLine(e.ScrollY);
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1", "What color do you wanna add?");
            list.Add(result);
        }
    }
}
