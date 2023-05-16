let userName: string
  , cgpa: number,
  isMale: boolean
  , displayText: string
userName = "ravi"
cgpa = 7.5;
isMale = true;
displayText = `
                    =========================
                      showing student details
                    =========================
                    user name is ${userName}
                    cgpa is ${cgpa}
                    gender is ${isMale ? 'Male' : 'Female'}
`
console.log(displayText);