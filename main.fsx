let myInt = 5
let myFloat = 3.14
let myString = "hello"

let twoToFive = [2; 3; 4; 5]
let oneToFive = 1 :: twoToFive
let zeroToFive = [0; 1] @ twoToFive

let square x = x * x
square 3

let add x y = x + y
add 2 3

let evens list =
    let isEven x = x % 2 = 0
    List.filter isEven list

evens oneToFive

let sumOfSquaresTo100 =
    List.sum (List.map square [1..100])

let sumOfSquaresTo100piped =
    [1..100] |> List.map square |> List.sum

let simplePatternMatch =
    let x = "a"
    match x with
        | "a" -> "x is a"
        | "b" -> "x is b"
        | _ -> "x is something else"

let validValue = Some(99)
let invalidValue = None

module FunctionExamples =
    let add x y = x + y

    let a = add 1 2

    let add42 = add 42
    let b = add 42 1

    let add1 = add 1
    let add2 = add 2
    let add3 = add1 >> add2
    let c = add3 7

    [1..10] |> List.map add3

    let add6 = [add1; add2; add3] |> List.reduce (>>)
    let d = add6 7

module ListExamples =
    let list1 = ["a"; "b"]
    let list2 = "c" :: list1
    let list3 = list1 @ list2
