// import * as signalR from '@aspnet/signalr'
const signalR = require('@aspnet/signalr')
const SERVER_URL = process.env.REACT_APP_CHAT_SERVICE
const SIGNALR_HUB = '/ChatHub'
const protocol = new signalR.JsonHubProtocol()
const connection = async () => {
  const buildConnection = () => {
    return new signalR.HubConnectionBuilder()
      .withUrl(`${SERVER_URL}${SIGNALR_HUB}`)
      .withHubProtocol(protocol)
      .build()
  }
  const connection = await buildConnection()

  connection.start().catch(err => console.error(err));
  connection.on('getMessage', receiveMessage);
}
console.log(connection())