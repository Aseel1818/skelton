﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace mycoachEpic2.Epic2ViewModels
{
    public class CalenderPageModelView : ContentPage
    {
        public CalenderPageModelView()
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