<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="salesOrder.aspx.vb" Inherits="Bulaale_Super_market.salesOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid m-0 backgroundSawir" style="height:900px;">
       
        <div class="row mt-3">
                    <div class="col-12">
                 <h1 style="font-family:Tahoma;font-weight:bold;font-size:40px; text-align:center">Customer Details</h1>
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
                                                 <asp:Button ID="btnSearch" CssClass="btn btn-success" runat="server" Text="Search" />
                                             </td>
                                            
                                         </tr>
                                        </table>
                                     </div>
                                      

                                   <div class="col-4">
                                          <table>
                                        <tr>
                                             <td>
                                                 <asp:Label ID="Label1" runat="server" Text="TotalBalance : " Font-Bold="True" Font-Size="16pt"></asp:Label>
                                             </td>
                                             <td>
                                                  <asp:Label ID="lblBalance" runat="server" Text="0.00" Font-Bold="True" Font-Size="16pt"></asp:Label>
                                             </td>
                                            
                                         </tr>
                                        </table>
                                     </div>
                             

                                 <div class="col-4 text-right ml-0">
                                     <asp:Button ID="btnRefresh" CssClass="btn btn-primary" runat="server" Text="Refresh" />
                                 </div>

                            </div>
                         </div>

                         <div class="card-body">
                          <div>
                                 <div class="col-9 mr-0">
                                     <asp:GridView ID="GridView1" runat="server"  AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1620px">
                                         <AlternatingRowStyle BackColor="White" />
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
