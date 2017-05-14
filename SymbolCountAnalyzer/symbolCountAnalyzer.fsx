
#load "..\packages/FsLab/FsLab.fsx"
open System.Text.RegularExpressions
open System.IO
open System.Text 
let filepath = @"file1.txt"//@"file2.txt"
let alphabet = [   "а"; "б"; "в"; "г"; "ґ"; "д"; "е"; "є"; "ж"; "з"; "и"; "і"; "ї"; 
"й"; "к"; "л"; "м"; "н"; "о"; "п"; "р"; "с"; "т"; "у"; "ф"; "х"; "ц"; "ч"; "ш"; "щ"; "ь"; "ю"; "я"; " " ]
let cartesian xs ys = xs |> List.collect (fun x -> 
    ys |> List.map (fun y -> x +  y))
let letterCount (text:string) (word:string) =  Regex.Matches(text, Regex.Escape word, RegexOptions.IgnoreCase).Count
let obtainText text alphabet =  alphabet |> List.map(fun l -> (l, letterCount text l) )                                
let sort list = list |> List.sortBy (fun (_, y) -> -y)                              
let alphabetSorted filePAth alphabet = obtainText (filePAth |> File.ReadAllText) alphabet

let oneLetterData = alphabetSorted filepath alphabet

let bigram = (alphabet,alphabet) ||> cartesian |> alphabetSorted filepath |> List.filter(fun elem -> snd(elem) >=1)
let trigram = (alphabet, alphabet) 
            ||> cartesian 
            |> cartesian alphabet 
            |> alphabetSorted filepath 
            |> List.filter(fun e -> snd(e) >=1)
            |> List.take 50
let sortedLetter = oneLetterData |> sort
let sortedBigram = bigram |> sort |> List.take 30
let sortedTrigram = trigram |> sort |> List.take 30
let x data = data |> List.map(fun x -> fst x)
let y data = data |> List.map(fun x -> snd x)