import './style.css'
import React from 'react'
import GradePill from '../../components/GradePill'
export default function GradesSummary({ latestGrades }) {
  const generatePills = function (grades) {
    return grades.map((elem, index) => {
      return <GradePill key={index} title={elem.title} grade={elem.grade} />
    })
  }
  return (
    <section className="gradesSummaryView">
      <section className="pills">
        {generatePills(latestGrades)}
      </section>
    </section>
  )
}