using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class ContactListApp : ContentPage
    {
        public static ListView listView;
        public static List<Contact> contacts;
        
        public ContactListApp()
        {
            Command<Type> pageCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await Navigation.PushAsync(page);
                });

            Label header = new Label
            {
                Text = "Contact List",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                HorizontalOptions = LayoutOptions.StartAndExpand

            };

            Button addButton = new Button
            {
                Text = "Add Contact",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.EndAndExpand,                

            };
            addButton.Clicked += AddButton_Clicked;

            contacts = new List<Contact>
            {
                new Contact("Michael", "Rubenstein", "Student"),
                new Contact("Tim", "Chenoweth", "Faculty"),
                new Contact("Aaron", "Ardvark", "Student"),
                new Contact("John", "Wee", "Faculty"),
                            
            };

            

            listView = new ListView
            {
                ItemsSource = contacts,                

                ItemTemplate = new DataTemplate(() =>
                {
                    
                    TextCell cell = new TextCell()
                    {
                        Command = pageCommand,
                        CommandParameter = typeof(EditContactPage),
                    };
                    cell.SetBinding(TextCell.TextProperty, "FullName");
                    cell.SetBinding(TextCell.DetailProperty, "ContactType");
                    return cell;
                    
                })
                
            };

            var newList = contacts.OrderBy(Item => Item.LastName);

            listView.ItemsSource = newList;

            Content = new StackLayout
            {
                Children = {

                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        
                        Children =
                        {
                            header,
                            addButton
                        }
                    },
                    
                    new StackLayout
                                        
                    {
                        Children =
                        {
                            listView,
                            
                        }
                    },
                }
            };
        }

        private void AddButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewContactPage());
        }        
    }
}
