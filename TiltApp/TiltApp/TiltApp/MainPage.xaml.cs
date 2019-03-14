using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TiltApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((TiltAppViewModel)BindingContext).StartCommand.Execute(null);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ((TiltAppViewModel)BindingContext).StopCommand.Execute(null);
        }

    }
}
