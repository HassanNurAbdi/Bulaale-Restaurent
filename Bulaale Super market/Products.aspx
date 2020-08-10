<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Products.aspx.vb" Inherits="Bulaale_Super_market.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid m-0 backgroundSawir" style="height:900px;">
       
        <div class="row mt-3">

             <div class="col-4">
                 <h1 style="font-family:Tahoma;font-weight:bold;font-size:40px;">Manage Products</h1>
                 <br>

                
                <div class="row mt-2">
                <div class="col-12">
                   <div class="card">
                   <div class="card-body">
                       <div class="row">
                           <div class="col-12">
                               <center>
                                   <img width="150px"  src="imgs/images%20(1).jpg" />
                               </center>
                           </div>

                           
                       </div>
                       <div class="row">
                           <div class="col-12">
                               <center>
                                  Products page
                               </center>
                           </div>
                       </div>
                       <div class="row">
                           <div class="col-12">
                               <center>
                                  <hr />
                               </center>
                           </div>
                       </div>
                        <div class="row">
                           <div class="col-12">
                                <label>ProductID</label>
                               <div class="form-group">
                                   <asp:TextBox class="form-control" ID="txtproductID" runat="server" placeholder="ProductID"></asp:TextBox>
                                  
                               </div>
                           </div>
                         
                       </div>
                       <div class="row">
                           <div class="col-12">
                                <label>ProductName</label>
                               <div class="form-group">
                                   <asp:TextBox class="form-control" ID="txtproductName" runat="server" placeholder="ProductName" ></asp:TextBox>
                                         </div>
                           </div>
                         
                       </div>
                   
                      
                        <div class="row">
                               <div class="col-12">
                                <label>Price</label>
                               <div class="form-group">
                                   <asp:TextBox class="form-control" ID="txtprice" runat="server" placeholder="Price" ></asp:TextBox>
                                  
                               </div>
                           </div>
                       </div>
                        
                       
                       <div class="row">
                           <div class="col">
                              <div class="form-group">
                                   <asp:Button CssClass="btn btn-success btn-block btn-lg" ID="btnInsert" runat="server" Text="Insert" />
                               </div>
                           </div>

                          <div class="col">
                              <div class="form-group">
                                   <asp:Button CssClass="btn btn-primary btn-block btn-lg" ID="btnUpdate" runat="server" Text="Update" />
                               </div>
          
                         </div>

                         <div class="col">
                              <div class="form-group">
                                
                                  <asp:Button CssClass="btn btn-danger btn-block btn-lg" ID="btnDelete" runat="server"  Text="Delete" />
                                  </div>
          
                        </div>
                   </div>
       
                </div>




                        
                     </div>
                    </div>
                </div>
           
        </div>







                    <div class="col-8">
                 <h1 style="font-family:Tahoma;font-weight:bold;font-size:40px; text-align:center">Product Table</h1>
                 <br>

                 <div class="row mt-2">
                     <div class="col-12">
                     <div class="card">
                         <div class="card-header text-right">
                             <div>
                                 
                                     <div class="row">

                                     
                                     <div class="col-4">
                                          <table>
                                        <tr>
                                             <td>
                                                 <asp:TextBox ID="txtsearch" runat="server" AutoPostBack="True"></asp:TextBox>
                                             </td>
                                             <td>
                                                 <asp:Button ID="btnSearch" CssClass="btn btn-success" runat="server" Text="Search" />
                                             </td>
                                            
                                         </tr>
                                        </table>
                                     </div>
                                      
                             

                                 <div class="col-6 text-right ml-0">
                                     <asp:Button ID="btnRefresh" CssClass="btn btn-primary" runat="server" Text="Refresh" />
                                 </div>

                            </div>
                             </div>
                           
                                  
                                         
                                     
                                
                             
                         </div>

                         <div class="card-body">
                             <div>
                                 <div class="col-12">
                                         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="productID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Width="977px" AllowPaging="True" Height="16px">
                                             <AlternatingRowStyle BackColor="White" />
                                             <Columns>
                                                 <asp:CommandField ShowSelectButton="True" />
                                                 <asp:BoundField DataField="productID" HeaderText="productID" ReadOnly="True" SortExpression="productID" />
                                                 <asp:BoundField DataField="productName" HeaderText="productName" SortExpression="productName" />
                                                 <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
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
                                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:con %>" SelectCommand="SELECT * FROM [Product]"></asp:SqlDataSource>
                              

                                 </div>

                             </div>
                             
                         </div>


                     </div>
                    </div>
                </div>
        </div>
            











    </div>






        <div class="modal fade " id="alertmodal">
            <div class="modal-dialog bg-light">
                <div class="modal-content"></div>
                <div class="modal-header">

                </div>
                <div class="modal-body">
                    <p style="font-size:18pt">Are you Sure you want <span> <asp:Label ID="lblproductID" runat="server" Text="" Font-Bold="True" Font-Size="18pt"></asp:Label></span> to Delete ?</p>
                </div>
                <div class="modal-footer">
                   <div class="row">
                     <div class="col">
                        <div class="form-group">
                              <asp:Button CssClass="btn btn-success btn-block btn-lg" ID="btnYes" runat="server"  Text="YES" />
                         </div>
                     </div>

                    <div class="col ml-2">
                      <div class="form-group">
                       <button type="button" class="btn btn-danger" data-dismiss="modal">Cancel</button>
                       </div>
          
                     </div>
                  </div>
                   
                </div>

            </div>


        </div>





</div>




<%--     <script>
        
         


         function removedata() {
             var txtid = document.getElementById("txtproductID");
             var lblid=document.getElementById("lblproductID");
             lblid.innerHTML = txtid.value;
         }


     </script>
--%>


</asp:Content>
