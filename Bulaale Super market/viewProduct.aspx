<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="viewProduct.aspx.vb" Inherits="Bulaale_Super_market.viewProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 130%;
        }
        .auto-style2 {
            display: block;
            width: 130%;
        }
        .auto-style3 {
            margin-top: 12;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="height:2000px">
       <div class="row">

          <div class="col-4 mx-auto">
               <div class="card">
                   <img class="card-img-top" src="imgs/m.png" alt="Floor" style="width:100%;height:390px;">
                   <div class="card-body">
                       <div class="row">
                           <div class="col-12">
                                <label>ProductID</label>
                               <div class="form-group">
                                   <asp:TextBox class="form-control" ID="txtMeatProductID" runat="server"  placeholder="ProductID"   Enabled="False"></asp:TextBox>
                               </div>
                           </div>
                              
                       </div>

                        <div class="row">
                           <div class="col-md-6">
                                <label style="font-size: 16px; font-weight: bold">Meat</label>
                               <div class="form-group">
                                  <asp:DropDownList CssClass="form-control" ID="DropDownListMeat" runat="server" AutoPostBack="True">
                                       <asp:ListItem Text="Select" Value="select" />
                            
                                   </asp:DropDownList>
                               </div>
                           </div>
                               <div class="col-md-6">
                                <label>Price</label>
                               <div class="form-group">
                                      <asp:TextBox class="form-control" ID="txtmeatprice" runat="server" placeholder="Price" Enabled="False" Font-Size="16pt"></asp:TextBox>
                               </div>
                           </div>
                       </div>
                       <div class="row">
                           <div class="col-12">
                                <label>Quantity  <label>Quantity</label>
                               <div class="form-group">
                                   <asp:TextBox class="form-control" ID="txtmeatquantity" runat="server" placeholder="Quantity"  AutoPostBack="True" TextMode="Number"></asp:TextBox>
                               </div>
                           </div>
                              
                       </div>
                      
                         <div class="row">
                           <div class="col-12 p-3">
                                <label>Amount</label>
                               <div class="form-group">
                                   <asp:TextBox class="form-control" ID="txtmeatamount" runat="server" placeholder="Amount" AutoPostBack="True" Enabled="False" Width="100%" Height="50%" Font-Bold="True" Font-Size="20"></asp:TextBox>
                               </div>
                           </div>
                              
                       </div>
                      
                       
                       <div class="row">
                           <div class="col">
                              <div class="form-group">
                                   <asp:Button CssClass="btn btn-success btn-block btn-lg" ID="btnmeatBuy" runat="server" Text="Buy" />
                               </div>
                           </div>
                   </div>
       
                </div>
       
            </div>
       
          </div>









                 <div class="col-4 mx-auto">
               <div class="card">
                   <img class="card-img-top" src="imgs/r3.png" alt="Floor" style="width:100%;height:390px;">
                   <div class="card-body">
                        <div class="row">
                           <div class="col-12">
                                <label>ProductID</label>
                               <div class="form-group">
                                   <asp:TextBox class="form-control" ID="txtChickenProductID" runat="server" placeholder="ProductID"   Enabled="False"  ></asp:TextBox>
                               </div>
                           </div>
                              
                       </div>

                        <div class="row">
                           <div class="col-md-6">
                                <label style="font-size: 16px; font-weight: bold">Chickens</label>
                               <div class="form-group">
                                  <asp:DropDownList CssClass="form-control" ID="DropDownListChicken" runat="server" AutoPostBack="True">
                                       <asp:ListItem Text="Select" Value="select" />
                            
                                   </asp:DropDownList>
                               </div>
                           </div>
                               <div class="col-md-6">
                                <label>Price</label>
                               <div class="form-group">
                                      <asp:TextBox class="form-control" ID="txtChickenPrice" runat="server" placeholder="Price"  Enabled="False" Font-Size="16pt"></asp:TextBox>
                               </div>
                           </div>
                       </div>
                       <div class="row">
                           <div class="col-12">
                                <label>Quantity</label>
                               <div class="form-group">
                                   <asp:TextBox class="form-control" ID="txtChickenQuantity" runat="server" placeholder="Quantity"  AutoPostBack="True" TextMode="Number"></asp:TextBox>
                               </div>
                           </div>
                              
                       </div>
                      
                         <div class="row">
                           <div class="col-12 p-3">
                                <label>Amount</label>
                               <div class="form-group">
                                   <asp:TextBox class="form-control" ID="txtChickenAmount" runat="server" placeholder="Amount"  AutoPostBack="True" Enabled="False" Width="100%" Height="50%" Font-Bold="True" Font-Size="20"></asp:TextBox>
                               </div>
                           </div>
                              
                       </div>
                      
                       
                       <div class="row">
                           <div class="col">
                              <div class="form-group">
                                   <asp:Button CssClass="btn btn-success btn-block btn-lg" ID="btnChickenBuy" runat="server" Text="Buy" />
                               </div>
                           </div>
                   </div>
       
                </div>
       
            </div>
       
          </div>






             <div class="col-4 mx-auto">
               <div class="card">
                   <img class="card-img-top" src="imgs/f.png" alt="Floor" style="width:100%;height:390px;">
                   <div class="card-body">
                       <div class="row">
                           <div class="col-12">
                                <label>ProductID</label>
                               <div class="form-group">
                                   <asp:TextBox class="form-control" ID="txtFishProductID" runat="server" placeholder="ProductID"   Enabled="False"  ></asp:TextBox>
                               </div>
                           </div>
                              
                       </div>

                        <div class="row">
                           <div class="col-md-6">
                                <label style="font-size: 16px; font-weight: bold">Fish</label>
                               <div class="form-group">
                                  <asp:DropDownList CssClass="form-control" ID="DropDownListFish" runat="server" AutoPostBack="True">
                                       <asp:ListItem Text="Select" Value="select" />
                            
                                   </asp:DropDownList>
                               </div>
                           </div>
                               <div class="col-md-6">
                                <label>Price</label>
                               <div class="form-group">
                                      <asp:TextBox class="form-control" ID="txtFishprice" runat="server" placeholder="Price"  Enabled="False" Font-Size="16pt"></asp:TextBox>
                               </div>
                           </div>
                       </div>
                       <div class="row">
                           <div class="col-12">
                                <label>Quantity</label>
                               <div class="form-group">
                                   <asp:TextBox class="form-control" ID="txtFishQuantity" runat="server" placeholder="Quantity" TextMode="Number" AutoPostBack="True"></asp:TextBox>
                               </div>
                           </div>
                              
                       </div>
                      
                         <div class="row">
                           <div class="col-12 p-3">
                                <label>Amount</label>
                               <div class="form-group">
                                   <asp:TextBox class="form-control" ID="txtFishamount" runat="server" placeholder="Amount" AutoPostBack="True" Enabled="False" Width="100%" Height="50%" Font-Bold="True" Font-Size="20"></asp:TextBox>
                               </div>
                           </div>
                              
                       </div>
                      
                       
                       <div class="row">
                           <div class="col">
                              <div class="form-group">
                                   <asp:Button CssClass="btn btn-success btn-block btn-lg" ID="btnFishBuy" runat="server" Text="Buy" />
                               </div>
                           </div>
                   </div>
       
                </div>
       
            </div>
       
          </div>







    </div>




        <div class="row">
            <h2> Drinks</h2>
        </div>







        <div class="row mt-3 text-center">

            
             <div class="col-4 mx-auto">
               <div class="card">
                   <img class="card-img-top" src="imgs/v2.png" alt="Floor" style="width:100%;height:390px;">
                   <div class="card-body">

                       <div class="row">
                           <div class="col-12">
                                <label>ProductID</label>
                               <div class="form-group">
                                   <asp:TextBox class="form-control" ID="txtVanillaProductID" runat="server" placeholder="ProductID"   Enabled="False"  ></asp:TextBox>
                               </div>
                           </div>
                              
                       </div>

                        <div class="row">
                           <div class="col-md-6">
                                <label style="font-size: 16px; font-weight: bold">Vanilla StrewBerry</labe>
                               <div class="form-group">
                                  <asp:DropDownList CssClass="form-control" ID="DropDownListVanilla" runat="server" AutoPostBack="True">
                                       <asp:ListItem Text="Select" Value="select" />
                            
                                   </asp:DropDownList>
                               </div>
                           </div>
                               <div class="col-md-6">
                                <label>Price</label>
                               <div class="form-group">
                                      <asp:TextBox class="form-control" ID="txtvanillaPrice" runat="server" placeholder="Price"  Enabled="False" Font-Size="16pt"></asp:TextBox>
                               </div>
                           </div>
                       </div>
                       <div class="row">
                           <div class="col-12">
                                <label>Quantity</label>
                               <div class="form-group">
                                   <asp:TextBox class="form-control" ID="txtvanillaQuantity" runat="server" placeholder="Quantity" TextMode="Number" AutoPostBack="True"></asp:TextBox>
                               </div>
                           </div>
                              
                       </div>
                      
                         <div class="row">
                           <div class="col-12 p-3">
                                <label>Amount</label>
                               <div class="form-group">
                                   <asp:TextBox class="form-control" ID="txtvanillaAmount" runat="server" placeholder="Amount" AutoPostBack="True" Enabled="False" Width="100%" Height="50%" Font-Bold="True" Font-Size="20"></asp:TextBox>
                               </div>
                           </div>
                              
                       </div>
                      
                       
                       <div class="row">
                           <div class="col">
                              <div class="form-group">
                                   <asp:Button CssClass="btn btn-success btn-block btn-lg" ID="btnvanillaBuy" runat="server" Text="Buy" />
                               </div>
                           </div>
                   </div>
       
                </div>
       
            </div>
       
          </div>




            
             <div class="col-4 mx-auto">
               <div class="card">
                   <img class="card-img-top" src="imgs/zz.png" alt="Floor" style="width:100%;height:390px;">
                   <div class="card-body">

                        <div class="row">
                           <div class="col-12">
                                <label>ProductID</label>
                               <div class="form-group">
                                   <asp:TextBox class="form-control" ID="txtDrinksProductID" runat="server" placeholder="ProductID"   Enabled="False" ></asp:TextBox>
                               </div>
                           </div>
                              
                       </div>

                        <div class="row">
                           <div class="col-md-6">
                                <label style="font-size: 16px; font-weight: bold">Normal Drinks</label>
                               <div class="form-group">
                                  <asp:DropDownList CssClass="form-control" ID="DropDownListDrinks" runat="server" AutoPostBack="True">
                                       <asp:ListItem Text="Select" Value="select" />
                            
                                   </asp:DropDownList>
                               </div>
                           </div>
                               <div class="col-md-6">
                                <label>Price</label>
                               <div class="form-group">
                                      <asp:TextBox class="form-control" ID="txtDrinkPrice" runat="server" placeholder="Price"  Enabled="False" Font-Size="16pt"></asp:TextBox>
                               </div>
                           </div>
                       </div>
                       <div class="row">
                           <div class="col-12">
                                <label>Quantity</label>
                               <div class="form-group">
                                   <asp:TextBox class="form-control" ID="txtDrinkQuantity" runat="server" placeholder="Quantity" TextMode="Number" AutoPostBack="True"></asp:TextBox>
                               </div>
                           </div>
                              
                       </div>
                      
                         <div class="row">
                           <div class="col-12 p-3">
                                <label>Amount</label>
                               <div class="form-group">
                                   <asp:TextBox class="form-control" ID="txtDrinkAmount" runat="server" placeholder="Amount"  AutoPostBack="True" Enabled="False" Width="100%" Height="50%" Font-Bold="True" Font-Size="20"></asp:TextBox>
                               </div>
                           </div>
                              
                       </div>
                      
                       
                       <div class="row">
                           <div class="col">
                              <div class="form-group">
                                   <asp:Button CssClass="btn btn-success btn-block btn-lg" ID="btnDrinkBuy" runat="server" Text=" Buy" />
                               </div>
                           </div>
                   </div>
       
                </div>
       
            </div>
       
          </div>


           






        </div>







    </div>
    </label>
    </label>
</asp:Content>
