<%@ Page Title="People" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="People.aspx.cs" Inherits="azmayeshgah.pages.People" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <br />
    
       <div class="row">
       <div class="col-md-8">
            <div class="content">
                <div class="" id="main_people">
                    <a href="#Academic"><strong style="color:#00bfff">Academic Staff</strong></a><br/>
                    <a href="#Affiliate"><strong style="color:#00bfff">Past Affiliates</strong></a><br/>
                    <a href="#Phd"><strong style="color:#00bfff">Ph.D. students</strong></a><br/>
                    <a href="#Msc"><strong style="color:#00bfff">M.Sc. students</strong></a><br/>
                    <a href="#Bsc"><strong style="color:#00bfff">B.Sc. students</strong></a><br/>
                    <a href="#Visitor"><strong style="color:#00bfff">Visitors</strong></a><br/><hr />
                </div>
                <div  class="row" id="Academic" title="Academic Staff">
                <strong style="color:#00bfff">Academic Staff</strong><br />
                <asp:ListView ID="peopleList" runat="server" 
                DataKeyNames="people_id" GroupItemCount="1"
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
                                <td class="col-lg-1">
                                    
                                        <img src="<%#:Item.picSrc%>"
                                            width="120" height="140" style="border: solid" />
                                </td>
                                <td class="col-lg-2">
                                   <p>
                                       <span style="color:blue; font-size:medium"> <%#:Item.name %></span>
                                       <br />
                                       <span>
                                           <asp:Label ID="RoomLbl" runat="server" Text="Room"> <%#:Item.room %></asp:Label>
                                       </span>
                                       <br />
                                       <span>
                                           <span>Telephone :</span>
                                        <%#:Item.phone %>
                                       </span>
                                       <br />
                                       <span>
                                            <span>
                                           Email :
                                        </span>
                                         <a href="<%#:Item.email %>"></a> 
                                       </span>
                                       <br />
                                       <span>
                                            <a href="<%#:Item.link%>">           
                                     Personal homepage
                                    </a>
                                       </span>
                                       <br />
                                       <span>
                                           <a href="Publication.aspx?id=<%#:Item.people_id%>">    
                                     Publications
                                    </a>
                                       </span>
                                   </p>
                             
                                   
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
                <hr/>
                <div class="row" id="Affiliate" title="Past Affiliates">
                    <strong style="color:#00bfff">Past Affiliates</strong>
                    <br />
                     <asp:ListView ID="ListView1" runat="server" 
                DataKeyNames="people_id" GroupItemCount="1"
                ItemType="azmayeshgah.Models.person" SelectMethod="Get_Past_Affiliates">
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
                                    <td style="color:blue; font-size:medium">
                                            <%#:Item.name %>
                                    </td>
                                    </tr>
                                    <tr>
                                     <td>
                                       <span>Room :</span> 
                                        <%#:Item.room %>
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
                                    <a href="<%#:Item.publications%>">           
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
                <hr/>
                <div class="row" id="Phd" title="Ph.D. students">
                     <strong style="color:#00bfff">Ph.D. students</strong>
                    <br />
                     <asp:ListView ID="ListView2" runat="server" 
                DataKeyNames="people_id" GroupItemCount="4"
                ItemType="azmayeshgah.Models.person" SelectMethod="Get_PhD_students">
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
                                    <td style="color:blue; font-size:medium">
                                            <%#:Item.name %>
                                    </td>
                                    </tr>
                                    <tr>
                                     <td>
                                       <span>Room :</span> 
                                        <%#:Item.room %>
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
                                    <a href="<%#:Item.publications%>">           
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
                <hr/>
                
                <div class="row" id="Msc" title="M.Sc. students">
                     <strong style="color:#00bfff">M.Sc. students</strong>
                                        <br />
                     <asp:ListView ID="ListView3" runat="server" 
                DataKeyNames="people_id" GroupItemCount="4"
                ItemType="azmayeshgah.Models.person" SelectMethod="Get_MSc_students">
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td> Error Item NotFound</td>
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
                    <table runat="server">
                    <tr>
                                <td>
                                    
                                        <img src="<%#:Item.picSrc%>"
                                            width="120" height="140" style="border: solid" />
                                </td>
                                <td>
                                   
                                    <tr>
                                    <td style="color:blue; font-size:medium">
                                            <%#:Item.name %>
                                    </td>
                                    </tr>
                                    <tr>
                                     <td>
                                       <span>Room :</span> 
                                        <%#:Item.room %>
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
                                    <a href="<%#:Item.publications%>">           
                                     Publications
                                    </a>
                                     </td>
                                     </tr>
                              
                                
                                </td>
                                   
                            </tr>
                        </table>
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
                    
               
                <hr/>
                <div class="colomn" id="Bsc" title="B.Sc. students">
                    <strong style="color:#00bfff">B.Sc. students</strong>
                                        <br />
                     <asp:ListView ID="ListView4" runat="server" 
                DataKeyNames="people_id" GroupItemCount="1"
                ItemType="azmayeshgah.Models.person" SelectMethod="Get_BSc_students">
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
                        <table runat="server">
                            <tr>
                                
                                    
                                <td style="color:blue; font-size:medium">
                                      <%#:Item.name %>
                               </td>
                                <td>
                                    <span>
                                        Email :
                                    </span>
                                    <%#:Item.email %>
                                </td>
                                        
                                
                            
                                <td>&nbsp;</td>
                            </tr>
                        </table>
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
                   
                
                <hr/>
                <div class="row" id="Visitor" title="Visitors">
                    <strong style="color:#00bfff">Visitors</strong>
                                        <br />
                     <asp:ListView ID="ListView5" runat="server" 
                DataKeyNames="people_id" GroupItemCount="4"
                ItemType="azmayeshgah.Models.person" SelectMethod="Get_Visitors">
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
                    <td runat="server">
                        <table>
                            <tr>
                                <td>
                                         <span>
                                            <%#:Item.name%>
                                        </span>
                                        
                                </td>
                            </tr>
                           
                        </table>
                        </p>
                    </td>
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
                   
               
                
             
        </div> 
     </div>
        <div class="col-md-4">
            <div class="col">
                <h2>Events</h2><hr/>
                <asp:ListView ID="EventID" runat="server" 
                DataKeyNames="event_id" GroupItemCount="1"
                ItemType="azmayeshgah.Models.eventsfeed" SelectMethod="Get_5event">
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
                            <tr >
                                   <td style="color:blue">
                                    <a href="<%#:Item.link%>">           
                                     <%#:Item.title%>
                                    </a>       
                                    </td>
                                    <td>
                                       (  <%#:Item.place %>  )
                                     </td>

                                     <td style="font-size:smaller">
                                       {   <%#:Item.deadline %>  }
                                       
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
            <div class="col">
                <h2>News</h2><hr/>
                <asp:ListView ID="news" runat="server" 
                DataKeyNames="news_id" GroupItemCount="1"
                ItemType="azmayeshgah.Models.newsfeed" SelectMethod="Get_news">
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
                            <tr >
                                   <td style="color:blue ; font-size:medium">
                                    <a href="<%#:Item.link%>">           
                                     <%#:Item.title%>
                                    </a>       
                                    </td>
                                    <td style="font-size:small">
                                      <%#:Item.news_day %>
                                    </td>
                                    
                                     
                                   
                            </tr>
                          
                        </table>
                        </p>
                  
                </ItemTemplate>
                <LayoutTemplate>
                    <table>
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
