<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Auth/Auth.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ELacak.Web.Views.Auth.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/auth.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 200px;
        }

        .auto-style2 {
            width: 200px;
            text-align: right;
        }

        .warning {
            color: red;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="wrapper">
        <div id="rfd-demo-zone" class="login-containers">
            <div class="validationSummary">
                <div class="login-container size-custom">
                    <asp:Panel runat="server" ID="LoginPanel">
                        <p><strong>Please Login:</strong></p>
                        <asp:Login ID="LoginForm" runat="server" Width="100%" EnableViewState="false">
                            <LayoutTemplate>
                                <table cellpadding="1" cellspacing="0" width="100%">
                                    <tr>
                                        <td>
                                            <table cellpadding="0" width="100%">
                                                <tr>
                                                    <td class="auto-style2">
                                                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:&nbsp;&nbsp;&nbsp;&nbsp;</asp:Label>

                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="UserName" runat="server" Width="200px"></asp:TextBox>
                                                    </td>
                                                    <td class="auto-style1 warning">
                                                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                                            ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style2">
                                                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:&nbsp;&nbsp;&nbsp;&nbsp;</asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="Password" runat="server" TextMode="Password" Width="200px"></asp:TextBox>

                                                    </td>
                                                    <td class="auto-style1 warning">
                                                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                                                            ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style1">&nbsp;
                                                    </td>
                                                    <td>
                                                        <asp:CheckBox ID="RememberMe" runat="server" Text="Remember me next time."></asp:CheckBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center" colspan="2" style="color: Red;">
                                                        <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="2" style="text-align: right;">
                                                        <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" ValidationGroup="Login1" OnClick="LoginButton_Click"></asp:Button>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </LayoutTemplate>
                        </asp:Login>
                    </asp:Panel>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
