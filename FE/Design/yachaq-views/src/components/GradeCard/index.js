import './style.css';
import React from 'react';

export default function GradeCard({ generalInfo, monthlyGrades }) {

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

  const colorGrades = function (grade) {
    const quantifiedGrade = GRADE_TO_NUMBER[grade];
    if (quantifiedGrade <= 10 && quantifiedGrade >= 8.5) return "good";
    else if (quantifiedGrade <= 8 && quantifiedGrade >= 6.5) return "average";
    else if (quantifiedGrade <= 6) return "poor";
  }

  const generateEntries = function (monthlyGrades) {
    return monthlyGrades.map((single, index) =>
      <section className="entry" key={index}>
        <section className="month">{single.month}</section>
        <section className={`grade ${colorGrades(single.grade)}`}>{single.grade}</section>
      </section>
    );
  }

  return (
    <section className="gradeCardCmpt">
      <section className="header">
        <section className="title">{generalInfo.title}</section>
        <section className="trainer">{generalInfo.trainer}</section>
        {/* <section className="mainScore">{generalInfo.mainScore}</section> */}
      </section>
      {/* <section className={`body ${isExpanded ? "visible" : "hidden"}`}> */}
      <section className="body visible">
        {generateEntries(monthlyGrades)}
      </section>
      {/* <section className="actions">
        <section className="button" id="expand" onClick={expandHandler}>{isExpanded ? "HIDE MONTHLY GRADES" : "SHOW MONTHLY GRADES"}</section>
      </section> */}
    </section>
  )
}