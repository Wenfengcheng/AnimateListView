using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ExampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
            list.ItemsSource = new List<string>()
            {
                "Xamarin", "Visual Studio", "Visual Studio For Mac", "Azure"
            };
        }


        public ICommand PullRefreshCommand => new Command(()=>{


        });

        public ICommand LoadMoreCommand => new Command(() => {


        });
    }
}
