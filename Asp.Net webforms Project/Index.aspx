<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Asp.Net_webforms_Project.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <div class="row d-flex flex-wrap justify-content-between">
            <asp:Repeater ID="RepeaterGuitar" runat="server" ItemType="Asp.Net_webforms_Project.Prodotto">
                <ItemTemplate>
                    <div class="col-sm-6 col-md-4">
                        <div class="card flex-row" style="width: 20rem;">
                            <asp:Image ID="ImmagineProdotto" runat="server" ImageUrl="<%# Item.Immagine %>" CssClass="Immagine" />
                            <div class="card-body d-flex flex-column justify-content-between">
                                <div>
                                    <h4 class="card-title"><%# Item.Nome %></h4>
                                </div>
                                <div>
                                    <h5><%# Item.Prezzo.ToString("c2") %></h5>
                                </div>
                                <div>
                                    <p class="card-text"><%# Item.Descrizione  %> </p>
                                </div>
                                <div><a href="Detail.aspx?idprodotto=<%# Item.IdProdotto %>" class="btn btn-primary">Vai ai dettagli</a></div>

                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
