import './style.css'
import * as signalR from '@aspnet/signalr'
import React, { useRef, useState, useEffect } from 'react'
import { postMessage } from '../../requestAPI/ChatService'
export default function Chat() {
  const SIGNALR_HUB = '/ChatHub'
  const SERVER_URL = process.env.REACT_APP_CHAT_SERVICE
  const [connection, setConnection] = useState()
  const [messageLog, setLog] = useState()
  const [text, setText] = useState('')
  const [user, setUser] = useState(null)
  const [show, setShow] = useState(false)
  const chatRef = useRef()
  useEffect(() => {
    setLog([])
    const protocol = new signalR.JsonHubProtocol()
    setConnection(() => new signalR.HubConnectionBuilder()
      .withUrl(`${SERVER_URL}${SIGNALR_HUB}`)
      .withHubProtocol(protocol)
      .build()
    )
  }, []);
  useEffect(() => {
    if (connection) {
      connection.start().catch(err => console.error(err, 'red'));
      connection.on('getMessage', receiveMessage);
    }
  }, [connection]);
  function receiveMessage(_user, _message) {
    setLog(log => [...log, { user: _user, message: _message }])
  }
  function sendMessage() {
    postMessage({ text, user })
    // connection.invoke('getMessage', text, user)
    setText('')
  }
  function generateMessages() {
    return messageLog.map((elem, index) => {
      const isSelf = elem.user === user ? ' self' : ''
      return (
        <section className={`message${isSelf}`} key={index}>
          <section className="body">
            <section className="user">{elem.user}</section>
            <section className="messageLog">{elem.message}</section>
          </section>
        </section>
      )
    })
  }
  function saveUser() {
    const userName = chatRef.current.querySelector('input.username').value
    setUser(userName)
  }
  return (
    <section className="chatCmpt" ref={chatRef}>
      {
        show ||
        <section className="register">
          <input onChange={saveUser} type="text" className="username" placeholder="username" />
          <button onClick={() => setShow(true)} disabled={!user}>{'REGISTER'}</button>
        </section>
      }
      {
        !show ||
        <section className="chat">
          <section className="feed">
            {generateMessages()}
          </section>
          <section className="message-input">
            <input onChange={(e) => setText(e.target.value)} value={text} />
            <section className="send" onClick={sendMessage}>
              <img src={'./send.png'} alt={''} />
            </section>
          </section>
        </section>
      }
    </section>
  )
}
