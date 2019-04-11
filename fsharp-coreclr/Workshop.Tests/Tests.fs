module Tests

open System
open Xunit
open Workshop

[<Fact>]
let ``IsTrue`` () =
    let result = Test.IsTrue
    Assert.True(result)
