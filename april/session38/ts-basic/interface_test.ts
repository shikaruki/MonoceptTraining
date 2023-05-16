interface ICustomer
{
    //schema
    id: number,
    firstName: string,
    lastName: string,
    location?: string
}

//let customers:Array<ICustomer>;
let customers : ICustomer[];
customers = [
    { id: 101, firstName: "customer 1", lastName: "lastName" },
    { id: 102, firstName: "customer 2", lastName: "lastName" },
    { id: 103, firstName: "customer 3", lastName: "lastName" },
    { id: 104, firstName: "customer 4", lastName: "lastName" },
];
printDetails(customers);
function printDetails(customers: ICustomer[])
{
    for (let c in customers)//index
    { console.log(c) }
    for (let c of customers)//value of
    {
        console.log(c.firstName)
    }
}