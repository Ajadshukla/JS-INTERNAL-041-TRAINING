// 10. var / let / const example
var a = 10;
let b = 20;
const c = 30;

function scopeExample() {
    if (true) {
        var a = 1; // Function scoped (re-declared)
        let b = 2; // Block scoped (new variable)
        // const c = 3; // Block scoped (new variable)

        console.log("Inside block (var a):", a);
        console.log("Inside block (let b):", b);
        console.log("Inside block (const c):", c); 
    }
    console.log("Inside function (var a):", a);
    // console.log("Inside function (let b):", b); // Error: b is block-scoped
}

scopeExample();
console.log("Global (var a):", a);
console.log("Global (let b):", b);
console.log("Global (const c):", c);