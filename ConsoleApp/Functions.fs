module Functions

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

// Units

let z = ()

ignore (lessthanten 12)





