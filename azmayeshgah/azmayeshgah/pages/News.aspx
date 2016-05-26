<%@ Page Title="News" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="azmayeshgah.pages.News" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <h2><%:Title %></h2> 
    <div class="row">
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
            Width="600px" AutoGenerateSelectButton="True"
            onselectedindexchanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="news_id" HeaderText="News ID" />
               
                <asp:BoundField DataField="title" HeaderText="Title" />
              
                <asp:BoundField DataField="news_day" HeaderText="Time" />
                <asp:BoundField DataField="link" HeaderText="Link" />
                <asp:BoundField DataField="descrip" HeaderText="Description" />
                <asp:BoundField DataField="expire_date" HeaderText="Expire Date" />
                <asp:BoundField DataField="active" HeaderText="Active" />
  
            </Columns>

</asp:GridView>
        <br />
        <br />
       
        <table ID="News_table">
            <tr>
                <td>
                    Title
                </td>
                <td>
                    <asp:TextBox ID="txtTitle" runat="server" Enabled="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Title
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Enabled="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Title
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Enabled="True"></asp:TextBox>
                </td>
            </tr>
        </table>
       </div>

</asp:Content>
