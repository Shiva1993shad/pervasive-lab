<%@ Page Title="manage people" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PeopleAdd.aspx.cs" Inherits="azmayeshgah.pages.peopleAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <br />
    <br />
    <br />
      <table>
    <tr>
        <td >
            People ID</td>
        <td>
            <asp:TextBox ID="txtPeopleID" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        
                <td>Image : </td>
                <td>
                    <asp:FileUpload ID="FUImage" runat="server" />
                     <asp:Label ID="lblMsg" runat="server" />
                </td>
        </tr>
        

    <tr>
        <td style="width: 120px">
            Name</td>
        <td>
          <br />  <asp:TextBox ID="txtName" runat="server" Width="250px"></asp:TextBox>
        </td>
    </tr>
     <tr>
        <td style="width: 120px">
            Link</td>
        <td>
           <br />  <asp:TextBox ID="txtLink" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 120px">
            Email</td>
        <td>
           <br />  <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </td>

    </tr>
    <tr>
        <td>
            Graduate State </td>
        <td>
           <br />  <asp:DropDownList ID="dropGrad" runat="server">
                <asp:ListItem>graduate</asp:ListItem>
                <asp:ListItem>not graduate</asp:ListItem>
            </asp:DropDownList>
            
        </td>
    </tr>
     <tr>
        <td>
            Type </td>
        <td>
            <br />  <asp:DropDownList ID="dropType" runat="server">
                <asp:ListItem>Academic Staff</asp:ListItem>
                <asp:ListItem>Past Affiliates</asp:ListItem>
                 <asp:ListItem>Ph.D. students</asp:ListItem>
                 <asp:ListItem>M.Sc. students</asp:ListItem>
                 <asp:ListItem>B.Sc. students</asp:ListItem>
                 <asp:ListItem>Visitors</asp:ListItem>
                 <asp:ListItem>Ph.D. graduated</asp:ListItem>
            </asp:DropDownList>
            
        </td>
    </tr>
            <tr>
        <td>
            Active
        </td>
        <td>
           <br />  <asp:DropDownList ID="dropActive" runat="server">
                <asp:ListItem>Yes</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:DropDownList>


        </td>
    </tr>
          <tr>
        <td>
            description</td>
        <td>
           <br />  <asp:TextBox ID="txtDescrip" runat="server" TextMode="MultiLine" Width="250px"></asp:TextBox>
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
                <asp:BoundField DataField="people_id" HeaderText="People ID" />
                <asp:BoundField DataField="name" HeaderText="Name" />
              
                <asp:BoundField DataField="link" HeaderText="Link" />
                <asp:BoundField DataField="email" HeaderText="Email" />
                <asp:BoundField DataField="gradstatus" HeaderText="Graduate State " />
                <asp:BoundField DataField="type" HeaderText="Type" />
                <asp:BoundField DataField="active" HeaderText="Active" />
                <asp:BoundField DataField="descrip" HeaderText="description" />
            </Columns>
</asp:GridView>
</asp:Content>
