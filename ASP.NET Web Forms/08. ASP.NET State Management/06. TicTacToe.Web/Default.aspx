<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_06.TicTacToe.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <h1 class="text-center">Welcome to TicTacToe Online Game</h1>
    <div class="row jumbotron">
        <p>
            Tic-tac-toe is a fun game that you can play any time and anywhere as long as you have a piece of paper,
            a pencil, and an opponent. Tic-tac-toe is a zero sum game, which means that if both players are playing
            their best, that neither player will win. However, if you learn how to play tic-tac-toe and master some simple strategies,
            then you'll be able to not only play, but to win the majority of the time.
        </p>
        <h2 class="text-center">Game rules</h2>
        <p>The game is played on a grid that's 3 squares by 3 squares. You are <b>X</b>, your friend is <b>O</b>. Players take turns putting their marks in empty squares of 3X3 board.
        <p>The first player to get 3 of her marks in a row (up, down, across, or diagonally) is the winner. </p>
        <p>When all 9 squares are full, the game is over. If no player has 3 marks in a row, the game ends in a tie. </p>
        <div class="image-container col-xs-6 col-md-offset-3 text-center">
            <img class="img-rounded" src="/resources/images/tictactoe.jpg" />
        </div>
    </div>


</asp:Content>
