using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class BoxViewDemoPage : ContentPage
    {
        public BoxViewDemoPage()
        {

            Label header = new Label
            {
                Text = "BoxView Demo Page",
                FontSize = 40,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                HorizontalOptions = LayoutOptions.Center
            };

            BoxView boxView = new BoxView
            {
                Color = Color.Accent,
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            
            Content = new StackLayout
            {
                Padding = new Thickness(20, 0),
                Children = {
                    header,
                    boxView                    
                }
            };
        }
    }
}
