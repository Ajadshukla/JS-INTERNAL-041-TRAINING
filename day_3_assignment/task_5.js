// Task 5: User Profile JSON
// Convert object to JSON → Store in variable → Convert back to object.
// Example:
// let user = {name:"Aman", age:21, course:"JS"};

let user = {name:"Aman", age:21, course:"JS"};
let jsonString = JSON.stringify(user);
let userObject = JSON.parse(jsonString);
console.log("Original Object:", user);
console.log("JSON String:", jsonString);
console.log("Converted Back to Object:", userObject);