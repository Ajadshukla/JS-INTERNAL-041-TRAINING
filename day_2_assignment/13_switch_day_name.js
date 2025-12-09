// 13. Switch-case → day name (1=Sunday, 2=Monday, etc.)
function getDayName(day) {
    let dayName;
    switch (day) {
        case 1:
            dayName = "Sunday";
            break;
        case 2:
            dayName = "Monday";
            break;
        case 3:
            dayName = "Tuesday";
            break;
        default:
            dayName = "Invalid Day";
    }
    return dayName;
}

console.log(getDayName(3));