// complete the function alphabetShift(str) and returns each alphabet shifted to 1 position to next
// alphabet ex: alphabetShift("crazy") => "dsbaz"

function shiftRight(word)
{
    let result = ""
    for (let i = 0; i < word.length; i++)
        result += word[i] = String.fromCharCode(word.charCodeAt(i) + 1)
    return result;
}

function shiftRightAlphabet(word)
{
    let arr = word.split("");
    for (let i = 0; i < arr.length; i++)
        arr[i] = String.fromCharCode(word.charCodeAt(i) + 1);
    return arr.join("");
}
console.log(shiftRight("ravi"))
console.log(shiftRightAlphabet("abc"))