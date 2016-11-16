using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class WebpagePage : ContentPage
    {
        public WebpagePage()
        {
            Label header = new Label
            {
                Text = "Webpage View",
                FontSize = 40,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                HorizontalOptions = LayoutOptions.Center
            };

            WebView webView = new WebView
            {
                Source="http://google.com",
                VerticalOptions = LayoutOptions.FillAndExpand
            };


            Content = new StackLayout
            {
                Children = {

                    header,
                    webView               
                    
                }
            };
        }
    }
}
