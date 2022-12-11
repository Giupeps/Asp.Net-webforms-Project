<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="Asp.Net_webforms_Project.Detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container mt-5 mx-auto">
        <div class="row mx-auto">
            <div class="img-container col-6 text-center">
                <asp:Image ID="immagineProdotto" CssClass="w-25" runat="server" />
            </div>
            <div class="col-6 d-flex flex-column justify-content-between">
                <h1 id="titolo" runat="server" class="fw-bolder"></h1>
                <p id="descrizione" class="fs-4" runat="server"></p>
                <p id="prezzo" class="fs-3 fw-bolder" runat="server"></p>
                <asp:Button CssClass="btn btn-primary w-50 py-3 text-uppercase fw-bold" ID="Carrellobtn" runat="server" Text="Aggiungi al Carrello" OnClick="AggiungiCarrello" />
            </div>
        </div>
    </div>

</asp:Content>
