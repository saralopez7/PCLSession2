module PclYEx2
open System
/// Exercise 2.1

(*
a = 5
b = 15
c = 20
*)

let a = 5
let b = let a = 10 in a + 5
let c = a + b

/// Exercise 2.2

let addNum1 x:int = x + 1
        
let addNum10 x = x + 10

let addNum20 x:int = addNum10 (x) + 20

/// Exercise 2.3
let max2 (x:int) (y:int) = if x > y then x else y
    
let evenOrOdd x = if (x % 2) = 0 then printfn "Even number" else  printfn "Odd number"

let addXY (x:int) (y:int) = 
    printfn "%i %i" x y 
    x + y

let rec addNumbersRec j k = 
    if k = 0 then      
        j 
    else
        addNumbersRec j (k-1) + addNum10 0
    
let addNumbers j k = j + 10*k