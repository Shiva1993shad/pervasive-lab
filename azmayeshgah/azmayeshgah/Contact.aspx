<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="azmayeshgah.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
   <div class="row">
       <div class="col-md-8">
            <div class="content">
                 <address>

                    <span class="glyphicon glyphicon-map-marker"></span> 
                    <strong>
                       Address:
                    </strong>
        
                    <br />
        
                    IRAN-Teheran-velenjak AVE-Shahid Beheshti University-Faculty of Sciences and Computer Engineering<br />
                    <span class="glyphicon glyphicon-phone"></span> 
                    <strong>
                        Phone :
                        <br />

                    </strong>

                    425.555.0100
                </address>


                <address>
                    <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
                </address>
                <p>
                    <h5>visit us on google map :</h5>
                </p>
                <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d25894.139577007947!2d51.42029045496169!3d35.78108844658931!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0000000000000000%3A0x06978d2057f2a8c2!2z2K_Yp9mG2LTaqdiv2Ycg2YXZh9mG2K_Ys9uMINio2LHZgiDZiCDaqdin2YXZvtuM2YjYqtixINiv2KfZhti02q_Yp9mHINi02YfbjNivINio2YfYtNiq24w!5e0!3m2!1sfa!2sir!4v1460122417790" width="600" height="450" frameborder="0" style="border:0" allowfullscreen></iframe>

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
