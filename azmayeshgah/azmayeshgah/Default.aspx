<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="azmayeshgah._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
          <p>
            <img src="image/logo3.JPG" alt="Home" style="height: 400px; width: 1030px ;  margin:auto;" usemap="#HomeLogo"/>
            <map name="HomeLogo">
                <area shape="rect" coords="15,15,111,92" alt="default" runat="server" href="~/">
                <area shape="rect" coords="147,16,232,94" alt="people" runat="server" href="~/pages/People">
                <area shape="rect" coords="265,18,353,94" alt="publication" runat="server" href="~/pages/Publication">
                <area shape="rect" coords="337,16,475,94" alt="collabration" runat="server" href="~/pages/Collabration">
                <area shape="rect" coords="500,18,606,94" alt="Research" runat="server" href="~/pages/Research">
                <area shape="rect" coords="620,18,720,94" alt="event" runat="server" href="~/pages/Event">
                <area shape="rect" coords="740,18,830,92" alt="News" runat="server" href="~/pages/News">
                <area shape="rect" coords="841,18,903,92" alt="Contact" runat="server" href="~/Contact">
                <area shape="rect" coords="925,18,1016,92" alt="Dataset" runat="server" href="~/pages/Dataset">
                
            </map>
        </p>
    </div>
   

    <div class="row">
        <div class="col-md-8">
            <div class="content">
        <p>
            <h2>
                About our system 
            </h2>
            </p>
        <p>
            <h5>
                SP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </h5>
        </p>
         </div>
         
        </div>
        <div class="col-md-4">
            <div class="col">
                <h2>Events</h2><hr/>
            </div>
            <div class="col">
                <h2>News</h2><hr/>

            </div>
        </div>
        
    </div>

</asp:Content>
