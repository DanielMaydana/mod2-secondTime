import React from 'react'
import GlobalProvider from '../../context/global/provider'
import TodoList from '../../components/TodoList'
export default function TodoListView() {
  return (
    <GlobalProvider>
      <TodoList />
    </GlobalProvider>
  )
}