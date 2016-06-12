﻿// <autogenerated>
//   This file was generated by T4 code generator Entry.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


import * as blogTypeTypes from '../contants/blogType';

export function getAll() {
  return {
    types: [blogTypeTypes.GET_ALL_BLOGTYPE, blogTypeTypes.GET_ALL_BLOGTYPE_SUCCESS, blogTypeTypes.GET_ALL_BLOGTYPE_FAIL],
    promise: (client) => client.get('/blogType',{
      token: true
    })
  };
}

export function getById(id) {
  return {
    types: [blogTypeTypes.GET_ONE_BLOGTYPE, blogTypeTypes.GET_ONE_BLOGTYPE_SUCCESS, blogTypeTypes.GET_ONE_BLOGTYPE_FAIL],
    promise: (client) => client.get('/blogType'+id,{
      token: true
    })
  };
}

export function create(data) {
  return {
    types: [blogType.CREATE_BLOGTYPE, blogType.CREATE_BLOGTYPE_SUCCESS, blogType.CREATE_BLOGTYPE_FAIL],
    promise: (client) => client.post('/blogType', {
      data: data,
	  token: true
    })
  };
}

export function update(id, data) {
  return {
    types: [blogType.UPDATE_BLOGTYPE, blogType.UPDATE_BLOGTYPE_SUCCESS, blogType.UPDATE_BLOGTYPE_FAIL],
    promise: (client) => client.put('/blogType/'+id, {
      data: data,
	  token: true
    })
  };
}

export function delete(id) {
  return {
    types: [blogType.DELETE_BLOGTYPE, blogType.DELETE_BLOGTYPE_SUCCESS, blogType.DELETE_BLOGTYPE_FAIL],
    promise: (client) => client.delete('/blogType/'+id, {
		token: true
    })
  };
}
