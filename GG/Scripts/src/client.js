import 'babel-polyfill';
import './polyfills';
import React from 'react';
import ReactDOM from 'react-dom';
import { Router, browserHistory, RouterContext} from 'react-router';
import { createStore, applyMiddleware } from 'redux'
import { Provider } from 'react-redux';
import clientMiddleware from './middleware/clientMiddleware'
import createRoutes from './routes'
import ApiClient from './utils/ApiClient';
import fetchData from './utils/fetchData';
import sessionStorage from './utils/sessionStorage';
import reducers from './reducers'
import configs from './configs';
import 'antd/lib/style/index.css';

sessionStorage.setNamespace('dotaeye');

const createStoreWithMW = applyMiddleware(clientMiddleware(new ApiClient()))(createStore);
const store = createStoreWithMW(reducers);
const routes = createRoutes(store);

window.React = React; // enable debugger
ReactDOM.render(
  <Provider store={store} key="provider">
    <Router routes={routes} history={browserHistory} onUpdate={UpdateRoute}/>
  </Provider>,
  document.getElementById('main')
);

function UpdateRoute() {
  fetchData(store, this.state)
}