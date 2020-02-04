import * as signalR from '@aspnet/signalr'
import React, { useState, useEffect } from 'react'

export default function Chat() {
  const USERNAME = 'daniel'
  const [connection, setConnection] = useState()
  const [messageLog, setLog] = useState([])
  const [text, setText] = useState('')
  useEffect(() => {
    const protocol = new signalR.JsonHubProtocol()
    setConnection(() => new signalR.HubConnectionBuilder()
      .withUrl('https://localhost:44315/draw')
      .withHubProtocol(protocol)
      .build()
    )
  }, []);
  useEffect(() => {
    if (connection) {
      connection.start().catch(err => console.error(err, 'red'));
      connection.on('draw', receiveMessage);
    }
  }, [connection]);
  function receiveMessage(_user, _message) {
    console.log('messageLog', messageLog)
    setLog([...messageLog, { user: _user, message: _message }])
  }
  function sendMessage() {
    connection.invoke('draw', text, USERNAME)
  }
  function generateMessages() {
    return messageLog.map(elem => {
      return (
        <>
          <section className="user">{elem.user}</section>
          <section className="messageLog">{elem.message}</section>
        </>
      )
    })
  }
  return (
    <section className="chatCmpt">
      <input onChange={(e) => setText(e.target.value)} value={text} />
      <button onClick={sendMessage}>SEND</button>
      {generateMessages()}
    </section>
  )
}
