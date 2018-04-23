@ModelType System.Data.DataTable

@Html.DevExpress().GridView(
    Sub(settings)
            settings.Name = "grid"
            settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "GridAction"}
            settings.KeyFieldName = "CustomerID"
            settings.DataBound = Sub(sender, e)
                                         Dim grid As MVCxGridView = TryCast(sender, MVCxGridView)
                                         If grid.Columns.IndexOf(grid.Columns("CommandColumn")) <> -1 Then
                                             Return
                                         End If
                                         Dim col As GridViewCommandColumn = New GridViewCommandColumn()
                                         col.Name = "CommandColumn"
                                         col.ShowSelectCheckbox = True
                                         col.VisibleIndex = 0
                                         grid.Columns.Add(col)
                                 End Sub
    End Sub).Bind(Model).GetHtml()