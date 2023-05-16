function NeedToRefactorLator(description)
{
    return function (clsConstructior: Function)
    {
        console.log(description)
        console.log(clsConstructior)

    }
}

@NeedToRefactorLator("urgent")//meta data tag,wrapper , additional behavior
class Foo
{
    constructor(public description = "Foo") { }
}
class Baz
{
    constructor(public description = "BAz") { }
}
@NeedToRefactorLator("Not urgent")
class Bar
{
    constructor(public description = "BAr") { }
}