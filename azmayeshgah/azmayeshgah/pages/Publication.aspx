<%@ Page Title="Publications" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Publication.aspx.cs" Inherits="azmayeshgah.pages.Publication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <h2><%: Title %></h2>
    <br />
    
       <div class="row">
       <div class="col-md-8">

      <asp:ListView ID="publist" runat="server" 
                DataKeyNames="pub_id" GroupItemCount="1"
                ItemType="azmayeshgah.Models.person" SelectMethod="Get_Academic_Staff">
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td> No Item</td>
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
                                    
                                        <img src="<%#:Item.picSrc%>"
                                            width="120" height="140" style="border: solid" />
                                </td>
                                <td>
                                   
                                    <tr>
                                    <td  id="ItemName" style="color:blue; font-size:medium">
                                            <%#:Item.name %>
                                    </td>
                                    </tr>
                                    <tr>
                                     <td>
                                       <asp:Label ID="RoomLbl" runat="server" Text="Room"> <%#:Item.room %></asp:Label>
                                       
                                    </td>
                                    </tr>
                                    <tr>
                                    <td>
                                        <span>Telephone :</span>
                                        <%#:Item.phone %>
                                     </td>
                                     </tr>
                                    <tr>   
                                     <td>
                                        <span>
                                           Email :
                                        </span>
                                         <a href="<%#:Item.email %>"></a> 
                                     </td> 
                                     </tr>
                                     <tr>     
                                     <td>
                                    <a href="<%#:Item.link%>">           
                                     Personal homepage
                                    </a>
                                     </td>
                                     </tr>
                                     <tr>     
                                     <td>
                                    <a href="Publication.aspx?id=<%#:Item.people_id%>">    
                                     Publications
                                    </a>
                                     </td>
                                     </tr>
                              
                                
                                </td>
                                   
                            </tr>
                          
                        </table>
                        </p>
                  
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width:100%;">
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
            <div class="col-md-4">
            <div class="col">
                <h2>Events</h2><hr/>
                  <asp:ListView ID="ListEvents" runat="server" 
                DataKeyNames="event_id" GroupItemCount="1"
                ItemType="azmayeshgah.Models.event" SelectMethod="Get_event">
                  <LayoutTemplate>
                    <ul id="newsfade">
                      <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
                    </ul>
                  </LayoutTemplate>
                  <ItemTemplate>
                    <li class="Eventsitems">
                      <asp:HyperLink ID="EventsLink" runat="server" 
                        NavigateUrl='<%# Item.link %>'
                        Text='<%# Item.title %>' />
                    </li>
                      
                  </ItemTemplate>
                </asp:ListView>


            </div>
            <div class="col">
                <h2>News</h2><hr/>
                  <asp:ListView ID="ListNews" runat="server" 
                DataKeyNames="news_id" GroupItemCount="1"
                ItemType="azmayeshgah.Models.newsfeed" SelectMethod="Get_news">
                  <LayoutTemplate>
                    <ul id="newsfade">
                      <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
                    </ul>
                  </LayoutTemplate>
                  <ItemTemplate>
                    <li class="newsitems">
                      <asp:HyperLink ID="NewsLink" runat="server" 
                        NavigateUrl='<%# Item.link %>'
                        Text='<%# Item.title %>' />
                    </li>
                      
                  </ItemTemplate>
                </asp:ListView>

            </div>
        </div>
       </div>
</asp:Content>
