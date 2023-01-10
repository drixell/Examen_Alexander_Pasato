using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen_Alexander_Pasato
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnGo_Clicked(object sender, EventArgs e)
        {


           Navigation.PushAsync(new Login());

        }
    }
}
