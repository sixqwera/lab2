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
            printfn "Ошибка: введена не цифра или больше одного символа! Иди нафиг."
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
    printfn "Вводите цифры по одной (после каждой Enter). Чтобы закончить, просто нажмите Enter еще раз:"
    
    let myList = getlist()

    let words = myList |> List.map rus_words
    
    printfn "Ваш список чисел: %A" myList
    printfn "Результат: «%A»" words

    0




