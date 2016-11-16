using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class DownloadImagePage : ContentPage
    {
        public DownloadImagePage()
        {
            Label header = new Label
            {
                Text = "Downloaded Image",
                FontSize = 40,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                HorizontalOptions = LayoutOptions.Center
            };

            var webImage = new Image { Aspect = Aspect.AspectFit };
            webImage.Source = ImageSource.FromUri(new Uri("https://xamarin.com/content/images/pages/forms/example-app.png"));


            Content = new StackLayout
            {
                Children = {

                    header,

                    new StackLayout
                    {
                        VerticalOptions = LayoutOptions.CenterAndExpand,

                        Children =
                        {
                            webImage
                        }

                    },



                }
            };
        }
    }
}
