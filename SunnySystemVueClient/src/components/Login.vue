<script lang="ts">
import { Axios } from 'axios';
import axios from 'axios';
import { defineComponent } from 'vue';

export default defineComponent({
  data() {
    return {
      username: "",
      password: "",
      seen:""
    };
  },
  methods: {
    submittingPage() {
      
      axios.post("http://127.0.0.1:1337/login",{
        username: this.username,
        password: this.password,
      }
      //  {
      //   headers: {
      //   'Content-Type': 'application/json',
      //   'Access-Control-Allow-Origin': '*',
      //   'Access-Control-Allow-Methods': 'POST',
      //   'Access-Control-Allow-Headers': 'Content-Type'
      //   }
      // } 
      ).then((response) => {
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

</script>
<template>
			<h1>{{username}}</h1>
				<span v-if="seen">Now you see me</span>
        <label for="username">Username:</label> 
        <input type="text" id="username" name="username"
					v-model="username"
					v-on:keyup.enter="submittingPage"
				><br>
        <label for="password">Password:</label> 
				<input type="password"  id="password" name="password"
					v-model="password"
					v-on:keyup.enter="submittingPage"
				><br>
        <input v-on:click="submittingPage" type="submit" value="Login">
</template>

<style scoped>
body {
  background-color: #f2f2f2;
  font-family: Arial, sans-serif;
  font-size: 16px;
}
.login {
  background-color: #ffffff;
  border: 1px solid #cccccc;
  border-radius: 5px;
  padding: 20px;
  margin: 50px auto;
  max-width: 400px;
  text-align: center;
}
input[type=text], input[type=password] {
  padding: 10px;
  margin: 5px 0;
  border: 1px solid #cccccc;
  border-radius: 5px;
  width: 100%;
  box-sizing: border-box;
}
input[type=submit] {
  background-color: #4CAF50;
  color: #ffffff;
  padding: 10px;
  border: none;
  border-radius: 5px;
  cursor: pointer;
  width: 100%;
  font-size: 16px;
}
input[type=submit]:hover {
  background-color: #45a049;
}
</style>