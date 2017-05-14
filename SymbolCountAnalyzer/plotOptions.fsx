

let plot x y title xTitle yTitle = 
    let styledTrace =
        Bar(
            x = x,
            y = y,
            name = "Statistics",
            marker = Marker(color = "rgb(55, 83, 109)")
        )


    let styledLayout =
        Layout(
            title = title,
            xaxis =
                Xaxis(
                    tickfont =
                        Font(
                            size = 14.,
                            color = "rgb(107, 107, 107)"
                        ),
                title = xTitle
                    
                ),
            yaxis =
                Yaxis(
                    title = yTitle,
                    titlefont =
                        Font(
                            size = 16.,
                            color = "rgb(107, 107, 107)"
                        ),
                    tickfont =
                        Font(
                            size = 14.,
                            color = "rgb(107, 107, 107)"
                        )
                ),
            legend =
                Legend(
                    x = 0.,
                    y = 1.0,
                    bgcolor = "rgba(255, 255, 255, 0)",
                    bordercolor = "rgba(255, 255, 255, 0)"
                ),
            barmode = "group",
            bargap = 0.15,
            bargroupgap = 0.1
        )

    [styledTrace]
    |> Chart.Plot
    |> Chart.WithLayout styledLayout
    |> Chart.WithHeight 600
    |> Chart.WithWidth 800