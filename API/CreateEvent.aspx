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
                    <div>
                        <span>Event Name:</span>
                        <span>
                            <asp:TextBox runat="server" ID="EventName" Text="<%# BindItem.Name %>" />
                        </span>
                    </div>
                    <div>
                        <span>Description</span>
                        <span>
                            <asp:TextBox runat="server" ID="EventDescription" Text="<%# BindItem.Description %>" />
                        </span>
                    </div>
                    <div>
                        <span>Type of Event</span>
                        <span>
                            <asp:DropDownList ID="DropDownList1" runat="server" >
                                <asp:ListItem Text="Meal" />
                                <asp:ListItem Text="Movie" />
                            </asp:DropDownList>
                        </span>
                    </div>
                    <div>
                        <span>Venue</span>
                        <span>
                            <asp:TextBox runat="server" ID="EventVenue" Text="<%# BindItem.Venue %>"/>
                        </span>
                    </div>
                    <div>
                        <span>Duration (Hours)</span>
                        <span>
                            <asp:TextBox runat="server" ID="EventDuration" Text="<%# BindItem.Duration %>"/>
                        </span>
                    </div>
                    <div>
                        <span>Tentative Date:</span>
                        <span>
                            <asp:TextBox ID="EventDate" runat="server" Text="<%# BindItem.TentativeDate %>"></asp:TextBox>
                            <juice:Datepicker runat="server" TargetControlID="EventDate"></juice:Datepicker>
                        </span>
                    </div>
                    <div>
                        <span>Estimated Cost</span>
                        <span>
                            <asp:TextBox runat="server" ID="EventCost" Text="<%# BindItem.Cost %>"/>
                        </span>
                    </div>
                    <div>
                        <asp:Button ID="Button1" Text="Submit" runat="server" CommandName="Insert" />
                    </div>
                </InsertItemTemplate>
            </asp:FormView>
        </div>
    </form>
</body>
</html>
