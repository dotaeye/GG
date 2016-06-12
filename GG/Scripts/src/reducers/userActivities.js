﻿// <autogenerated>
//   This file was generated by T4 code generator Entry.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


import * as userActivitiesTypes from '../contants/userActivities';

const initialState = {
};

export default function userActivities(state = initialState, action = {}) {
	switch (action.type) {
		case authTypes.GET_ALL_USERACTIVITIES:
		case authTypes.GET_ONE_USERACTIVITIES:
		case authTypes.CREATE_USERACTIVITIES:
		case authTypes.UPDATE_USERACTIVITIES:
		case authTypes.DELETE_USERACTIVITIES:
			return {
				...state,
				loading: true
			};
		case authTypes.GET_ALL_USERACTIVITIES_FAIL:
		case authTypes.GET_ONE_USERACTIVITIES_FAIL:
		case authTypes.CREATE_USERACTIVITIES_FAIL:
		case authTypes.UPDATE_USERACTIVITIES_FAIL:
		case authTypes.DELETE_USERACTIVITIES_FAIL:
			return {
				...state,
				loading: false,
				error: action.error
			};
		case authTypes.GET_ALL_USERACTIVITIES_SUCCESS:
			return {
				...state,
				loading: false,
				list: action.result
			};
		case authTypes.GET_ONE_USERACTIVITIES_SUCCESS:
			return {
				...state,
				loading: false,
				entity: action.result
			};
		case authTypes.CREATE_USERACTIVITIES_SUCCESS:
			return {
				...state,
				loading: false,
				entity: action.result
			};
		case authTypes.UPDATE_USERACTIVITIES_SUCCESS:
			return {
				...state,
				loading: false,
				entity: action.result
			};
		case authTypes.DELETE_USERACTIVITIES_SUCCESS:
			return {
				...state,
				loading: false,
				entity: action.result
			};
		default:
			return state;
  }
}

