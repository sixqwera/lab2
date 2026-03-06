open System

let rec getlist() = 
    let s = Console.ReadLine()
    if String.IsNullOrWhiteSpace(s) then
        []
    else
        if s.Length = 1 && Char.IsDigit(s.[0]) then
            let n = int s 
            n :: getlist()
        else
            printfn "Ошибка!"
            getlist() 

let rus_words n = 
    match n with

    | 0 -> "ноль" 
    | 1 -> "один" 
    | 2 -> "два" 
    | 3 -> "три"   
    | 4 -> "четыре" 
    | 5 -> "пять" 
    | 6 -> "шесть" 
    | 7 -> "семь" 
    | 8 -> "восемь" 
    | 9 -> "девять"
    | _ -> "???"

[<EntryPoint>]
let main argv = 
    printfn "Вводите цифры:"
    let myList = getlist()

    let resultString = 
        myList 

        |> List.map rus_words 
        |> List.fold (fun all word -> all + " " + word) ""

    printfn "Ваш список: %A" myList
    printfn "Результат через fold: %s" resultString

    0
