namespace Exercises

module Chapter01 =
    // Exercise 1.4
    let rec fac = function
        | 0 -> 0
        | n -> n + fac (n-1)

    // Exercise 1.5
    let rec fibonacci = function
        | 0 -> 0
        | 1 -> 1
        | n -> fibonacci (n-1) + fibonacci (n-2)

    let rec sum = function
        | (m,0) -> m
        | (m,n) -> m + n + sum (m, n-1)
