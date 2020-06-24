using ListView.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class listViewContent : ContentPage
    {
        public listViewContent()
        {
            InitializeComponent();

            var list = new List<Personal>
            {
              new Personal {name="Hakan" , Salary=4500 , ImageUrl="https://i.hizliresim.com/3H0j2x.png" },

            new Personal { name = "Murat", Salary = 3950, ImageUrl = "https://i.hizliresim.com/9jaYZt.jpg" },

            new Personal { name = "Canan", Salary = 4350, ImageUrl = "https://i.hizliresim.com/nSdyND.jpg" },






            };


            lstname.ItemsSource = list;
        }
    }
}