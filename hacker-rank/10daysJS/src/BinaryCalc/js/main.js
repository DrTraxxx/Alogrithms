import {BinaryCalculator} from './binaryCalculator.js';

let expression="";

export function Insert(val){
    console.log(val);
    console.log(expression + val)

    document.getElementById('input').innerHTML = expression += val;
} 

export function Calculate(){
    let expr = document.getElementById('input').innerHTML;
    let calc = new BinaryCalculator(); 

    document.getElementById('result').innerHTML = calc.Calculate(expr);
} 

export function Clear(){
    document.getElementById('input').innerHTML = "0";
    document.getElementById('result').innerHTML = "0";
    expression="";
}