module Functional

// lambda

let doubled =  5

let doubleDouble = List.map (fun x -> x * 2) [1 .. 10]

// partially applied function

let printit (prefix : string) (it : int) = printfn "%s %d" prefix it

printit "==>" 10

let printpartial = printit @"==>"

printpartial 100

List.iter printpartial [1 .. 10]

// return a function

let timeit it = (fun multiplier -> it * multiplier)

let mult10 = timeit 10
let mult20 = timeit 20

let thirty = mult10 3
let sixty = mult20 3

// recursion

let rec pointless (x:int) =
    let next = x - 10
    printfn "next -> %d" next 
    if next < 0 then
        0
    else
        pointless next

let p = pointless 39

// mutually exclusive recursion

let rec morepointless (x:int) =
    printfn "morepointless %d" x
    if x < 0 then
        false
    elif x = 0 then
        true
    else
        evenmorepointless(x - 1) 
and evenmorepointless (x:int) =
    printfn "evenmorepointless %d" x
    if x > 0 then
        morepointless x
    else
        false

let x = morepointless 8
let y = evenmorepointless 7

// symbolic operator composed of !%&*+-./<=>@^|?

let (%%%) (x:int) (y: int) =
    if (x % y) = 0 then
        true
     else
        false 

let divides = 99 %%% 3
let dontdivides = 99 %%% 4





    





