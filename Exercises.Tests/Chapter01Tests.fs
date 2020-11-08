namespace Exercises.Tests

module Chapter01Tests =

    open System
    open Xunit
    open Exercises.Chapter01

    [<Fact>]
    let ``Exercise 1.4`` () =
        Assert.Equal(10, fac 4)
        Assert.Equal(55, fac 10)

    [<Fact>]
    let ``Exercise 1.5`` () =
        Assert.Equal(0, fibonacci 0)
        Assert.Equal(1, fibonacci 1)
        Assert.Equal(1, fibonacci 2)
        Assert.Equal(2, fibonacci 3)
        Assert.Equal(3, fibonacci 4)
        Assert.Equal(5, fibonacci 5)
        Assert.Equal(8, fibonacci 6)

    [<Fact>]
    let ``Exercise 1.6 `` () =
        Assert.Equal(0, sum(0,0)) 
        Assert.Equal(1, sum(1,0)) 
        Assert.Equal(3, sum(1,1)) 
        Assert.Equal(27, sum(2,5)) 
        Assert.Equal(63, sum(3,8)) 