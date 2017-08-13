using SQLLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ovn30WebFormsContactList
{
    public partial class HandleContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["action"] != null)
                {
                    if (Request["id"] != null)
                    {

                        if (Request["action"] == "delete")
                        {
                            DisableTextBoxes();
                            SetValidation(false);


                            InitTextBoxes(GetID());

                            BtnAction.Text = "Delete";
                        }
                        else if (Request["action"] == "update")
                        {
                            EnableTextBoxes();
                            SetValidation(true);

                            InitTextBoxes(GetID());

                            BtnAction.Text = "Update";

                        }
                    }
                    else
                    {
                        if (Request["action"] == "create")
                        {
                            EnableTextBoxes();
                            SetValidation(true);


                            BtnAction.Text = "Add Contact";
                        }
                    }
                }
            }
        }

        protected void BtnAction_Click(object sender, EventArgs e)
        {
            if (Request["action"] != null)
            {
                if (Request["id"] != null)
                {
                    if (Request["action"] == "delete")
                    {
                        SQLUtils.RemoveContact(GetID());

                        Server.Transfer("Index.aspx");
                    }
                    else if (Request["action"] == "update")
                    {
                        List<Contact> contacts = SQLUtils.GetAllContacts();
                        int id = GetID();

                        SQLUtils.spUpdateContact(
                            id,
                            TxtBoxFirstName.Text,
                            TxtBoxLastName.Text,
                            TxtBoxSSN.Text);

                        Server.Transfer("Index.aspx");

                    }
                }
                else if (Request["action"] == "create" && IsValid)
                {
                    SQLUtils.spAddContact(
                        TxtBoxFirstName.Text,
                        TxtBoxLastName.Text,
                        TxtBoxSSN.Text);

                    Server.Transfer("Index.aspx");
                }
            }
        }

        private void SetValidation(bool on)
        {
            RFVFirstName.Enabled = on;
            RFVLastName.Enabled = on;
            RFVSSN.Enabled = on;
        }

        private void InitTextBoxes(int id)
        {
            Contact contact = SQLUtils.GetContactByID(id);
            TxtBoxFirstName.Text = contact.FirstName;
            TxtBoxLastName.Text = contact.LastName;
            TxtBoxSSN.Text = contact.SSN;

        }

        private int GetID()
        {
            int id = Convert.ToInt32(Request["id"]);
            return id;
        }

        private void EnableTextBoxes()
        {
            TxtBoxFirstName.Enabled = true;
            TxtBoxLastName.Enabled = true;
            TxtBoxSSN.Enabled = true;
        }

        private void DisableTextBoxes()
        {
            TxtBoxFirstName.Enabled = false;
            TxtBoxLastName.Enabled = false;
            TxtBoxSSN.Enabled = false;
        }

    }
}