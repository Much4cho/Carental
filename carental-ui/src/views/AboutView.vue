<script setup lang="ts">
  import axios, { type AxiosRequestHeaders } from 'axios';
  import { onMounted } from 'vue';
  import Greet from './Greeting.vue';

  let email: string = 'dinesh@fusionauth.io';

  onMounted(() => {
    axios.get("https://localhost:7250/api/auth", {
      withCredentials: true, // fetch won't send cookies unless you set credentials,
      // headers: {
      //   origin: 'http://127.0.0.1:5173/'
      // }
    })
    .then(response => {
      console.log(response.data);
      email = response.data.email;
    });


    // fetch(`https://localhost:7250/api/user`, {
    //   credentials: "include" // fetch won't send cookies unless you set credentials
    // })
    //   .then(response => response.json())
    //   .then(data => console.log(data))
    //   .then(data => (email = data.user.email));
  });
  
</script>

<template>
  <div>
    <header>
      <h1>FusionAuth Example Vue</h1>
    </header>
    <div id='container'>
      <Greet v-bind:email="email"/>
    </div>
  </div>
</template>

<style>
h1 {
  text-align: center;
  font-size: 40px;
  font-family: Arial, Helvetica, sans-serif;
}

#container {
  box-sizing: border-box;
  border: 5px solid gray;
  border-radius: 15%;
  width: 400px;
  height: 400px;
  margin: auto;
}
</style>

<!-- <template>
  <div class="about">
    <h1>This is an about page</h1>
  </div>
</template>

<style>
@media (min-width: 1024px) {
  .about {
    min-height: 100vh;
    display: flex;
    align-items: center;
  }
}
</style> -->
