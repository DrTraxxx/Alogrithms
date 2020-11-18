'use strict'

import Convert from './utils.js'

export class BinaryCalculator {
    constructor() {
    }

    Calculate(expression) {

        let operator = Array.from(expression).find(el => el === '+' || el === '-' || el === '*' || el === '/');
        let operands = expression.split(operator);

        switch (operator) {
            case '+':
                return operands
                    .reduce((opr,sum)=>Convert(opr) + Convert(sum))
                    .toString(2);
            case '-':
                return operands
                    .reduce((opr,sum)=>Convert(opr) - Convert(sum))
                    .toString(2)
            case '*':
                return operands
                    .reduce((opr,sum)=>Convert(opr) * Convert(sum))
                    .toString(2)
            case '/':
                return operands
                    .reduce((opr,sum)=>Convert(opr) / Convert(sum))
                    .toString(2)
        }
    }
}