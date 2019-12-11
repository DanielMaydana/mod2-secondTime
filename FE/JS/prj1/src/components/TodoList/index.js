import React, { useEffect, useState } from 'react'
import TodoForm from '../TodoForm'
import List from '../List'

export default function TodoList() {

  const [showForm, setShowForm] = useState(false);
  const [tasks, setTasks] = useState([]);

  function handleAdd() {
    setShowForm(true);
  }

  function handleCancel() {
    setShowForm(false);
  }

  function handleSave(task) {
    const updatedTasks = [...tasks, { ...task }];
    setTasks(updatedTasks);
    console.log(tasks)
  }

  return (
    <section className="todoListCmpt">
      <button onClick={handleAdd}>Add task</button>
      {showForm && <TodoForm onCancel={handleCancel} onSave={handleSave} />}
      <List entries={tasks} />
    </section>
  )
}