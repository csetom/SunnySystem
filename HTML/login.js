
var loginForm = new Vue({
  el: '#loginForm',
  data: {
    username:"",
    password:""
  },
  methods: {
    submittingPage: function() {
      // prevent the form from submitting 
      const username = this.username; 
      const password = this.password; 
      // perform some validation here (e.g. check if the username and password are correct) 
      if (username === 'admin' && password === 'password') { 
        window.location.href = 'components.html';
      // redirect to the new page 
      } else { 
        alert('Invalid username or password'); 
      // display an error message 
      } 
    }
  }
});
