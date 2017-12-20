<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Zuni.FrontEnd._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<asp:Repeater ID="rptViewCart" runat="server">
                            <ItemTemplate>
                                        <div>
                                            <div class="image">
                                                    <asp:ImageButton ID="ImageButton1" runat="server" CommandArgument='<%# Eval("ProductID") %>' CommandName="Add" ImageUrl='<%# Eval("ImageFilenameOverride") %>'
                                                            AlternateText='<%# Eval("Name") %>' style="width:180px; height:250px" Width="180px" Height="250px"  />
                                            <div class="name">
                                                    <%# Eval("Name") %></div>
                                            <div class="price">
                                                <span class="price-new">$<%# String.Format("{0:f2}", Eval("Profitpriceinrupee"))%></span><br /><%--<span class="price-tax">Ex Tax: $<%# Eval("Profitpriceindollar") %></span>--%></div>
                                                
                                                <div align="left">
                                                <asp:Button ID="btn" runat="server" CommandArgument='<%# Eval("ProductID") %>' CommandName="Add" class="button" Text="Add to Cart" />
                                                </div>
                                        </div>
                            </ItemTemplate>
                            <FooterTemplate>
                            </FooterTemplate>
                        </asp:Repeater>  
            
</asp:Content>
