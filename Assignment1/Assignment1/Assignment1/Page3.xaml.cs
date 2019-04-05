using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Assignment1
{
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            editor.Text = "";
            Button button = (Button)sender;
            await DisplayAlert("Thank you", "Your Feedback has been sent", "OK");
        }
    }
}
