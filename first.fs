open System

let toBin(n: int) = Convert.ToString(n,2)

[<EntryPoint>]
let main argv = 
    let numbers = [1; 2; 3; 4; 5; 6; 7; 8; 9;]
    let after_toBin = numbers  |> List.map toBin

    printfn "Числа %A" numbers
    printfn "Двоичная запись чисел %A" after_toBin

    0
