namespace Exercises.Tests

module Chapter02Tests =

    open FsUnit.Xunit
    open Xunit
    open Exercises.Chapter02

    [<Fact>]
    let ``Exercise 2.1`` () =
        f 24 |> should be True
        f 27 |> should be True
        f 29 |> should not' (be True)
        f 30 |> should not' (be True)

    [<Fact>]
    let ``Exercise 2.1 with pattern matching`` () =
        f' 24 |> should be True
        f' 27 |> should be True
        f' 29 |> should not' (be True)
        f' 30 |> should not' (be True)

    [<Fact>]
    let ``Exercise 2.2`` () =
        pow ("", 0)     |> should equal ""
        pow ("", 10)    |> should equal ""
        pow ("Test", 0) |> should equal ""
        pow ("Test", 3) |> should equal "TestTestTest"

    [<Fact>]
    let ``Exercise 2.2 with StringBuilder`` () =
        pow' ("", 0)     |> should equal ""
        pow' ("", 10)    |> should equal ""
        pow' ("Test", 0) |> should equal ""
        pow' ("Test", 3) |> should equal "TestTestTest"

    [<Fact>]
    let ``Exercise 2.3`` () =
        isIthChar("Test", 0, 'T') |> should be True
        isIthChar("Test", 3, 't') |> should be True
        isIthChar("Test", 1, 'e') |> should be True
        isIthChar("Test", 2, 'e') |> should not' (be True)

    [<Fact>]
    let ``Exercise 2.4`` () = 
        Assert.Equal(3, occFromIth("abcabcabc", 0, 'a'))
        Assert.Equal(2, occFromIth("abcabcabc", 1, 'a'))
        Assert.Equal(1, occFromIth("abcabcabc", 4, 'a'))
        Assert.Equal(2, occFromIth("abcabcabc", 4, 'b'))
        Assert.Equal(1, occFromIth("abcabcabc", 8, 'c'))
        Assert.Equal(0, occFromIth("abcabcabc", 7, 'a'))
        Assert.Equal(0, occFromIth("abcabcabc", 0, 'd'))
        Assert.Equal(0, occFromIth("", 0, 'a'))

    [<Fact>]
    let ``Exercise 2.4 with pattern matching`` () = 
        Assert.Equal(3, occFromIth'("abcabcabc", 0, 'a'))
        Assert.Equal(2, occFromIth'("abcabcabc", 1, 'a'))
        Assert.Equal(1, occFromIth'("abcabcabc", 4, 'a'))
        Assert.Equal(2, occFromIth'("abcabcabc", 4, 'b'))
        Assert.Equal(1, occFromIth'("abcabcabc", 8, 'c'))
        Assert.Equal(0, occFromIth'("abcabcabc", 7, 'a'))
        Assert.Equal(0, occFromIth'("abcabcabc", 0, 'd'))
        Assert.Equal(0, occFromIth'("", 0, 'a'))

    [<Fact>]
    let ``Exercise 2.4 without recursion`` () = 
        Assert.Equal(3, occFromIth''("abcabcabc", 0, 'a'))
        Assert.Equal(2, occFromIth''("abcabcabc", 1, 'a'))
        Assert.Equal(1, occFromIth''("abcabcabc", 4, 'a'))
        Assert.Equal(2, occFromIth''("abcabcabc", 4, 'b'))
        Assert.Equal(1, occFromIth''("abcabcabc", 8, 'c'))
        Assert.Equal(0, occFromIth''("abcabcabc", 7, 'a'))
        Assert.Equal(0, occFromIth''("abcabcabc", 0, 'd'))
        Assert.Equal(0, occFromIth''("", 0, 'a'))

    [<Fact>]
    let ``Exercise 2.5`` () = 
        occInString("abcabcabc", 'a') |> should equal 3
        occInString("abcabcabc", 'b') |> should equal 3
        occInString("abcabcabc", 'c') |> should equal 3
        occInString("abcabcabc", 'd') |> should equal 0
        occInString("", 'a')          |> should equal 0

    [<Fact>]
    let ``Exercise 2.6`` () =
        notDivisible 2 5 |> should be True
        notDivisible 3 9 |> should not' (be True)