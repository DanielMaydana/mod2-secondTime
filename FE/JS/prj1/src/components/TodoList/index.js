import React, { useEffect, useState } from 'react'
import TodoForm from '../TodoForm'
import List from '../List'
import './style.css'

export default function TodoList() {

  const [showForm, setShowForm] = useState(false);
  const [tasks, setTasks] = useState([]);

  function handleAdd() {
    setShowForm(true);
  }

  function handleCancel() {
    setShowForm(false);
  }

  function handleDelete(name) {
    const updatedTasks = [...tasks];
    const index = updatedTasks.findIndex(task => task.name == name);
    updatedTasks.splice(index, 1);
    setTasks(updatedTasks);

  }

  function handleSave(task) {
    const updatedTasks = [...tasks, { ...task }];
    setTasks(updatedTasks);
  }

  function handleEdit(name, task) {

    const updatedTasks = [...tasks];
    const taskToEdit = updatedTasks.find(single => single.name == name);
    taskToEdit.name = task.name;
    setTasks(updatedTasks);
  }

  return (
    <section className="todoListCmpt">
      <button onClick={handleAdd}>Add task</button>
      {showForm && <TodoForm onCancel={handleCancel} onSave={handleSave} />}
      <List entries={tasks} onDelete={handleDelete} onEdit={handleEdit} />
    </section>
  )
}