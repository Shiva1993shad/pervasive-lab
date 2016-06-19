<%@ Page Title="Manage Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="azmayeshgah.Account.Manage" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

    <p><asp:Literal runat="server" Text="username" /> <strong><%: User.Identity.Name %></strong>.</p>
  
         <div class="form-group">
                        <asp:Label runat="server"  CssClass="col-md-2 control-label">User name</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="UserName" CssClass="form-control" />
                        </div>
                    </div>
        <div class="form-group">
                        <asp:Label runat="server"  CssClass="col-md-2 control-label">Password</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                            </div>
        </div>
        <div class="form-group">
                        <asp:Label runat="server"  CssClass="col-md-2 control-label">Confirm Password</asp:Label>
                        <div class="col-md-10">
                         <asp:TextBox runat="server" ID="Confirm_Password" TextMode="Password" CssClass="form-control" />
                            </div>
        </div>
       
           <asp:Label runat="server" AssociatedControlID="UserName" CssClass="col-md-2 control-label">Email</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Email" CssClass="form-control" />
                            </div>

                <asp:Button ID="btn_Save" runat="server" Text="save changes" OnClick="btn_Save_Click" />
                <asp:Label ID="LResult" runat="server" Text=""></asp:Label>


</asp:Content>
