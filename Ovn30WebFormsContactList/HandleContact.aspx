<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="HandleContact.aspx.cs" Inherits="Ovn30WebFormsContactList.HandleContact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="form-group central-content">
        <table id="detailed-info">
            <tr>
                <td>First Name:</td>
                <td>
                    <asp:TextBox CssClass="form-control" ID="TxtBoxFirstName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator CssClass="validatorText" ID="RFVFirstName" runat="server" ErrorMessage="First name is required" ControlToValidate="TxtBoxFirstName" EnableClientScript="False"></asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td>Last Name:</td>
                <td>
                    <asp:TextBox CssClass="form-control" ID="TxtBoxLastName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator CssClass="validatorText" ID="RFVLastName" runat="server" ErrorMessage="Last name is required" ControlToValidate="TxtBoxLastName" EnableClientScript="False"></asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td>SSN:</td>
                <td>
                    <asp:TextBox  CssClass="form-control" ID="TxtBoxSSN" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator CssClass="validatorText" ID="RFVSSN" runat="server" ErrorMessage="SSN is required" ControlToValidate="TxtBoxSSN" EnableClientScript="False"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>

        <asp:Button  CssClass="btn btn-default" ID="BtnAction" runat="server" Text="Button" OnClick="BtnAction_Click" />
    </div>
</asp:Content>
