namespace Exercises

module Chapter02 =

    // Exercise 2.1
    let f n = ((n % 2 = 0) || (n % 3 = 0)) && (n % 5 <> 0)
    // another variant with pattern matching
    let f' = function 
        | n when (n % 5 = 0) -> false
        | n when (n % 2 = 0) -> true
        | n when (n % 3 = 0) -> true
        | _ -> false

    // Exercise 2.2
    let rec pow (s: string, n: int) : string =
        match (s, n) with
        | (_, 0) -> ""
        | (s, 1) -> s
        | (s, _) when (s.Length = 0) -> ""
        | (s, n) -> s + pow (s, n-1)

    // another variant using StringBuilder without recursion
    let pow' (s: string, n: int) : string =
        let builder = System.Text.StringBuilder()
        for count = 1 to n do
            builder.Append(s) |> ignore
        builder.ToString()

    // Exercise 2.3
    let isIthChar (str: string, i: int, ch: char) : bool =
        if (i < 0 || i > str.Length) then 
            false
        else 
            str.[i] = ch

    // Exercise 2.4
    let rec occFromIth (str: string, i: int, ch: char) : int =
        if (i >= str.Length) then 
            0
        else if (str.[i] = ch) then 
            1 + occFromIth (str, i+1, ch)
        else 
            occFromIth (str, i+1, ch)

    // another recursive variant with pattern matching
    let rec occFromIth' = function
        | (str:string,i,_) when i >= str.Length -> 0
        | (str,i,ch) when isIthChar(str, i, ch) -> 1 + occFromIth (str, i+1, ch)
        | (str,i,ch) -> occFromIth (str, i+1, ch)

    // another variant without recursion
    let rec occFromIth'' (str: string, i: int, ch: char) : int =
        if (i >= str.Length) then
            0
        else
            str.Substring i
            |> Seq.filter(fun c -> c = ch)
            |> Seq.length

    // Exercise 2.5
    let occInString (str: string, ch: char) : int =
        occFromIth(str, 0, ch)

    // Exercise 2.6
    let notDivisible d n =
        n % d <> 0
