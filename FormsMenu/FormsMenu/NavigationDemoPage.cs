using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class NavigationDemoPage : ContentPage
    {
        public NavigationDemoPage()
        {
            Command<Type> pageCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await Navigation.PushAsync(page);
                });

            Label header = new Label
            {
                Text = "Navigation Demo Page",
                FontSize = 40,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                HorizontalOptions = LayoutOptions.Center
            };

            StackLayout stackLayout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                
                Children = {

                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,

                        Children = {
                            new Button
                            {
                                Text = "LabelDemo Page",
                                BorderWidth = 1,
                                HorizontalOptions = LayoutOptions.Center,
                                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Button)),
                                Command = pageCommand,
                                CommandParameter = typeof(LabelDemoPage),
                            },


                            new Button
                            {
                                Text = "ScrollViewDemo Page",
                                BorderWidth = 1,
                                HorizontalOptions = LayoutOptions.Center,
                                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Button)),
                                Command = pageCommand,
                                CommandParameter = typeof(ScrollViewDemoPage),
                            },


                            new Button
                            {
                                Text = "StackLayoutDemo Page",
                                BorderWidth = 1,
                                HorizontalOptions = LayoutOptions.Center,
                                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Button)),
                                Command = pageCommand,
                                CommandParameter = typeof(StackLayoutDemoPage),
                            }
                        }
                    }
                }

             };
            

            Content = new StackLayout
            {
                Children = {
                    header,
                    stackLayout,
                }
            };
        }
    }
}
