<%@ Page Title="Add News" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddNews.aspx.cs" Inherits="azmayeshgah.pages.AddNews" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <h2><%: Title %></h2>
    <br />
    <br />
    <br />
      <table>
    <tr>
        <td >
            News ID</td>
        <td>
            <asp:TextBox ID="txtNewsId" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        
                <td>Title : </td>
                <td>
                     <br />  <asp:TextBox ID="txtTitle" runat="server" Height="42px" TextMode="MultiLine" Width="589px"></asp:TextBox>
                </td>
        </tr>
          <tr>
        <td style="width: 120px">
            Description :</td>
        <td>
           <br />    <br />  <asp:TextBox ID="txtDescrip" runat="server" TextMode="MultiLine" Width="588px" Height="160px"></asp:TextBox>
        </td>
    </tr>
        
     <tr>
        <td style="width: 120px">
            Link :</td>
        <td>
           <br />  <asp:TextBox ID="txtLink" runat="server" Width="582px"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td style="width: 120px">
      
     <tr>
        <td style="width: 120px">
            Active :</td>
        <td>
           <br />  <asp:DropDownList ID="dropActive" runat="server">
                <asp:ListItem>Yes</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:DropDownList>
            
        </td>

    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
           
            <asp:Button class="btn-default" ID="btnAdd" runat="server" Text="Add" Width="80px"
                onclick="btnAdd_Click" />
            <asp:Button class="btn-default" ID="btnEdit" runat="server" onclick="btnEdit_Click" Text="Edit"
                Width="80px" />
            <asp:Button class="btn-default" ID="btnDelete" runat="server" onclick="btnDelete_Click" Text="Delete"
                Width="80px" />
            <asp:Label class="btn-default" ID="LResult" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
            <asp:Button class="btn-block" ID="btnSearch" runat="server" onclick="btnSearch_Click"
                Text="Search" Width="80px" />
        </td>
    </tr>
</table>
    <br />
    <br />
    <hr />
 
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
            Width="600px" AutoGenerateSelectButton="True"
            onselectedindexchanged="GridView1_SelectedIndexChanged"
           >
            <Columns>
                <asp:BoundField DataField="news_id" HeaderText="News ID" />
                <asp:BoundField DataField="title" HeaderText="Title" />
                <asp:BoundField DataField="link" HeaderText="Link" />
                <asp:BoundField DataField="active" HeaderText="Active" />
               
            </Columns>
</asp:GridView>
</asp:Content>
