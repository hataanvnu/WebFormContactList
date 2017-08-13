using SQLLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ovn30WebFormsContactList
{
    public partial class EditContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InitName();

            UpdateList();
        }

        private void UpdateList()
        {
            Contact c = GetContact();

            List<Address> addresses = c.Addresses;

            foreach (var item in addresses)
            {
                LstBoxAddresses.Items.Add(item.ToString());
            }
        }

        private void InitName()
        {
            Contact c = GetContact();

            LabelFullName.Text = c.FirstName + " " + c.LastName;
        }

        private Contact GetContact()
        {
            string s = ClientQueryString.Split('=').Last();

            int id = Convert.ToInt32(s);

            Contact c = SQLUtils.GetContactByID(id);
            return c;
        }
    }
}