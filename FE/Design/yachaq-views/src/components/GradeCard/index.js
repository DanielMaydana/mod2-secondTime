import './style.css';
import React from 'react';
import LetterToNumericGrade from '../utils/letterToNumericGrade'
export default function GradeCard({ generalInfo, monthlyGrades }) {
  const generateEntries = function (monthlyGrades) {
    return monthlyGrades.map((single, index) =>
      <section className="entry" key={index}>
        <section className="month">{single.month}</section>
        <section className={`grade ${LetterToNumericGrade(single.grade)}`}>{single.grade}</section>
      </section>
    );
  }
  return (
    <section className="gradeCardCmpt">
      <section className="header">
        <section className="title">{generalInfo.title}</section>
        <section className="trainer">{generalInfo.trainer}</section>
        <section className="mainScore">{generalInfo.mainScore}</section>
      </section>
      <section className={`body ${isExpanded ? "visible" : "hidden"}`}>
        <section className="body visible">
          {generateEntries(monthlyGrades)}
        </section>
        <section className="actions">
          <section className="button" id="expand" onClick={expandHandler}>{isExpanded ? "HIDE MONTHLY GRADES" : "SHOW MONTHLY GRADES"}</section>
        </section>
      </section>
    </section>
  )
}