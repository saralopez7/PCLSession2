// Learn more about F# at http://fsharp.org


open System

(*
multi-line comments
*)
let time = DateTime.Today.ToString("yyyy.MM.dd hh:mm:ss")
printfn "%s" time

// a simple function with integers
let function1 x = 2 + 4 + x * 4

let rec vfactorial x:int =  
    if x <= 0 then
        1
    else 
        x * vfactorial (x - 1)

let data = (12, "Valentine", 134)
let funSwap (a, b) = (b, a)
// Swapping a point
let pointA = (12, 134)

let pointB = funSwap pointA

let oddNums = [1; 3; 5; 7; 9]

let consist = 1 :: [2; 3]

let enVowels = ['a'; 'e'; 'i'; 'o'; 'u']

let squareOfFirst10Integers = [for i in 1..10 -> i * i]
   
