<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <table>
                <tr><td>Student Name<asp:TextBox ID="StudentName" runat="server"></asp:TextBox></td> </tr>
                <tr><td>Student Age<asp:TextBox ID="Studentage" runat="server"></asp:TextBox></td> </tr>
                <tr><td>EmailId <asp:TextBox ID="emailId" runat="server"></asp:TextBox></td> </tr>
                <tr><td>Password<asp:TextBox ID="password" runat="server"></asp:TextBox></td> </tr>
                <tr><td>Contact Number<asp:TextBox ID="contactnumber" runat="server"></asp:TextBox></td> </tr>
                <tr><td> Department<asp:TextBox ID="Department" runat="server"></asp:TextBox></td></tr>
                <tr><td><asp:Button ID="Insert" runat="server" Text="Insert" OnClick="Insert_Click"/></td></tr>
                <tr><td><asp:Button ID="Update" runat="server" Text="Update" OnClick="Update_Click"/></td></tr>
                <tr><td><asp:Button ID="Delete" runat="server" Text="Delete" OnClick="Delete_Click"/></td></tr>
                <tr><td><asp:Button ID="Read" runat="server" Text="Read" Onclick="Read_Click"/></td></tr>
               <tr><td><asp:Label ID="Message" runat="server" Text="Message"></asp:Label></td></tr>



               <tr><td><asp:GridView ID="GridView1" runat="server"></asp:GridView></td></tr>

             </table>
        </div>
   </form>
</body>
</html>
