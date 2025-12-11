// Task 1: Student Marks
// Create an array of marks → calculate average using reduce().
// let marks = [80, 90, 70, 85, 95];
// Output Example:
// Average Marks: 84


let marks = [80, 90, 70, 85, 95];
let sum = marks.reduce((accumulator, currentValue) => accumulator + currentValue, 0);
let average = sum / marks.length;
console.log(`Average Marks: ${average}`);