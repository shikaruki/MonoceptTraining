var userName, cgpa, isMale, displayText;
userName = "ravi";
cgpa = 7.5;
isMale = true;
displayText = "\n                    =========================\n                      showing student details\n                    =========================\n                    user name is ".concat(userName, "\n                    cgpa is ").concat(cgpa, "\n                    gender is ").concat(isMale ? 'Male' : 'Female', "\n");
console.log(displayText);
