import AsyncStorage from '@react-native-community/async-storage'
import { persistReducer } from 'redux-persist';

import { SET_LOADING, SET_TAB_SCREEN_NAME } from '../actions/globalActions';
import Settings from '../../config/settings';

const initialState = {
  isBusyIndicatorShown: false
};

const GlobalReducer = (state = initialState, action) => {
  switch (action.type) {
    case SET_LOADING: {
      return { ...state, loading: action.loading }
    }
    case SET_TAB_SCREEN_NAME: {
      return { ...state, tabScreenName: action.tabScreen }
    }
    default: {
      return state;
    }
  }
};

const persistConfig = {
  key: 'global',
  storage: AsyncStorage,
  blacklist: ['isBusyIndicatorShown']
};

export default persistReducer(persistConfig, GlobalReducer);