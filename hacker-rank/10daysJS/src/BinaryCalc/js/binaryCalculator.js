'use strict'

import Convert from './utils.js'

export class BinaryCalculator {
    constructor() {
    }

    Calculate(expression) {
        let operators = Array.from(expression).filter(el => el === '+' || el === '-' || el === '*' || el === '/');
        let operands = expression.split(/[-+*\/]/);
        let total = 0;

        for (let idx = 0; idx < operands.length; idx++) {
            let operator = idx > operators.length - 1
                ? operators[operators.length - 1]
                : operators[idx]

            switch (operator) {
                case "+":
                    total += Convert(operands[idx]);
                    continue;
                case "-":
                    total -= Convert(operands[idx]);
                    total = total < 0 ? total *= -1 : total;
                    continue;
                case "*":
                    total = total === 0
                        ? total + 1 * Convert(operands[idx])
                        : total * Convert(operands[idx]);
                    continue;
                case "/":
                    total = total === 0
                        ? total + 1 / Convert(operands[idx])
                        : total / Convert(operands[idx]);
                    continue;
            }
        }
        return total.toString(2);
    }
}