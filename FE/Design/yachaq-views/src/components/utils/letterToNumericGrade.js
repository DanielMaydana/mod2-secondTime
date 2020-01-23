const GRADE_TO_NUMBER = {
  "A+": 10,
  "A": 9.5,
  "A-": 9,
  "B+": 8.5,
  "B": 8,
  "B-": 7.5,
  "C+": 7,
  "C": 6.5,
  "C-": 6,
  "D+": 5.5,
  "D": 5,
  "D-": 4.5,
}
export default function (grade) {
  const quantifiedGrade = GRADE_TO_NUMBER[grade];
  if (quantifiedGrade <= 10 && quantifiedGrade >= 8.5) return "good";
  else if (quantifiedGrade <= 8 && quantifiedGrade >= 6.5) return "average";
  else if (quantifiedGrade <= 6) return "poor";
}