"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.sayHello = exports.Account = exports.Customer = void 0;
var Bank = /** @class */ (function () {
    function Bank(name, location) {
        if (name === void 0) { name = "Hdfc"; }
        if (location === void 0) { location = "Lucknow"; }
        this.name = name;
        this.location = location;
    }
    return Bank;
}());
exports.default = Bank;
var Customer = /** @class */ (function () {
    function Customer(name) {
        if (name === void 0) { name = "Anonymous"; }
        this.name = name;
    }
    return Customer;
}());
exports.Customer = Customer;
var Account = /** @class */ (function () {
    function Account(balance) {
        if (balance === void 0) { balance = 500; }
        this.balance = balance;
    }
    return Account;
}());
exports.Account = Account;
function sayHello(name) {
    return "Hello " + name;
}
exports.sayHello = sayHello;
