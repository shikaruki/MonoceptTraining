var i = 1;

function timedCount()
{
    i = i * i;
    postMessage(i);
    i = i + 1;
    setTimeout("timedCount()", 500);
}

timedCount();