'use strict' 

export default function Convert(exp){
    let result = 0;
    let arr = Array.from(exp)

    for (let i = 0; i < arr.length; i++) {
        result += arr[i] * Math.pow(2, (arr.length - 1) - i);
    }

    return result;
}