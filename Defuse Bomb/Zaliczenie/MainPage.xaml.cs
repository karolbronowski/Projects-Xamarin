using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Zaliczenie
{
    public partial class MainPage : ContentPage
    {
        static string bomb = new Random().Next(1, 4).ToString();
        static int scores = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        async void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Text == bomb)
            {
                await DisplayAlert("💥 Bomba wybuchła! 💥", "Koniec gry", "Spróbuj ponownie");
                bomb = new Random().Next(1, 4).ToString();
                scores = 0;
            }
            else
            {
                scores += 1;
                await DisplayAlert("💣 Masz szczęście! 💣", "Wynik: " + scores, "Graj dalej!");
                bomb = new Random().Next(1, 4).ToString();
            }
        }
    }
}
