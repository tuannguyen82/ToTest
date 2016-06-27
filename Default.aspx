<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <table width="100%">
        <tr>
            <td style="width:30%"></td>
            <td></td>
            <td style="width:30%"></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <form id="frmLogin" runat="server">
                <table width="100%">
                    <tr align="center">
                        <asp:Label ID="Label3" runat="server" Text="Đăng nhập hệ thống"></asp:Label></tr>
                    <tr>
                        <td style="width:20%">
                            <asp:Label ID="Label1" runat="server" Text="Tài khoản"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtUsername" runat="server" Width="100%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Mật khẩu"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtPassword" runat="server" Width="100%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="btnDangnhap" runat="server" Text="Đăng nhập" OnClick="btnDangnhap_Click" /></td>
                    </tr>
                </table>
                </form>
            </td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Label ID="lblSQL" runat="server"></asp:Label></td>
            <td></td>
        </tr>
    </table>
</body>
</html>
