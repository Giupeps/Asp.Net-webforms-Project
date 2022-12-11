<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="Asp.Net_webforms_Project.Carrello" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5" ID="ContenitoreCarrello" runat="server" >
    <asp:GridView ID="GrigliaCarrello" runat="server" Visible="true" AutoGenerateColumns="false" ItemType="Asp.Net_webforms_Project.Prodotto" CssClass="table table-striped">
        <Columns>
            <asp:TemplateField HeaderText="Nome Prodotto">
                <ItemTemplate>
                    <asp:Label ID="NomeProdotto" runat="server" Text="<%# Item.Nome %>"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Prezzo Prodotto">
                <ItemTemplate>
                    <asp:Label ID="PrezzoProdotto" runat="server" Text="<%# Item.Prezzo %>"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>              
        </Columns>
    </asp:GridView>
        
        <div class="d-flex justify-content-between mt-4">
        <div>
        <h3>Totale</h3>
        <asp:Label ID="Totale" runat="server" Text=""></asp:Label>
        </div>
        <asp:Button ID="Delete" runat="server" Text="Svuota Carrello" CssClass="btn text-white" OnClick="Svuota" />
        </div>
        </div>

    
</asp:Content>
