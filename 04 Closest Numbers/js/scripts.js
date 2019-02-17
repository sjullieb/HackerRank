
const n = 10;

const arr = [-20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854 ];

function closestNumbers(arr) {
    var results = [];
    var newarr = arr.sort();
    if (arr.length > 2)
    {
        newarr.sort(function(a,b) {return a > b ? 1 : -1});
        console.log(newarr);

        var currentMin = arr[arr.length - 1] - arr[0];

        for (var i = 0; i < arr.length - 1; i++)
        {
            var diff = arr[i + 1] - arr[i];
            if (diff <= currentMin)
            {
                if (diff < currentMin)
                {
                    results = [];
                    currentMin = diff;
                }
                results.push(arr[i]);
                results.push(arr[i + 1]);
            }
        }
    }
    return results;
}

$(document).ready(function(){
    console.log("in");
  $("#program").click(function(){
    console.log("in");
    let result = closestNumbers(arr);
    console.log(result);
  })
})
