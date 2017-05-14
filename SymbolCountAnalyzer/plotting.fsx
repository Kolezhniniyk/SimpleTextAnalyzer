
//tables
open XPlot.GoogleCharts
[oneLetterData]        
|> Chart.Table
|> Chart.WithTitle "Monogram"
|> Chart.WithOptions(Options(showRowNumber = true))
|> Chart.WithLabels ["Symbol"; "Frequency"]

[sortedLetter]        
|> Chart.Table
|> Chart.WithOptions(Options(showRowNumber = true))
|> Chart.WithLabels ["Symbol"; "Frequency"]

[bigram]     
|> Chart.Table
|> Chart.WithOptions(Options(showRowNumber = true))
|> Chart.WithLabels ["Bigram"; "Frequency"]

[sortedBigram]     
|> Chart.Table
|> Chart.WithOptions(Options(showRowNumber = true))
|> Chart.WithLabels ["Bigram"; "Frequency"]

[trigram]       
|> Chart.Table
|> Chart.WithOptions(Options(showRowNumber = true))
|> Chart.WithLabels ["Trigram"; "Frequency"]

[sortedTrigram]       
|> Chart.Table
|> Chart.WithOptions(Options(showRowNumber = true))
|> Chart.WithLabels ["Trigram"; "Frequency"]



open XPlot.Plotly
plot (x oneLetterData) (y oneLetterData) "Letter Statistic" "Letter" "Count"

plot (x sortedLetter) (y sortedLetter) "Letter Statistic Sorted" "Letter" "Count"

plot (x bigram) (y bigram) "Bigram Statistic" "Bigram" "Count"

plot (x sortedBigram) (y sortedBigram) "Sorted Bigram Statistic" "Bigram" "Count"

plot (x trigram) (y trigram) "Trigram Statistic" "Trigram" "Count"

plot (x sortedTrigram) (y sortedTrigram) "Sorted Trigram Statistic" "Trigram" "Count"



