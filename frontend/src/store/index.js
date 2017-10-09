import Vuex from 'vuex'
const store = new Vuex.Store({
  state: {
    profile: {}
  },
  mutations: {
    loggedIn (state, profile) {
      this.$state.profile = profile
    }
  },
  actions: {
    login (context, username, password) {
      context.commit('loggedIn', {username: 'hoanggia.lh@gmail.com', firstName: 'Le Huu', lastName: 'Hoang Gia'})
    }
  }
})
export default store
