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
            Double RM1 = 0.0;
            Double RM2 = 0.0;
            Double RM3 = 0.0;
            Double RM4 = 0.0;
            Double RM5 = 0.0;
            Double RM6 = 0.0;
            Double RM7 = 0.0;
            Double RM8 = 0.0;
            Double RM9 = 0.0;
            Double RM10 = 0.0;
            
                RM1 = w / 1.0;
                RM2 = w / 0.95;
                RM3 = w / 0.93;
                RM4 = w / 0.90;
                RM5 = w / 0.87;
                RM6 = w / 0.85;
                RM7 = w / 0.87;
                RM8 = w / 0.80;
                RM9 = w / 0.77;
                RM10 = w / 0.75;

            LabelText.Text = RM1;

            
        }

	}
}
