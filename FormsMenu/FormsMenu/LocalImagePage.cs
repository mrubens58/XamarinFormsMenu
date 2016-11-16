using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class LocalImagePage : ContentPage
    {
        public LocalImagePage()
        {
            Label header = new Label
            {
                Text = "Local Image",
                FontSize = 40,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                HorizontalOptions = LayoutOptions.Center
            };

            var localImage = new Image { Aspect = Aspect.AspectFit };
            localImage.Source = ImageSource.FromFile("Xamarinlogo.png");


            Content = new StackLayout
            {
                Children = {

                    header,

                    new StackLayout
                    {
                        VerticalOptions = LayoutOptions.CenterAndExpand,

                        Children =
                        {                            
                            localImage
                        }
                        
                    },
                    
                    
                   
                }
            };
        }
    }
}
