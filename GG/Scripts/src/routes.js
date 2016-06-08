import React from 'react';
import {IndexRoute, Route} from 'react-router';
import { loadAuthToken } from './actions/auth';
import configs from './configs';
import sessionStorage from './utils/sessionStorage';
import {
  App,
  Home,
  Login,
  Register,
  Profile,
  NotFound
} from './containers';

export default (store) => {
  const requireLogin = (nextState, replace, cb) => {
    function checkAuth() {
      const { auth: { token }} = store.getState();
      if (!token) {
        // oops, not logged in, so can't be here!
        replace('/login');
      }
      cb();
    }
    const { auth: { loaded }} = store.getState();
    if (!loaded) {
      const authToken = sessionStorage.get(configs.authToken);
      store.dispatch(loadAuthToken(authToken));
      checkAuth();
    } else {
      checkAuth();
    }
  };

  /**
   * Please keep routes in alphabetical order
   */
  return (
    <Route path='/' component={App}>

      { /* Routes requiring login */ }

      <IndexRoute component={Home} onEnter={requireLogin}/>

      <Route path='login' component={Login}/>

      <Route path='register' component={Register}/>

      <Route path='profile' component={Profile} onEnter={requireLogin}/>

      { /* Catch all route */ }
      <Route path='*' component={NotFound} status={404}/>
    </Route>
  );
};
