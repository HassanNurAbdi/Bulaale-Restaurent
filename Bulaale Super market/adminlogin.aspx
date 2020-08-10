<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="adminlogin.aspx.vb" Inherits="Bulaale_Super_market.adminlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
       <div class="row">
           <div class="col-md-6 mx-auto">
               <div class="card">
                   <div class="card-body">
                       <div class="row">
                           <div class="col">
                               <center>
                                   <img width="150px"  src="imgs/images%20(1).jpg" />
                               </center>
                           </div>

                           
                       </div>
                       <div class="row">
                           <div class="col">
                               <center>
                                  Registration page
                               </center>
                           </div>
                       </div>
                       <div class="row">
                           <div class="col">
                               <center>
                                  <hr />
                               </center>
                           </div>
                       </div>
                       <div class="row">
                           <div class="col">
                               
                               <div class="form-group">
                                   <asp:TextBox class="form-control" ID="txtusername" runat="server" placeholder="member ID" Width="1554px"></asp:TextBox>
                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtusername" ErrorMessage="Please enter member id" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                               </div>
                                
                               <div class="form-group">
                                   <asp:TextBox class="form-control" ID="txtpassword" runat="server" placeholder="pasword" TextMode="Password" Width="1555px"></asp:TextBox>
                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtpassword" ErrorMessage="Please enter member password" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                               </div>
                               <div class="form-group">
                                   <asp:Button CssClass="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Login" />
                               </div>
                             
                           </div>
                       </div>
                   </div>
       
                </div>
       
            </div>
       
          </div>
    </div>
</asp:Content>
