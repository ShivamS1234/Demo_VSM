using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoVSM
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
		string _currentColorState = "Normal";
		public MainPage()
        {
            InitializeComponent();
        }
		void ToggleValid_OnClicked(object sender, EventArgs e)
		{
			if (_currentColorState == "Normal")
			{
				_currentColorState = "Invalid";
			}
			else
			{
				_currentColorState = "Normal";
			}

			VisualStateManager.GoToState(btnOk, _currentColorState);
			VisualStateManager.GoToState(boxview1, _currentColorState);
			VisualStateManager.GoToState(boxview2, _currentColorState);
			VisualStateManager.GoToState(boxview3, _currentColorState);
		}
	}
}
