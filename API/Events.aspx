<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Events.aspx.cs" Inherits="API.Events" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.7.2.js"></script>
    <script src="Scripts/jQuery.tmpl.js"></script>
    <script>
        $(function () {
            $.getJSON(
                "api/Events",
                function (data) {
                    $.each(data,
                        function (index, value) {
                            $("#bookTemplate").tmpl(value).appendTo("#books");
                        }
                    );
                }
            );
        })
    </script>
</head>
<body>
    <%--    <form runat="server">
        <asp:GridView runat="server" ItemType="DAL.Event" SelectMethod="Unnamed_GetData">
        </asp:GridView>
        <asp:GridView runat="server" ID="foo">
        </asp:GridView>
    </form>--%>

    <div>
        <script id="bookTemplate" type="text/html">
            <li>Event Name: ${ Name }
                  Genre:${ Genre }  
            </li>
        </script>
        <div class="grid_8 omega">
            <ul class="books" id="books">
            </ul>
        </div>
    </div>
</body>
</html>
