using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook_Batch222
{
    public class Contact
    {
        public String first_Name;
        public String last_Name;
        public String present_Address;
        public String city;
        public String state;
        public String zip;
        public String phone_Number;
        public String email_Id;
        public Contact(String first_Name, String last_Name, String present_Address, String city, String state, String zip, String phone_Number, String email_Id)
        {
            this.first_Name = first_Name;
            this.last_Name = last_Name;
            this.present_Address = present_Address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phone_Number = phone_Number;
            this.email_Id = email_Id;
        }
        public override string ToString()
        {
            return "first Name=" + first_Name + ",last name=" + last_Name + ",present_Address=" + present_Address + ",city=" + city + ",state=" + state + ",zip" + zip + ",phone number=" + phone_Number + "email_Id=" + email_Id;
        }
    }
}
