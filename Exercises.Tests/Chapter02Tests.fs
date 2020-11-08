namespace Exercises.Tests

module Chapter02Tests =

    open Xunit
    open Exercises.Chapter02

    [<Fact>]
    let ``Exercise 2.1`` () =
        Assert.True (f 24)
        Assert.True (f 27)
        Assert.False(f 29)
        Assert.False(f 30)

    [<Fact>]
    let ``Exercise 2.1 with pattern matching`` () =
        Assert.True (f' 24)
        Assert.True (f' 27)
        Assert.False(f' 29)
        Assert.False(f' 30)

    [<Fact>]
    let ``Exercise 2.2`` () =
        Assert.Equal("", pow ("", 0))
        Assert.Equal("", pow ("", 10))
        Assert.Equal("", pow ("Test", 0))
        Assert.Equal("TestTestTest", pow ("Test", 3))

    [<Fact>]
    let ``Exercise 2.2 with StringBuilder`` () =
        Assert.Equal("", pow' ("", 0))
        Assert.Equal("", pow' ("", 10))
        Assert.Equal("", pow' ("Test", 0))
        Assert.Equal("TestTestTest", pow' ("Test", 3))

    [<Fact>]
    let ``Exercise 2.3`` () =
        Assert.True(isIthChar("Test", 0, 'T'))
        Assert.True(isIthChar("Test", 3, 't'))
        Assert.True(isIthChar("Test", 1, 'e'))
        Assert.False(isIthChar("Test", 2, 'e'))

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
        Assert.Equal(3, occInString("abcabcabc", 'a'))
        Assert.Equal(3, occInString("abcabcabc", 'b'))
        Assert.Equal(3, occInString("abcabcabc", 'c'))
        Assert.Equal(0, occInString("abcabcabc", 'd'))
        Assert.Equal(0, occInString("", 'a'))