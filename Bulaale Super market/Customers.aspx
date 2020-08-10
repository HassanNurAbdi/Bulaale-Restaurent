<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Customers.aspx.vb" Inherits="Bulaale_Super_market.Customers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            position: relative;
            width: 100%;
            -ms-flex: 0 0 33.333333%;
            flex: 0 0 33.333333%;
            max-width: 33.333333%;
            left: -15px;
            top: -998px;
            padding-left: 15px;
            padding-right: 15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid m-0 backgroundSawir" style="height:900px;">
       
        <div class="row mt-3">

             <div class="col-4">
                 <h1 style="font-family:Tahoma;font-weight:bold;font-size:40px;">Manage Customer</h1>
                 <br>

                 <div class="row mt-2">
                     <div class="pl-2 pr-2">
                               <div class="card">
                                               <div class="card-body">
                                                   <div class="row">
                                                       <div class="col">
                                                           <center>
                                                               <img width="150px"  src="imgs/user.png" />
                                                           </center>
                                                       </div>

                           
                                                   </div>
                                                   <div class="row">
                                                       <div class="col">
                                                           <center>
                                                              Customers
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
                                                            <label>Full Name</label>
                                                           <div class="form-group">
                                                               <asp:TextBox class="form-control" ID="txtFullname" runat="server" placeholder="Fullname"></asp:TextBox>
                                                           </div>
                                                       </div>
                                                   </div>
                                                   <div class="row">
                                                       <div class="col-md-6">
                                                            <label>Contact No</label>
                                                           <div class="form-group">
                                                               <asp:TextBox class="form-control" ID="txtContactno" runat="server" placeholder="Contact No" TextMode="Number"></asp:TextBox>
                                                           </div>
                                                       </div>
                                                           <div class="col-md-6">
                                                            <label>Email</label>
                                                           <div class="form-group">
                                                               <asp:TextBox class="form-control" ID="txtEmail" runat="server" placeholder="Examaple@group.com" TextMode="Email"></asp:TextBox>
                                                           </div>
                                                       </div>
                                                   </div>
                                                    <div class="row">
                                                       <div class="col">
                                                            <label>State</label>
                                                           <div class="form-group">
                                                               <asp:DropDownList CssClass="form-control" ID="cboState" runat="server">
                                                                   <asp:ListItem Text="Select" Value="select" />
                                                          <asp:ListItem Text="Boondheere" Value="Boondheere" />
                                                          <asp:ListItem Text="CabdiCasiis" Value="CabdiCasiis" />
                                                          <asp:ListItem Text="Dayniile" Value="Dayniile" />
                                                          <asp:ListItem Text="Dharkenley" Value="Dharkenley" />
                                                          <asp:ListItem Text="Hodan" Value="Hodan" />
                                                          <asp:ListItem Text="Howlwadaag" Value="Howlwadaag" />
                                                          <asp:ListItem Text="Hiliwaa" Value="Hiliwaa" />
                                                          <asp:ListItem Text="Kaxda" Value="Kaxda" />
                                                          <asp:ListItem Text="Kaaraan" Value="Kaaraan" />
                                                          <asp:ListItem Text="Shibis" Value="Shibis" />
                                                          <asp:ListItem Text="Shangaani" Value="Shangaani" />
                                                          <asp:ListItem Text="Waaberi" Value="Waaberi" />
                                                          <asp:ListItem Text="Wadajir" Value="Wadajir" />
                                                          <asp:ListItem Text="Warta-Nabadda" Value="Warta-Nabadda" />
                                                          <asp:ListItem Text="Xamar-jajab" Value="Xamar-jajab" />
                                                          <asp:ListItem Text="Xamar-weyne" Value="Xamar-weyne" />
                                                          <asp:ListItem Text="Yaaqshiid" Value="Yaaqshiid" />
                                                               </asp:DropDownList>
                                                           </div>
                                                       </div>
                                                      
                                                   </div>
                                                     <div class="row">
                                                       <div class="col">
                                                           <label>Full Address</label>
                                                           <div class="form-group">
                                                               <asp:TextBox class="form-control" ID="txtAddress" runat="server" placeholder="Address" TextMode="MultiLine" Rows="2"></asp:TextBox>
                                                           </div>
                                                       </div>
                                                   </div>
                                                   <div class="row">
                          
                                                       <div class="col">
                                                            <center>
                                                           <span class="badge badge-pill badge-info">Login Credensials</span>
                                                            </center>
                                                       </div>
                              
                                                   </div>
                                                    <div class="row">
                                                       <div class="col-md-6">
                                                            <label>User ID</label>
                                                           <div class="form-group">
                                                               <asp:TextBox class="form-control" ID="txtuserId" runat="server" placeholder="User ID" ></asp:TextBox>
                                                           </div>
                                                       </div>
                                                           <div class="col-md-6">
                                                            <label>Password</label>
                                                           <div class="form-group">
                                                               <asp:TextBox class="form-control" ID="txtPassword" runat="server" placeholder="Password"></asp:TextBox>
                                                           </div>
                                                       </div>
                                                   </div>
                                                   <div class="row">
                                                           <div class="col">
                                                              <div class="form-group">
                                                                   <asp:Button CssClass="btn btn-success btn-block btn-lg" ID="btnUpdate" runat="server" Text="Update" />
                                                               </div>
                                                           </div>

                                                          <div class="col ml-2">
                                                              <div class="form-group">
                                                                   <asp:Button CssClass="btn btn-danger btn-block btn-lg" ID="btnDelete" runat="server" Text="Delete" />
                                                               </div>
          
                                                       </div>
                                                   </div>
                                               </div>
       
                                            </div>
                 </div>
             </div>
        </div>







                    <div class="col-8">
                 <h1 style="font-family:Tahoma;font-weight:bold;font-size:40px; text-align:center">Customer Table</h1>
                 <br>

                 <div class="row mt-2">
                     <div class="col-12">
                     <div class="card">
                         <div class="card-header">
                             <div class="row">

                                     
                                     <div class="col-4">
                                          <table>
                                        <tr>
                                             <td>
                                                 <asp:TextBox ID="txtsearch" runat="server"></asp:TextBox>
                                             </td>
                                             <td>
                                                 <asp:Button ID="btnSearch" CssClass="btn btn-success" runat="server" Text="Search" BackColor="#CA2D22" />
                                             </td>
                                            
                                         </tr>
                                        </table>
                                     </div>
                                      
                             

                                 <div class="col-6 text-right ml-0">
                                     <asp:Button ID="btnRefresh" CssClass="btn btn-primary" runat="server" Text="Refresh" />
                                 </div>

                            </div>
                         </div>

                         <div class="card-body">
                          <div>
                                 <div class="col-12 btn-block">
                                         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="userID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Width="977px" AllowPaging="True" Height="16px">
                                             <AlternatingRowStyle BackColor="White" />
                                             <Columns>
                                                 <asp:CommandField ShowSelectButton="True" />
                                                 <asp:BoundField DataField="CID" HeaderText="CID" InsertVisible="False" ReadOnly="True" SortExpression="CID" Visible="False" />
                                                 <asp:BoundField DataField="Fullname" HeaderText="Fullname" SortExpression="Fullname" />
                                                 <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                                                 <asp:BoundField DataField="state" HeaderText="state" SortExpression="state" />
                                                 <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                                                 <asp:BoundField DataField="contactNo" HeaderText="contactNo" SortExpression="contactNo" />
                                                 <asp:BoundField DataField="userID" HeaderText="userID" ReadOnly="True" SortExpression="userID" />
                                                 <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
                                             </Columns>
                                             <EditRowStyle BackColor="#2461BF" />
                                             <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                             <HeaderStyle BackColor="#CA2D22" Font-Bold="True" ForeColor="White" />
                                             <PagerStyle BackColor="#CA2D22" ForeColor="White" HorizontalAlign="Center" />
                                             <RowStyle BackColor="#EFF3FB" />
                                             <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                             <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                             <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                             <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                             <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                         </asp:GridView>
                                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:con %>" SelectCommand="SELECT [Fullname], [address], [state], [email], [userID], [contactNo], [password], [CID] FROM [Customer]"></asp:SqlDataSource>
                              

                                 </div>

                             </div>
                             
                         </div>


                     </div>
                    </div>
                </div>
        </div>
            











    </div>

</div>
</asp:Content>
