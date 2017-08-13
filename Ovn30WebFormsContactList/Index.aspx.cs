using SQLLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ovn30WebFormsContactList
{
    public partial class Index : System.Web.UI.Page
    {

        List<Contact> contacts = new List<Contact>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UpdateList();
            }
        }

        private void UpdateList()
        {

            contacts = SQLUtils.GetAllContacts();
            string literalContacts = "";

            foreach (var contact in contacts)
            {

                literalContacts += "<tr>";
                literalContacts += $"<td>{contact.FirstName}</td>";
                literalContacts += $"<td>{contact.LastName}</td>";
                literalContacts += $"<td>{contact.SSN}</td>";
                literalContacts += $"<td>";
                literalContacts += $"  <a href='HandleContact.aspx?action=update&id={contact.ContactID}'>Update</a> - ";
                literalContacts += $"  <a href='HandleContact.aspx?action=delete&id={contact.ContactID}'>Delete</a>";
                literalContacts += $"</td>";
                literalContacts += "</tr>";
            }

            ContactLiteral.Text = literalContacts;
        }

    }
}