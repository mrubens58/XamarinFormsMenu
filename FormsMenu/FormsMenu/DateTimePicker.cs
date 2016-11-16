using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class DateTimePicker : ContentPage
    {
        public DateTimePicker()
        {
            Label header = new Label
            {
                Text = "Date Picker and Time Picker",
                FontSize = 40,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                HorizontalOptions = LayoutOptions.Center
            };

            DatePicker datePicker = new DatePicker
            {
                Format = "D",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            TimePicker myTimePicker = new TimePicker
            {
                Format = "T",
                VerticalOptions = LayoutOptions.StartAndExpand
            };


            Content = new StackLayout
            {
                Children = {
                    header,
                    datePicker,
                    myTimePicker
                }
            };
        }
    }
}
