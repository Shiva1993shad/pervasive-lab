<%@ Page Title="Events" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Event.aspx.cs" Inherits="azmayeshgah.pages.Event" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h2><%: Title %></h2>
    <br />
    <asp:ListView ID="eventList" runat="server" 
                DataKeyNames="event_id" GroupItemCount="1"
                ItemType="azmayeshgah.Models.eventsfeed" SelectMethod="Get_event">
                <EmptyDataTemplate>
                    <table class="table-responsive">
                        <tr>
                            <td> No Item</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                        <table runat="server" cellpadding="3" cellspacing="1" align="center" width="100%">
				         <tbody>
                            <tr style="background-color:#bbbbbb ">
                                <th> Event </th>
                                <th> When </th>
                                <th> Where </th>
                                <th> Deadline</th>
                            </tr>

                             <tr style="background-color:#f6f6f6">
                                 <td rowspan="2" style="text-align:left"><a href=<%#:Item.link %>> <%#:Item.title %> </a></td>
                                 <td colspan="3" style="text-align:left"><%#:Item.descrip  %></td>
                            </tr>
                            <tr style="background-color:#f6f6f6">
                                <td style="text-align:left"><%#: Item.call %></td>
                                <td style="text-align:left"><%#: Item.place %></td>
                                <td style="text-align:left"><%#: Item.deadline %></td>
                            </tr>
                          </tbody>
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
                 
                
                <hr/>
    
</asp:Content>
