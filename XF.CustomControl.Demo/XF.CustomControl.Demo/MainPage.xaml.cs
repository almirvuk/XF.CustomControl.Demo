using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.CustomControl.Demo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            Content = new StackLayout {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                new Label {
                    HorizontalTextAlignment = TextAlignment.Center,
                    Text = "Test"
                }
            }
            };
        }
	}
}
