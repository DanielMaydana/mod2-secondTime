import './style.css'
import React from 'react'
import GradeCard from '../../components/GradeCard'
export default function GradesSummary({ monthlyGrades }) {
  const generateCards = function (subjectGrades) {
    return subjectGrades.map((element, index) =>
      <GradeCard generalInfo={element.generalInfo} monthlyGrades={element.monthlyGrades} key={index} />
    )
  }
  return (
    <section className="gradesSummaryView">
      {/* {generateCards(monthlyGrades)} */}
    </section>
  )
}