@Code
    ViewBag.Title = "Index"
End Code

@Html.DevExpress().Chart(Function(settings)
                                  ' Specify obligatory properties of the chart control.
                                  settings.Name = "chart"


                                  ' Customize the chart appearance.
                                  settings.Width = 640
                                  settings.Height = 360
                                  settings.AppearanceName = "Gray"
                                  settings.PaletteName = "Office 2013"

                                  ' Create a series.
                                  Dim series1998 As Series = New Series With {.Name = "1998"}
                                  ' Customize the series view.
                                  Dim View As SideBySideBarSeriesView = TryCast(series1998.View, SideBySideBarSeriesView)
                                  If (View IsNot Nothing) Then
                                      View.FillStyle.FillMode = FillMode.Solid
                                  End If
                                  ' Populate the series with data.
                                  series1998.Points.Add(New SeriesPoint("Illinois", 423.721))
                                  series1998.Points.Add(New SeriesPoint("Indiana", 178.719))
                                  series1998.Points.Add(New SeriesPoint("Michigan", 308.845))
                                  series1998.Points.Add(New SeriesPoint("Ohio", 348.555))
                                  series1998.Points.Add(New SeriesPoint("Wisconsin", 160.274))
                                  ' Add series to the series collection.
                                  settings.Series.Add(series1998)

                                  Dim series2001 As Series = New Series() With {.Name = "2001"}
                                  View = TryCast(series2001.View, SideBySideBarSeriesView)
                                  If (View IsNot Nothing) Then
                                      View.FillStyle.FillMode = FillMode.Solid
                                  End If
                                  series2001.Points.Add(New SeriesPoint("Illinois", 476.851))
                                  series2001.Points.Add(New SeriesPoint("Indiana", 195.769))
                                  series2001.Points.Add(New SeriesPoint("Michigan", 335.793))
                                  series2001.Points.Add(New SeriesPoint("Ohio", 374.771))
                                  series2001.Points.Add(New SeriesPoint("Wisconsin", 182.373))
                                  settings.Series.Add(series2001)

                                  Dim series2004 As Series = New Series() With {.Name = "2004"}
                                  View = TryCast(series2004.View, SideBySideBarSeriesView)
                                  If (View IsNot Nothing) Then
                                      View.FillStyle.FillMode = FillMode.Solid
                                  End If
                                  series2004.Points.Add(New SeriesPoint("Illinois", 528.904))
                                  series2004.Points.Add(New SeriesPoint("Indiana", 227.271))
                                  series2004.Points.Add(New SeriesPoint("Michigan", 372.576))
                                  series2004.Points.Add(New SeriesPoint("Ohio", 418.258))
                                  series2004.Points.Add(New SeriesPoint("Wisconsin", 211.727))
                                  settings.Series.Add(series2004)

                                  ' Add title to the chart.
                                  settings.Titles.Add(New ChartTitle() With {.Text = "Great Lakes gross state product"})

                                  ' Customize the chart diagram.
                                  Dim diagram As XYDiagram = TryCast(settings.Diagram, XYDiagram)
                                  If (diagram IsNot Nothing) Then
                                      diagram.AxisY.Title.Text = "Millions of USD"
                                      diagram.AxisY.Title.Visibility = DefaultBoolean.True
                                  End If
                                  Return settings
                              End Function).GetHtml()