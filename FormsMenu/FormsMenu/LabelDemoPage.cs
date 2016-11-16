using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class LabelDemoPage : ContentPage
    {
        public LabelDemoPage()
        {

            Label header = new Label
            {
                Text = "Label Demo Page",
                FontSize = 40,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                HorizontalOptions = LayoutOptions.Center
            };


            Label label = new Label
            {
                Text = "Xamarin.Forms ia a cross-platform natively" + 
                "backed UI toolkit abstraction that allows" + 
                "developers to easily create use interfaces" + 
                "that can be shared across Android, iOS, and" +
                "Windows Phone.",

                FontSize=Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                VerticalOptions=LayoutOptions.CenterAndExpand,

            };

            Content = new StackLayout
            {
                Padding = new Thickness(20, 0),
                Children = {
                   header,
                   label                    
                }
            };
        }
    }
}
