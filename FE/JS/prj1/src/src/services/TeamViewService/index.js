import httpClient from '../TeamViewRequest';

class UsersService {

  async getAllUsers() {
    return await httpClient.get('users/');
  }
}

export default new UsersService()