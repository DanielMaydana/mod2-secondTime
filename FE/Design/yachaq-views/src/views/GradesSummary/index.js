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
      <section className="title">GRADES</section>
      <section className="pills">
        <h5>Latest Grades</h5>
        {generatePills(latestGrades)}
      </section>
      <section className="chart">
        <img src="./grades.png" alt="" />
      </section>
    </section>
  )
}