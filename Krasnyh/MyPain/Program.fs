open System
open Microsoft.FSharp.Core

// let d = 2.54
// let n = 115.375
//
// let Meters x : int = 
//     int(x * d) / 100
//     
// let Santimeters x : int =
//     int(x * d) % 100
//     
// let Milimeters x : float =
//     x * d % 1. * 10.
//
// printf "%f дюйма = %i метра, %i сантиметра, %f миллиметра" n (Meters n) (Santimeters n) (Milimeters n)

// let x = 15
// printf "Введите число: "
// let x = int(Console.ReadLine())
//
// let a X =
//     [
//     for i in 1..x do
//         if i % 2 = 0
//         then yield i // yield - тип списка
//     ]    
//
// printf "Четные числа от 1 до %A: " (a x)

// let rec summ x : int =
//     if x = 0
//     then 0
//     else x % 10 + summ(x/10)
//     
// [<EntryPoint>]
// let main args =
//     printf "Введите число: "
//     let x = int(Console.ReadLine())
//     printf "Сумма цифр числа %i: %i" x (summ x)
//     0

//Лог или = ||
//Лог и = &&
//Лог нет = not

// let where x y : int = // Задача 9
//     if x > 0 && y > 0
//     then 1
//     else if x < 0 && y > 0
//     then 2
//     else if x < 0 && y < 0
//     then 3
//     else if x > 0 && y < 0
//     then 4
//     else 0
//     
// [<EntryPoint>]
// let main args =
//     printf "Введите координату x: "
//     let x = int(Console.ReadLine())
//     printf "Введите координату y: "
//     let y = int(Console.ReadLine())
//     
//     printf "Ваша координата находится в %i четверти плоскости" (where x y)
//     0

// let rec summOfDel x del : int =
//     if del = 1
//     then 1
//     else if x % del = 0
//     then x + summOfDel x (del-1)
//     else summOfDel x (del-1)
//
// [<EntryPoint>]
// let main args =
//     printf "Введите число: "
//     let number = int(Console.ReadLine())
//     printf "Сумма делителей числа %i: %i" number (summOfDel number number)
//     0