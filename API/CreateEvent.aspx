<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateEvent.aspx.cs" Inherits="API.CreateEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" />

        <div>
            <asp:FormView ID="FormView1" runat="server" ItemType="DAL.Event" InsertMethod="FormView1_InsertItem" DefaultMode="Insert">
                <InsertItemTemplate>
                    <table>
                        <tr>
                            <td>Name</td>
                            <td>
                                <asp:TextBox runat="server" ID="EventName" Text="<%# BindItem.Name %>" />
                            </td>
                        </tr>
                        <tr>
                            <td>Tentative Date:
                            </td>
                            <td>
                                <asp:TextBox ID="EventDate" runat="server" Text="<%# BindItem.TentativeDate %>"></asp:TextBox>
                                <juice:Datepicker runat="server" TargetControlID="EventDate"></juice:Datepicker>
                            </td>
                        </tr>
                        <%--                        <tr>
                            <td>
                                Genre:
                            </td>
                            <td>
                                <asp:DropDownList runat="server" DataSource=""> 
                                    <asp:ListItem Text="text1" />
                                    <asp:ListItem Text="text2" />
                                </asp:DropDownList>
                            </td>
                        </tr>--%>
                    </table>
                    <asp:Button Text="Submit" runat="server" CommandName="Insert" />
                </InsertItemTemplate>
            </asp:FormView>
        </div>
    </form>
</body>
</html>
