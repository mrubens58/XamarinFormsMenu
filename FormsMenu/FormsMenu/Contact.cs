using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class Contact
    {


        public Contact(string firstName, string lastName, string contactType)
        {

            this.FirstName = firstName;
            this.LastName = lastName;
            this.ContactType = contactType;
            
        }

        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string ContactType { set; get; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
            
        
    }
}
