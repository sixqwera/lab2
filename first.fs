open System

let rec getlist() = 
    let s = Console.ReadLine()
    if String.IsNullOrWhiteSpace(s) then 
        []
    else 
        if Char.IsDigit(s.[0]) then 
            let n = int s 
            n :: getlist()
        else
            printfn "Ошибка, букв не должно быть" 
            getlist()

let toBin(n: int) = Convert.ToString(n, 2)

[<EntryPoint>]
let main argv = 
    printfn "Вводите числа:"
    
    let numbers = getlist()
    let aftertoBin = numbers |> List.map toBin

    printfn "Числа %A" numbers
    printfn "Двоичная запись чисел %A" aftertoBin

    0
