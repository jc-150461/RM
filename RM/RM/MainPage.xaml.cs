using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RM
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        private void Button_Clicked(object sender, EventArgs e)
        {
            Double w = Double.Parse(Weight.Text);
            Double l = Double.Parse(Leg.Text);
            Double RM = 0.0;

            if (l = 1)
            {
                RM = w / 1;
            }
            DisplayAlert("RM", RM.ToString(), "OK");
        }
	}
}
