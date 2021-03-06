﻿// Demo 1

let a = 1
let b = 2
let sum x y = x + y
let res = sum a b

let myTuple = (42, "hello")
let number, message = myTuple

type MyRecord = { Number: int; Message: string }
let myRecord = { Number = 42; Message = "hello" }
let newRecord = { myRecord with Message = "hi" }


// Demo 2

let execute x y operation = operation x y
let res' = execute 1 2 sum

let addOne x = sum x 1
let addTwo x = sum x 2
let res1 = addOne 1
let res2 = addTwo res1

let res1' = 1 |> addOne
let res2' = res1 |> addTwo
let res2'' = 1 |> addOne |> addTwo

let addOne' = sum 1
let addTwo' = sum 2
let res2''' = 1 |> addOne |> addTwo

let addThree = addOne >> addTwo
let res2'''' = addThree 1


// Demo 3

let optionAddOne x =
    if x = None then 0
    else x.Value + 1

let optionAddOne' x =
    if x = None then None
    else Some (x.Value + 1)

let optionAddOne'' x =
    match x with
    | None -> None
    | Some n -> Some (n + 1)

let divide dividend divisor =
    let quotient = dividend / divisor
    let remainder = dividend % divisor
    (quotient, remainder) 

type DivisionResult =
| DivisionSuccess of quotient: int * remainder: int
| DivisionError of message: string

let divide' dividend divisor =
    match dividend with
    |0 -> DivisionError(message = "Divide by zero")
    |_ -> DivisionSuccess(quotient = dividend / divisor, 
                          remainder = dividend % divisor)

[<Measure>] type m; [<Measure>] type km; [<Measure>] type h
let distanceInMts = 11580.0<m>
let distanceInKms = 87.34<km>
//let totalDistance = distanceInMts + distanceInKms // Error
let totalDistance' = distanceInMts / 1000.0<m> * 1.0<km> + distanceInKms
let speed = totalDistance' / 2.4<h>