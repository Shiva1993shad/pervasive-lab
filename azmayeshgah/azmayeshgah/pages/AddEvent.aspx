<%@ Page Title="Manage Events" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEvent.aspx.cs" Inherits="azmayeshgah.pages.AddEvent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <h2><%: Title %></h2>
    <br />
    <br />
    <br />
      <table>
    <tr>
        <td >
            Event ID</td>
        <td>
            <asp:TextBox ID="txtEventId" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        
                <td>Title : </td>
                <td>
                     <br />  <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                </td>
        </tr>
          <tr>
        <td style="width: 120px">
            Description :</td>
        <td>
           <br />    <br />  <asp:TextBox ID="txtDescrip" runat="server" TextMode="MultiLine" Width="250px"></asp:TextBox>
        </td>
    </tr>
        
     <tr>
        <td style="width: 120px">
            Link :</td>
        <td>
           <br />  <asp:TextBox ID="txtLink" runat="server"></asp:TextBox>
        </td>
    </tr>
      <tr>
        <td style="width: 120px">
            Place :</td>
        <td>
          <br />  <asp:TextBox ID="txtPlace" runat="server" Width="250px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 120px">
            Call :</td>
        <td>
          <br />  <asp:TextBox ID="txtCall" runat="server" Width="250px"></asp:TextBox>
        </td>
    </tr>
     <tr>
        <td style="width: 120px">
            Deadline :</td>
        <td>
          <br />  <asp:TextBox ID="txtDeadline" runat="server" Width="250px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 120px">
            Year :</td>
        <td>
           <br />  <asp:TextBox ID="txtYear" runat="server"></asp:TextBox>
        </td>

    </tr>
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
           
            <asp:Button class="" ID="btnAdd" runat="server" Text="Add" Width="80px"
                onclick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" onclick="btnEdit_Click" Text="Edit"
                Width="80px" />
            <asp:Button ID="btnDelete" runat="server" onclick="btnDelete_Click" Text="Delete"
                Width="80px" />
            <asp:Label ID="LResult" runat="server" Text=""></asp:Label>
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
            <asp:Button ID="btnSearch" runat="server" onclick="btnSearch_Click"
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
                <asp:BoundField DataField="event_id" HeaderText="Event ID" />
                <asp:BoundField DataField="title" HeaderText="Title" />
                <asp:BoundField DataField="link" HeaderText="Link" />
                <asp:BoundField DataField="place" HeaderText="Place" />
                <asp:BoundField DataField="call" HeaderText="Call" />
                <asp:BoundField DataField="deadline" HeaderText="Deadline" />
                <asp:BoundField DataField="active" HeaderText="Active" />
                <asp:BoundField DataField="year" HeaderText="yaer" />
                <asp:BoundField DataField="descrip" HeaderText="description" />
            </Columns>
</asp:GridView>
</asp:Content>

