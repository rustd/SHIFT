<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Events.aspx.cs" Inherits="API.Events" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.7.1.js"></script>
    <script>
        $(function () {
            $.getJSON(
                "api/Events",
                function (data) {
                    $.each(data,
                        function (index, value) {
                            $("#EventDetail").append("<tr>");
                            $("#EventDetail").append("<td>" + value.Name + "</td>");
                            $("#EventDetail").append("<td>" + value.Description + "</td>");
                            $("#EventDetail").append("<td>" + value.Genre + "</td>");
                            $("#EventDetail").append("<td>" + value.TentativeDate + "</td>");
                            $("#EventDetail").append("<td>" + value.Status + "</td>");
                            $("#EventDetail").append("</tr>");
                        });
                }
                    );
        }
            );
    </script>
</head>
<body>

    <div>
        <h2>Welcome to the events page </h2>
        <h3>Below is the list of the currently suggested events</h3>
        <div>
            <table id="EventList">
                <thead id="EventTitle">
                    <tr>
                        <td>Name</td>
                        <td>Description</td>
                        <td>Genre</td>
                        <td>TentativeDate</td>
                        <td>Status</td>
                    </tr>
                </thead>
                <tbody id="EventDetail">
                </tbody>
            </table>
        </div>
    </div>
</body>
</html>
