<script setup lang="ts">
  import { computed, onBeforeMount, onMounted, reactive, ref } from 'vue'
  import axios from 'axios';

  let isFetching: boolean = true;
  const cars: Car[] = ref(Car[]);

  onMounted(() => {
    axios.get("https://localhost:7250/api/cars")
    .then(response => {
      cars.splice(0); 
      cars.push(response.data);
      isFetching = false;
      console.log(cars);
    });
  });

</script>

<template>
  <div class="cars">
    <div v-for="car in cars">test</div>
    <ul>
      <li v-for="car in cars">
        {{ car.id }}
      </li>
    </ul>
  </div>
</template>

<style scoped>

</style>
