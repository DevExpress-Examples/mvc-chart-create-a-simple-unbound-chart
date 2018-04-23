﻿<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Html.DevExpress().GetStyleSheets(
                                            New StyleSheet With {.ExtensionSuite = ExtensionSuite.Chart}
                                        )
    @Html.DevExpress().GetScripts(
                                New Script With {.ExtensionSuite = ExtensionSuite.Chart}
                            )
</head>
<body>
    @RenderBody()
</body>
</html>
