import React, { Component, PropTypes } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { Link, browserHistory } from 'react-router'
import { IndexLink } from 'react-router';
import { LinkContainer } from 'react-router-bootstrap';
import { Navbar, Nav, NavItem } from 'react-bootstrap';
import DocumentMeta from 'react-document-meta';
import configs from '../configs';
import * as authActions from '../actions/auth'

var App = React.createClass({

  handleLogout(){
    this.props.actions.logout();
  },

  render() {
    return (
      <div id="app">
        {this.props.children}
      </div>
    );
  }
});

function mapStateToProps(state) {
  return {
    auth: state.auth
  }
}

function mapDispatchToProps(dispatch) {
  return {
    actions: bindActionCreators(authActions, dispatch)
  }
}


export default connect(mapStateToProps, mapDispatchToProps)(App)