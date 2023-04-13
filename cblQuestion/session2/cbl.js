//question : 1
function Add(...nums)
{
    var sum = 0;
    for (const num of nums)
        sum += num;
    return sum;
}
console.log(Add(10, 20, 30, 40))
console.log(Add(10, 20, 30, 3))


//Question 2: 

function findLargestString(...arr)
{
    let maxLength = 0;
    let longestString = [];
    for (var i = 0; i < arr.length; i++)
    {
        if (arr[i].length > maxLength)
        {
            maxLength = arr[i].length;
            longestString = [arr[i]];
        }
        else if (arr[i].length === maxLength)
        { longestString.push(arr[i]); }
    }
    return longestString;
}

console.log(findLargestString("raj", "ravi", "Rajul", "kdidi"));

