// type inference
let rec power = function
    | (x, 0) -> 1.0
    | (x, n) -> x * power (x, n-1)

// anonymous functions (lambda)
let f = fun y -> y + 3
let g = fun x -> x * x
// function composition
let h = f << g
// function application
let k x =
    x |> g |> f

// higher order functions
let weight ro = fun s -> ro * s ** 3.0
// partial evaluation with currying
let waterWeight = weight 1000.0
let methanolWeight = weight 786.5

// infix operators
// implication
let (==>) p q = not p || q
// equivalence
let (<=>) p q = p = q
// exclusive or
let (<+>) p q = p <> q
