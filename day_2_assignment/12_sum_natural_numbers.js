// 12. Sum of first 10 natural numbers
function sumFirstTenNaturalNumbers() {
    let sum = 0;
    for (let i = 1; i <= 10; i++) {
        sum += i;
    }
    return sum;
}

console.log(sumFirstTenNaturalNumbers());