module Matching

let testit (x:int) (y:int) =
    match x, y with
    | 10, 4 -> true
    | 12, 3 -> true
    | _, _ -> false

let test1 = testit 10 3
let test2 = testit 12 3

// note, Literal val must use Capital case
[<Literal>]
let One = "1"

[<Literal>]
let Two = "2"

let teststr (s:string) =
    match s with
    | One -> 100
    | Two -> 200
    | _ -> int s

let test3 = teststr "1"
let test4 = teststr "34"

let matchRange x =
    match x with
    | 0 | 1 | 2 | 3 | 4 -> 0.1
    | _ when x >= 5 && x < 10 -> 0.25
    | _ when x >= 10 && x < 20 -> 0.5
    | _ when x >= 20 && x < 35 -> 0.75
    | _ when x >= 35 && x < 50 -> 1.0
    | _ -> 1.1

let test5 = matchRange 3

// lambda

let matchlam =
    function 
    | [] -> 1
    | [_] -> 2
    | _ -> 3

let test6 = matchlam [2]
let test7 = matchlam [1 .. 2]


