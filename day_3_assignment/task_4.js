// Task 4: Movie List
// Create array of movie names.
// ➡ Add one movie
// ➡ Remove last movie
// // ➡ Print final list using loop

let movies = ["Inception", "The Dark Knight", "Interstellar", "Prestige"];
movies.push("Dunkirk");
movies.pop();
console.log("Final Movie List:");
for (let i = 0; i < movies.length; i++) {
    console.log(movies[i]);
}