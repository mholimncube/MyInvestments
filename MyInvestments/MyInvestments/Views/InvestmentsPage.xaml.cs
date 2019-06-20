using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyInvestments.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InvestmentsPage : ContentPage
    {
        public InvestmentsPage()
        {
            InitializeComponent();
           
        }

   
        private void Button_Clicked_Invest(object sender, EventArgs e)
        {
            DisplayAlert("Success", "You have Invested","OK!");
        }

        private void Button_Clicked_More(object sender, EventArgs e)
        {
            DisplayAlert("Loading...", "", "OK");
        }
    }
}