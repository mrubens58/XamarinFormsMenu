using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class ContentDemoPage : ContentPage
    {
        public ContentDemoPage()
        {
            Label header = new Label
            {
                Text = "Content Demo Page",
                FontSize = 40,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                HorizontalOptions = LayoutOptions.Center
            };

            StackLayout stackLayout = new StackLayout
            {
                Children =
                {

                    new Label
                    {
                        Text = "ContentPage is the simplest type of page.",
                        FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
                    },

                    new Label
                    {
                        Text = "The content of a ContentPage is generally a layout of some sort that can then be a parent to multiple children.",
                        FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label))
                    },

                    new Label
                    {
                        Text = "This ContentPage contains a StackLayout, which in turn contains four Label views (including the large one at the top)",
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
                    }
                }


            };
                        
            Content = new StackLayout
            {
                Children = {
                    header,
                    stackLayout
                }
            };
        }
    }
}
