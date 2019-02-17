'use strict';

const fs = require('fs');

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.replace(/\s*$/, '')
        .split('\n')
        .map(str => str.replace(/\s*$/, ''));

    main();
});

function readLine() {
    return inputString[currentLine++];
}

// Complete the closestNumbers function below.
function closestNumbers(arr) {
    var results = [];
    arr.sort(function (a, b) { return a > b ? 1 : -1 });
    if (arr.length > 2) {
        var currentMin = arr[arr.length - 1] - arr[0];
        for (var i = 0; i < arr.length - 1; i++) {
            var diff = arr[i + 1] - arr[i];
            if (diff <= currentMin) {
                if (diff < currentMin) {
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

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine(), 10);

    const arr = readLine().split(' ').map(arrTemp => parseInt(arrTemp, 10));

    let result = closestNumbers(arr);

    ws.write(result.join(" ") + "\n");

    ws.end();
}
