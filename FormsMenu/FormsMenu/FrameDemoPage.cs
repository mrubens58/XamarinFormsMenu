using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class FrameDemoPage : ContentPage
    {
        public FrameDemoPage()
        {

            Label header = new Label
            {
                Text = "Frame Demo Page",
                FontSize = 40,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                HorizontalOptions = LayoutOptions.Center
            };

            Frame frame = new Frame
            {
                Content = new Label
                {
                    Text = "This is my Frame Demo!",
                    TextColor = Color.White,
                    BackgroundColor = Color.Teal,
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                },

                BackgroundColor = Color.Yellow,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand

            };




            Content = new StackLayout
            {
                Children = {
                    header,
                    frame
                }
            };
        }
    }
}
