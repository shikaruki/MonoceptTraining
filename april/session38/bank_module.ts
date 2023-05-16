export default class Bank
{
    constructor(public name = "Hdfc", public location = "Lucknow")
    {

    }
}

export class Customer
{
    constructor(public name = "Anonymous")
    {

    }
}

export class Account
{
    constructor(public balance = 500)
    {

    }
}

export function sayHello(name)
{
    return "Hello " + name;
}