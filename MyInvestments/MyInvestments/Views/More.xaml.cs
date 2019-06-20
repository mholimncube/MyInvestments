using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyInvestments.Models;
using MyInvestments.ModelViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyInvestments.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class More : ContentPage
    {
        public More()
        {
            InitializeComponent();
            BindingContext = new PageListViewModel();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myselecteditem = e.Item as PageListModel;
            switch (myselecteditem.Id)
            {
                case 1:
                    await Navigation.PushAsync(new InvestmentsPage());
                    break;
                case 2:
                    await Navigation.PushAsync(new EducationPage());
                    break;
                case 3:
                    await Navigation.PushAsync(new SavingsPage());
                    break;
                case 4:
                    await Navigation.PushAsync(new NewsPage());
                    break;
                case 5:
                    await Navigation.PushAsync(new GoalsPage());
                    break;
                case 6:
                    await Navigation.PushAsync(new RewardsPage());
                    break;
                case 7:
                    await Navigation.PushAsync(new AboutPage());
                    break;
            }
        }
    }
}