<script  lang="ts">
    export default {
        name: 'Home',
        data() {
          return {}
        },
        mounted() {
            if(!this.$parent?.$attrs.authenticated) {
                this.$router.replace({ name: "Login" });
            }
        },
        methods: {
        }
    }
</script>

<template>
  <head>
<link rel="stylesheet" href="components.css">
</head>
<body>
<table>
    <thead>
      <tr>
        <th>Component name</th>
        <th>Price</th>
        <th>Max capacity</th>

      </tr>
    </thead>
    <tbody>
      <tr>
        <td>Gyászos zsiradék</td>
        <td>1000 Ft</td>
        <td>5 db</td>
        <td><button onclick="modifyPrice(1)">Price modify</button></td>
      </tr>
      <tr>
        <td>Alkatrész 2</td>
        <td>2000 Ft</td>
        <td>10 db</td>
        <td><button>Ár módosítása</button></td>
      </tr>
      <tr>
        <td>Alkatrész 3</td>
        <td>3000 Ft</td>
        <td>15 db</td>
        <td><button onclick="modifyPrice(2)">Ár módosítása</button></td>
      </tr>
    </tbody>
  </table>
</body>
<div>
    <label for="component-name">Component's name:</label>
    <input type="text" id="component-name" name="component-name"><br><br>
    <label for="component-price">Price:</label>
    <input type="text" id="component-price" name="component-price"><br><br>
    <label for="component-max-count">Max capacity:</label>
    <input type="text" id="component-max-count" name="component-max-count"><br><br>
    <input type="submit" value="Component add">
</div>
  
</template>