<%@ Page Title="Add dataset" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddDataset.aspx.cs" Inherits="azmayeshgah.pages.AddDataset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <h2><%: Title %></h2>
    <br />
    <br />
    <br />
      <table>
    <tr>
        <td >
            Data ID</td>
        <td>
            <asp:TextBox ID="txtDataId" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        
                <td>FileName : </td>
                <td>
                     <br />  <asp:TextBox ID="txtFileName" runat="server"></asp:TextBox>
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
              <td>Dataset : </td>
                <td>
                    <asp:FileUpload ID="FUIDataset" runat="server" />
                     <asp:Label ID="lblMsg" runat="server" />
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
           
            <asp:Button  ID="btnAdd" runat="server" Text="Add" Width="80px"
                onclick="btnAdd_Click" />
           
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
                <asp:BoundField DataField="data_id" HeaderText="Dataset ID" />
                <asp:BoundField DataField="filename" HeaderText="FileName" />
                <asp:BoundField DataField="description" HeaderText="description" />
            </Columns>
</asp:GridView>
</asp:Content>
