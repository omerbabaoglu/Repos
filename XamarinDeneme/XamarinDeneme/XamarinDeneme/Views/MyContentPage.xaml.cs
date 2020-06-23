using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinDeneme.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyContentPage : ContentPage
    {
        
        public MyContentPage()
        {
            
           
            InitializeComponent();
        }

        private void SenderButton_Pressed(object sender, EventArgs e)
        {
            string CatchName = NameEntry.Text;
            HiLabel.Text = "Merhaba " +CatchName;
        }

        private void NameEntry_Focused(object sender, FocusEventArgs e)
        {
            NameEntry.Text = "";
            HiLabel.Text = "";
        }
    }
}