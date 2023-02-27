const loginForm = Vue.createApp({
  data() {
    return {
      username: "",
      password: "",
 
    };
  },
  methods: {
    submittingPage() {
      axios.post("https://jsonplaceholder.typicode.com/users",{
        username: this.username,
        password: this.password,
      }).then((response) => {
        // V0: Belephet / nem lephet be
        // V1: Jogosultsagot
        // V2: tokent-> felhasznalo azonositasara alkalmas
/*      if (respone.data.belephet) {
          console.log("Belephet");
        } else {
          console.log("Nem");
        }
*/
        console.log(response);
      });
    },
    
  },

});

const usersDiv = Vue.createApp({
  data() {
    return {
      users: [],
      loading: true,
    };
  },
  mounted() {
    axios.get("https://jsonplaceholder.typicode.com/users").then((response) => {
      this.users = response.data;
      this.loading = false;
    });
  },
});

loginForm.mount("#loginForm");
usersDiv.mount("#Users");
