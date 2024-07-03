<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="_3_7_2024.Calculator" %>

<!DOCTYPE html>
<link href="calc.css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Result: "></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Width="50px"></asp:TextBox>

            <br />
            <br />
            
            <asp:Label ID="Label3" runat="server" Text="Number1: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

            <br />
            <br />
            
            <asp:Label ID="Label4" runat="server" Text="Number1: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
           
            <asp:Button Text="+" ID="Button1" runat="server" Color="#FFCC00" Width="100px" Height="50px" BackColor="Green" Style="text-align: center; ; font-weight:Bold; display:inline-block"  OnClick="Button1_Click"/>
             <asp:Button Text="-" ID="Button2" runat="server" Color="#FFCC00" Width="100px" Height="50px"  BackColor="#FFC107" Style="text-align: center; ; font-weight:Bold; display:inline-block"  OnClick="Button2_Click"/>
             <asp:Button Text="*" ID="Button3" runat="server" Color="#FFCC00" Width="100px" Height="50px" BackColor="Green" Style="text-align: center; ; font-weight:Bold; display:inline-block"    OnClick="Button3_Click"/>
             <asp:Button Text="/" ID="Button4" runat="server" Color="#FFCC00" Width="100px" Height="50px"  BackColor="#FFC107" Style="text-align: center; ; font-weight:Bold; display:inline-block"   OnClick="Button4_Click"/>
        </div>
    </form>
</body>
</html>
