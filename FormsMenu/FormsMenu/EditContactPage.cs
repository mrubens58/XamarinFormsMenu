using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class EditContactPage : ContentPage
    {
        EntryCell firstName;
        EntryCell lastName;
        EntryCell contactType;

        Contact contact = ContactListApp.listView.SelectedItem as Contact;

        public EditContactPage()
        {
            Label header = new Label
            {
                Text = "Edit Contact",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),

            };

            firstName = new EntryCell
            {
                Label = "First Name:",
                Text = contact.FirstName,

            };

            lastName = new EntryCell
            {
                Label = "Last Name:",
                Text = contact.LastName.ToString(),

            };

            contactType = new EntryCell
            {
                Label = "Contact Type:",
                Text = contact.ContactType.ToString(),

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

            Button deleteButton = new Button
            {
                Text = "Delete Contact",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.CenterAndExpand,

            };
            deleteButton.Clicked += DeleteButton_Clicked;

            Button cancelButton = new Button
            {
                Text = "Cancel",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.CenterAndExpand,

            };
            cancelButton.Clicked += CancelButton_Clicked;

            StackLayout buttons = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.CenterAndExpand,


                Children =
                        {
                            saveButton,
                            deleteButton,
                            cancelButton
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

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            ContactListApp.contacts.Remove(contact);

            ContactListApp.listView.ItemsSource = ContactListApp.contacts.OrderBy(Item => Item.LastName);

            Navigation.PopAsync();
        }

        private void CancelButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            contact.FirstName = firstName.Text;
            contact.LastName = lastName.Text;
            contact.ContactType = contactType.Text;

            ContactListApp.listView.ItemsSource = ContactListApp.contacts.OrderBy(Item => Item.LastName);

            Navigation.PopAsync();
        }
    }
}
