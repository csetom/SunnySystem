<script setup>
defineProps({
  password: {
    type: String,
    required: true
  },
  username: {
    type:String,
    required:true
  }

})
function submittingPage() {
  axios.post("https://jsonplaceholder.typicode.com/users",{
        username: this.username,
        password: this.password,
  });
  console.log(response);
};

</script>
<template>
			<h1>{{username}}</h1>
				<span v-if="seen">Now you see me</span>
        <label for="username">Username:</label> 
        <input type="text" id="username" name="username"
					v-bind="username"
					v-on:keyup.enter="submittingPage"
				><br>
        <label for="password">Password:</label> 
				<input type="password"  id="password" name="password"
					v-bind="password"
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