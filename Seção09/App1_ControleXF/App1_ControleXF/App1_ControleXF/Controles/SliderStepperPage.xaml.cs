﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SliderStepperPage : ContentPage
	{
		public SliderStepperPage ()
		{
			InitializeComponent ();
		}

        private void ActionValorMudou(Object sender, ValueChangedEventArgs args) {
            SlideResult.Text = args.NewValue.ToString();
        }

        private void ActionValorMudouStepper(Object sender, ValueChangedEventArgs args) {
            StepperResult.Text = args.NewValue.ToString();
        }

    }
}