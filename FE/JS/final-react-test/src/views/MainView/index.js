import React from 'react'
import List from '../../components/List'
import FilteredList from '../../components/FilteredList'
import mockResponse from './catFacts'
import useApi from '../../restApi/useApi'
import './style.css'

export default function MainView () {

  const [response] = useApi(GET_CAT_INFO)
  
  async function GET_CAT_INFO () {

    const localResponse = JSON.parse(localStorage.getItem('response'))
    if(Boolean(localResponse)) {
      return localResponse
    }
    else {
      const response = await mockResponse()
      localStorage.setItem('response', JSON.stringify(response))
      return response
    }
  }

  const hasResponse = response && response.all

  function generateLists () {
    return (
      <>
        <List
          values={response.all}
          header={'All'}
          type={'regular'} s/>
        <List
          values={response.all}
          header={'Most popular'}
          type={'popularity'} />
        <List
          values={response.all}
          header={'By User'}
          type={'username'} />
        <FilteredList
          values={response.all}
          header={'Custom'}
          type={'regular'} />
      </>
    )
  }

  return (
    <div className="mainView">
      { hasResponse && generateLists() }
    </div>
  )
}