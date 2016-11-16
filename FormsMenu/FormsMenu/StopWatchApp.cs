using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Diagnostics;

using Xamarin.Forms;

namespace FormsMenu
{
    public class StopWatchApp : ContentPage
    {
        TimeSpan time;
        Stopwatch stopwatch = new Stopwatch();
        Label timeLabel;
        
        public StopWatchApp()
        {
            Device.StartTimer(TimeSpan.FromMilliseconds(10), () =>

            {
            this.time = this.stopwatch.Elapsed;
            timeLabel.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                this.time.Hours, this.time.Minutes, this.time.Seconds, this.time.Milliseconds/10);

                return true;
            });


            Label header = new Label
            {
                Text = "StopWatch App",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.StartAndExpand,
            };

            Button startButton = new Button
            {
                Text = "Start",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BorderWidth = 1,
                BorderRadius = 22,
                BackgroundColor = Color.Accent,
                TextColor = Color.Black

            };
            startButton.Clicked += StartButton_Clicked;

            Button stopButton = new Button
            {
                Text = "Stop",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BorderWidth = 1,
                BorderRadius = 22,
                BackgroundColor = Color.Accent,
                TextColor = Color.Black

            };
            stopButton.Clicked += StopButton_Clicked;

            Button resetButton = new Button
            {
                Text = "Reset",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BorderWidth = 1,
                BorderRadius = 22,
                BackgroundColor = Color.Accent,
                TextColor = Color.Black

            };
            resetButton.Clicked += ResetButton_Clicked;

            timeLabel = new Label
            {
                Text = "00:00:00.00",
                FontSize = 55,
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Black
            };

            Frame frame = new Frame
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.StartAndExpand,
                Margin = new Thickness(0, 30),
                BackgroundColor = Color.FromRgb(200, 200, 200),

                Content = new StackLayout
                {
                    Children =
                    {
                        timeLabel,

                        new StackLayout
                        {
                            Orientation = StackOrientation.Horizontal,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.StartAndExpand,


                            Children =
                            {
                                startButton,
                                stopButton,
                                resetButton
                            }
                        }
                    }
                }
            };


            Content = new StackLayout
            {
                Children = {
                    header,
                    frame
                }
            };
        }

        private void ResetButton_Clicked(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }

        private void StopButton_Clicked(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void StartButton_Clicked(object sender, EventArgs e)
        {
            stopwatch.Start();
        }
    }
}
