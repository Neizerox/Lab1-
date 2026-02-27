open System

//Номер 1
[<EntryPoint>]
let main argv =
    
    let listFunctions = 
        [
        "List.empty"; "List.singleton"; "List.init"; 
        "List.iter"; "List.iteri"; "List.fold"; 
        "List.exists"; "List.tryFind"; "List.filter"; 
        "List.map"; "List.sort"; "List.takeWhile"
        ]
    printfn "Список модулей list: %A" listFunctions
    0
//Номер 2
(*
let rec checkEvenDigits n =
    if n = 0 then true
    else
        let lastDigit = n % 10 
        if lastDigit % 2 <> 0 then 
            false 
        else 
            checkEvenDigits (n / 10) 

[<EntryPoint>]
let main argv =
    printf "Введите число\n"
    let number = int(Console.ReadLine())
    printfn "Результат для %d: %b" number (checkEvenDigits number)
    0

*)




