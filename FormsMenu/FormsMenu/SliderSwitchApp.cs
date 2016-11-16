using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class SliderSwitchApp : ContentPage
    {

        Frame frame;
        Slider slider;
        Label sliderLabel;
        Label frameLabel = new Label
                {
                    Text = "This is my Frame Demo!",
                    TextColor = Color.Black,                    
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                };
        

    public SliderSwitchApp()
        {
            BackgroundColor = Color.Blue;

            Label header = new Label
            {
                Text = "Slider and Switch Demo Page",
                TextColor = Color.White,
                FontSize = 40,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                HorizontalOptions = LayoutOptions.Center
            };

            frame = new Frame
            {

                Content = frameLabel,

                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 200,
                HeightRequest = 200,
                
            };

            Button button = new Button
            {
                Text = "CLICK ME!",
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };
            button.Clicked += ButtonClicked;

            Label switchLabel = new Label
            {
                Text = "Switch Colors",
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };

            Switch mySwitch = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                Margin = new Thickness (0, 10, 0, 0)
            };
            mySwitch.Toggled += switcher_Toggled;

            

            slider = new Slider
            {
                Maximum = 300,
                Minimum = 10,                
                Value = 200,
                Margin = new Thickness (20),
                VerticalOptions = LayoutOptions.End
            };
            slider.ValueChanged += HandleValueChanged;

            sliderLabel = new Label
            {
                TextColor = Color.White,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End
            };


            Content = new StackLayout
            {
                    Children = {
                    header,
                    frame,
                    button,
                    switchLabel,
                    mySwitch,
                    sliderLabel,
                    slider
                }
            };

        }

        private void HandleValueChanged(object sender, ValueChangedEventArgs e)
        {
            frame.WidthRequest = slider.Value;
            frame.HeightRequest = slider.Value;
            sliderLabel.Text = "Frame Dimension: " + slider.Value.ToString();

        }

        private void switcher_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value == true)
            {
                frame.BackgroundColor = Color.Gray;
                frameLabel.TextColor = Color.White;

            }
            else
            {
                frame.BackgroundColor = Color.White;
                frameLabel.TextColor = Color.Black;
            }
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            if (BackgroundColor == Color.Blue)
            {
                BackgroundColor = Color.Green;
            }
            else
            {
                BackgroundColor = Color.Blue;
            }
        }        
    }
}
