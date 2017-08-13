<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Ovn30WebFormsContactList.Index" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group">


        <a href='HandleContact.aspx?action=create' id="createNewContactLink">Create New Contact</a>

        <table class="table table-striped">
            <thead>
                <tr>
                    <td>First Name</td>
                    <td>Last Name</td>
                    <td>SSN</td>
                    <td>&nbsp;</td>
                </tr>
            </thead>
            <tbody>
                <asp:Literal ID="ContactLiteral" runat="server"></asp:Literal>
            </tbody>
        </table>

    </div>
</asp:Content>
