<%@ Page Title="Dataset" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dataset.aspx.cs" Inherits="azmayeshgah.pages.Dataset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <h2><%: Title %></h2>
    <br />    

     <div class="row">
       <div class="col-md-8">
           <br />
           <br />
           <br />
           <asp:Image ID="UnderConstruct" runat="server" ImageUrl="~/image/construction.png"/>
            <div class="content">
               <asp:GridView ID="datagrid" CssClass="table-responsive" runat="server"  AutoGenerateColumns="false"
            Width="600px" AutoGenerateSelectButton="True"
            
           >
            <Columns >
               
                <asp:BoundField DataField="filename" HeaderText="FileName" />
                <asp:BoundField DataField="description" HeaderText="description" />
                 <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HyperLink runat="server"
                            NavigateUrl='<%# Eval("data_id", "GetFile.aspx?data_id={0}") %>'
                            Text="Download"></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
</asp:GridView>
             
         </div>
         
     </div>
        <div class="col-md-4">
            <div class="col">
                <h2>Events</h2>
            </div>
            <div class="col">
                <h2>News</h2>

            </div>
        </div>
       </div>
</asp:Content>
