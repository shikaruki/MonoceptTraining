class StrudentV1
{
    name: string
    cgpa: number
    constructor(pname = "Anonymous", pcgpa = 0)
    {
        this.name = pname;
        this.cgpa = pcgpa;
    }
}
let s1: StrudentV1;
s1 = new StrudentV1("manjunath", 4.5);
console.log(s1)
s1.name = "ravi"
s1.cgpa = 8.2
console.log(s1)

class StudentV2
{
    constructor(public name = "Anonymous", public cgpa = 0)
    {

    }
}
let s2 = new StudentV2("MAnjunath", 7.5)
console.log(s2.name)
s2.name = "RAvi"
console.log(s2)

class StudentV3
{
    constructor(private name = "", private cgpa = 0)
    {

    }
    setUserCgpa(pcgpa)
    {
        this.cgpa = pcgpa;
    }
}

let s3 = new StudentV3();
s3.setUserCgpa = 5.4;
console.log(s3)

class StudentV4
{
    constructor(private name = "", private cgpa = 0)
    {

    }
    get UserName()
    {
        return this.name;
    }
    set UserName(pname: string)
    {
        this.name = pname;
    }
    set UserCgpa(pcgpa: number)
    {
        this.cgpa = pcgpa;
    }
    get UserCgpa()
    {
        return this.cgpa;
    }
}

let s4 = new StudentV4();
s4.UserName = "ravi"
s4.UserCgpa = 8;
console.log(s4)
