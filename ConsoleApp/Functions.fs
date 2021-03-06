﻿module Functions

let genfun (gentype : 'g) = 
    gentype

let lessthanten (anum : int) =
    let result = 
        if anum < 10 then
            "less than"
        elif anum = 10 then "equals to"
        else "greater than"
    result

let w = lessthanten 9

// Tuples

let mytuple = ('a', 'b', 'b')
let a, b, c = mytuple

let duple = (10,100)
let first = fst duple
let second = snd duple

let tuplefunc(one, two) = one + two

let t = tuplefunc(100, 1)

// Lists

let alist = ['a'; 'b'; 'c']
let dlist = ['d'; 'e'; 'f']

let zlist = 'z' :: alist
let adlist = alist @ dlist

let onetohundred = [1 .. 100]
let tentohundred = [10 .. 10 .. 100]

let timesten1 x = [
    for i in 1 .. 10 do
        yield x * i * 10
    ]

let timesten2 x = [for i in 1 ..10 -> x * i * 10]

let t1 = timesten1 3
let t2 = timesten2 3

let t1length = t1.Length

let customtest x = if x > 100 then true else false

let t1a, t1b = List.partition customtest t1
let t1100 = List.tryFind customtest t1

// List aggretate example

let toString (x: int) =
    string x

let stringList = List.map toString t1

let addFold x y = x + y
let totalValue = List.reduce addFold t1
let initValue = 1000 
let totlaValueFold = List.fold addFold initValue t1

let posPrint x = printfn "%d " x
 
let printList = List.iter posPrint t1


// Units

let z = ()

ignore (lessthanten 12)

// Option

let moreThan1 x =
    if x > 1 then
        Some(x)
    else
        None

let optResult = moreThan1 4
let optResultVal = Option.get optResult

// Print

let an_int = 100
let a_string = "A String"
let a_float = 1.1
let a_char = 'x'
let an_object = (' ', 'y', 'z')

let printer p = 
    printfn "int %d, hex %x, oct %o, float %f, char %c, bool %b, object %O, anything %A"  an_int, an_int, an_int, a_float, a_char, true, an_object, an_object






