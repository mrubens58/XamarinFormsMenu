using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{

    public class NewContactPage : ContentPage
    {
        EntryCell firstName;
        EntryCell lastName;
        EntryCell contactType;
        
        public NewContactPage()
        {            

            Label header = new Label
            {
                Text = "Add a New Contact",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),

            };

             firstName = new EntryCell
            {
                Label = "First Name:",
                Placeholder = "Enter Last Name",

            };

            lastName = new EntryCell
            {
                Label = "Last Name:",
                Placeholder = "Enter Last Name",

            };

            contactType = new EntryCell
            {
                Label = "Contact Type:",
                Placeholder = "Enter Contact Type",

            };

            TableView tableView = new TableView
            {
                               
                Intent = TableIntent.Form,
                Root = new TableRoot
                {
                    new TableSection
                    {
                        
                        firstName,
                        lastName,
                        contactType

                    }
                }
            };

            Button saveButton = new Button
            {
                Text = "Save Contact",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                
            };
            saveButton.Clicked += SaveButton_Clicked;

            Button returnButton = new Button
            {
                Text = "Return",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                
            };

            returnButton.Clicked += ReturnButton_Clicked;

            StackLayout buttons = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.CenterAndExpand,


                Children =
                        {
                            saveButton,
                            returnButton
                        }
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Start,

                Children = {
                    header,
                    tableView,
                    buttons
                 }
            };
        }

        private void ReturnButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        
        private void SaveButton_Clicked(object sender, EventArgs e)
        {            
            ContactListApp.contacts.Add(new Contact(firstName.Text, lastName.Text, contactType.Text));

            var newList = ContactListApp.contacts.OrderBy(Item => Item.LastName);

            ContactListApp.listView.ItemsSource = newList;

            Navigation.PopAsync();
        }
    }
}
