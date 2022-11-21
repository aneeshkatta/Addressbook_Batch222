using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Addressbook_Batch222
{
    internal class AddressBook
    {
        public static void Main(string[] args)
        {
            Address address = new Address();
            address.Entry();
            address.DeleteContact();

        }



    }
}




