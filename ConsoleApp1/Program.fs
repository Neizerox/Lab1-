open System

//Номер 1


let listFunctions = 
    let assembly = typeof<List<int>>.Assembly
    let moduleType = assembly.GetType("Microsoft.FSharp.Collections.ListModule")
    
    moduleType.GetMethods()
    |> Array.map (fun method -> method.Name)
    |> Array.distinct
    |> Array.sort
    |> Array.toList

[<EntryPoint>]
let main argv =
    printfn "Список функций модуля List:"
    listFunctions |> List.iter (printf "%A, ")
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
//Номер 3 
(*

// Тип для комплексного числа
type MyComplex = { Re: float; Im: float }

//Математические операции
let add z1 z2 = 
    { Re = z1.Re + z2.Re; Im = z1.Im + z2.Im }

let sub z1 z2 = 
    { Re = z1.Re - z2.Re; Im = z1.Im - z2.Im }

let mul z1 z2 = 
    { Re = z1.Re * z2.Re - z1.Im * z2.Im
      Im = z1.Re * z2.Im + z1.Im * z2.Re }

let div z1 z2 = 
    let denom = z2.Re ** 2.0 + z2.Im ** 2.0
    if denom = 0.0 then 
        printfn "\n!!! ОШИБКА"
        { Re = 0.0; Im = 0.0 } // Возвращаем ноль
    else
        { Re = (z1.Re * z2.Re + z1.Im * z2.Im) / denom
          Im = (z1.Im * z2.Re - z1.Re * z2.Im) / denom }

// Формула для возведения в степень n
let pow z (n: float) =
    let r = sqrt (z.Re ** 2.0 + z.Im ** 2.0)
    let theta = atan2 z.Im z.Re
    let rn = r ** n
    { Re = rn * cos (n * theta); Im = rn * sin (n * theta) }

// Вывод
let toString z = sprintf "%.2f + %.2fi" z.Re z.Im

[<EntryPoint>]
let main argv =
    printfn "Ввод комплексных чисел (a + bi)"
    
    // Запрос первого числа
    printf "Введите вещественную часть z1 (a): "
    let re1 = float (Console.ReadLine())
    printf "Введите мнимую часть z1 (b): "
    let im1 = float (Console.ReadLine())
    let z1 = { Re = re1; Im = im1 }

    // Запрос второго числа
    printf "\nВведите вещественную часть z2 (c): "
    let re2 = float (Console.ReadLine())
    printf "Введите мнимую часть z2 (d): "
    let im2 = float (Console.ReadLine())
    let z2 = { Re = re2; Im = im2 }

    // Запрос степени
    printf "\nВ какую степень возвести первое число? "
    let n = float (Console.ReadLine())

    printfn "z1 = %s" (toString z1)
    printfn "z2 = %s" (toString z2)
    printfn "Сложение:    %s" (toString (add z1 z2))
    printfn "Вычитание:   %s" (toString (sub z1 z2))
    printfn "Умножение:   %s" (toString (mul z1 z2))
    printfn "Деление:     %s" (toString (div z1 z2))
    printfn "z1 в степени %.0f: %s" n (toString (pow z1 n))

    0


*)

