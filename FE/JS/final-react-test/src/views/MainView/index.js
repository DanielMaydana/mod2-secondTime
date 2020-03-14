import React, { useEffect, useState } from 'react'
import List from '../../components/List'
import mockResponse from './catFacts'
import useApi from '../../restApi/useApi'
import './style.css'
import Cookie from 'js-cookie'

export default function MainView () {

  const [response] = useApi(GET_CAT_INFO)
  
  async function GET_CAT_INFO () {
    return mockResponse()
  }

  const hasLoaded = response && response.all

  function generateLists () {
    return (
      <>
        <List values={response.all} title={'All'} type={'popularity'}/>
        <List values={response.all} title={'Most popular'} type={'username'}/>
        <List values={response.all} title={'By User'} type={'regular'} />
        <List values={response.all} title={'Custom'} type={'custom'} />
      </>
    )
  }

  return (
    <div className="mainView">
      { hasLoaded && generateLists() }
    </div>
  )
}