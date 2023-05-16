//let customers:Array<ICustomer>;
var customers;
customers = [
    { id: 101, firstName: "customer 1", lastName: "lastName" },
    { id: 102, firstName: "customer 2", lastName: "lastName" },
    { id: 103, firstName: "customer 3", lastName: "lastName" },
    { id: 104, firstName: "customer 4", lastName: "lastName" },
];
printDetails(customers);
function printDetails(customers) {
    for (var c in customers) //index
     {
        console.log(c);
    }
    for (var _i = 0, customers_1 = customers; _i < customers_1.length; _i++) {
        var c = customers_1[_i];
        console.log(c.firstName);
    }
}
