using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinDeneme2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwitchAndSlide : ContentPage
    {
        public SwitchAndSlide()
        {
            InitializeComponent();
        }

        private void drkmod_Toggled(object sender, ToggledEventArgs e)
        {
            
                if (Sayfa.BackgroundColor == Color.Black)
            {
                Sayfa.BackgroundColor = Color.White;
                drklbl.Text = "Light Mode";
                drklbl.TextColor = Color.Black;

            }
                else { 
                Sayfa.BackgroundColor = Color.Black;
                drklbl.Text = "Dark Mode";
                drklbl.TextColor = Color.White;
                 } 
        }
    }
}