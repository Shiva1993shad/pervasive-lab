<%@ Page Title="News" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="azmayeshgah.pages.News" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <h2><%:Title %></h2> 
    <div class="row">
    
        
        <br />
        <br />
       
      <div class="col-md-8">
            <div class="content">
               <br />
                <asp:ListView ID="NewsList" runat="server" 
                DataKeyNames="news_id" GroupItemCount="1"
                ItemType="azmayeshgah.Models.newsfeed" SelectMethod="Get_News">
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td> No News</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td/>
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <p>
                        <table runat="server">
                            <tr>
                                <td>
                                    
                                        <img src="../image/news.jpg" width="140" height="140" style="border: solid" />
                                          
                                     </td>
                                
                                    <td id="Itemdescrip">
                                         <%#:Item.descrip %>
                                     </td>
                                </tr>
                                  <tr>   
                                    <td  id="ItemTitle" style="color:blue; font-size:larger">
                                            <%#:Item.title %>
                                    </td>
                                    </tr>
                                    <tr>
                                     <td>
                                       <asp:Label ID="ItemDate" runat="server" Text="" Font-Size="Small"> <%#:Item.news_day %></asp:Label>
                                       
                                    </td>
                                    </tr>
                                     <tr>     
                                     <td>
                                    <a href="<%#:Item.link%>">           
                                     Link of News
                                    </a>
                                     </td>
                                     </tr>
                                   
                              <hr />
                                
                                
                                   
                            
                          
                        </table>
                        </p>
                  
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width:100%">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
       </div>
          </div>
        </div>
</asp:Content>
