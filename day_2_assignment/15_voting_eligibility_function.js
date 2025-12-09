// 15. Function → Voting eligibility (Age >= 18)
function checkVotingEligibility(age) {
    if (age >= 18) {
        return "Eligible to vote";
    } else {
        return "Not eligible to vote";
    }
}

console.log(checkVotingEligibility(20));