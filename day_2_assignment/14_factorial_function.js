// 14. Function → Factorial
function factorial(n) {
    if (n < 0) {
        return "Factorial is undefined for negative numbers";
    }
    if (n === 0 || n === 1) {
        return 1;
    }
    let result = 1;
    for (let i = 2; i <= n; i++) {
        result *= i;
    }
    return result;
}

console.log(factorial(5)); // 120