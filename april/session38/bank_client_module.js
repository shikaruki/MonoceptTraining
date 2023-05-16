"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var bank_module_1 = require("./bank_module");
var b = new bank_module_1.default();
console.log(b);
var c = new bank_module_1.Customer("RAvi");
console.log(c);
var d = (0, bank_module_1.sayHello)("RAvi");
console.log(d);
