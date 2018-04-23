@Code
    ViewData("Title") = "Index"
End Code

@Html.DevExpress().Chart(Sub(settings)
                                  ' Specify obligatory properties of the chart control.
                                  settings.Name = "chart"

                                  ' Customize the chart appearance.
                                  settings.Width = 640
                                  settings.Height = 360
                                  settings.AppearanceName = "Gray"
                                  settings.PaletteName = "Office 2013"

                                  ' Add a New series to the series collection.
                                  settings.Series.Add(Sub(s)
                                                          s.Name = "1998"
                                                          ' Configure the series appearance.
                                                          s.Views().SideBySideBarSeriesView(Sub(v)
                                                                                                v.FillStyle.FillMode = FillMode.Solid
                                                                                            End Sub)
                                                          ' Manually populate series with points.
                                                          s.Points.AddPoint("Illinois", 423.721)
                                                          s.Points.AddPoint("Indiana", 178.719)
                                                          s.Points.AddPoint("Michigan", 308.845)
                                                          s.Points.AddPoint("Ohio", 348.555)
                                                          s.Points.AddPoint("Wisconsin", 160.274)
                                                      End Sub)

                                  settings.Series.Add(Sub(s)
                                                          s.Name = "2001"

                                                          s.Views().SideBySideBarSeriesView(Sub(v)
                                                                                                v.FillStyle.FillMode = FillMode.Solid
                                                                                            End Sub)

                                                          s.Points.AddPoint("Illinois", 476.851)
                                                          s.Points.AddPoint("Indiana", 195.769)
                                                          s.Points.AddPoint("Michigan", 335.793)
                                                          s.Points.AddPoint("Ohio", 374.771)
                                                          s.Points.AddPoint("Wisconsin", 182.373)
                                                      End Sub)

                                  settings.Series.Add(Sub(s)
                                                          s.Name = "2004"

                                                          s.Views().SideBySideBarSeriesView(Sub(v)
                                                                                                v.FillStyle.FillMode = FillMode.Solid
                                                                                            End Sub)

                                                          s.Points.AddPoint("Illinois", 528.904)
                                                          s.Points.AddPoint("Indiana", 227.271)
                                                          s.Points.AddPoint("Michigan", 372.576)
                                                          s.Points.AddPoint("Ohio", 418.258)
                                                          s.Points.AddPoint("Wisconsin", 211.727)
                                                      End Sub)

                                  ' Add title to the chart.
                                  settings.Titles.Add(Sub(t)
                                                          t.Text = "Great Lakes gross state product"
                                                      End Sub)

                                  ' Customize the chart diagram.
                                  settings.XYDiagram(Sub(d)
                                                         d.AxisY.Title.Text = "Millions of USD"
                                                         d.AxisY.Title.Visibility = DefaultBoolean.True
                                                     End Sub)
                              End Sub).GetHtml()