using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace mycoachEpic2.Epic2ViewModels
{
    public class SignupPageModelView : ContentPage
    {
        public SignupPageModelView()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
        }
    }
}