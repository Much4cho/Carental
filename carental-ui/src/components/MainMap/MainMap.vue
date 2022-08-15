<script setup lang="ts">
  import { computed, onBeforeMount, onMounted } from 'vue'
  import { Loader } from '@googlemaps/js-api-loader';
  import { useGeolocation } from './geolocation';
import axios from 'axios';

  const GOOGLE_MAPS_API_KEY = "AIzaSyC4pD3y4njWMkTBJ3otX3h5Yp5gvayxoHQ";

  let map: google.maps.Map;
  const loader = new Loader({
    apiKey: GOOGLE_MAPS_API_KEY,
    version: "weekly",
    libraries: ["places"]
  });

  const mapOptions = {
    center: {
      lat: 0,
      lng: 0
    },
    zoom: 4
  };

  let cars: any;

  const { coords } = useGeolocation();
  const currPos = computed(() => ({
    lat: coords.value.latitude,
    lng: coords.value.longitude
  }));

  onBeforeMount(() => {
    axios.get("https://localhost:7250/api/cars")
    .then(response => {
      cars = response.data;
    });
  })

  onMounted(() => {
    // Promise
    loader
      .load()
      .then((google) => {
        setTimeout(() => 
          map = new google.maps.Map(document.getElementById("map")!, {
            center: currPos.value,
            zoom: 13
          }),
          100);

        cars.forEach(car => {
        setTimeout(() => 
          new google.maps.Marker({
            position: {
              lat: car.location.latitude,
              lng: car.location.longitude
            },
            map: map,
          }),
          150);
      });

        // setTimeout(() => 
        //   new google.maps.Marker({
        //     position: {
        //       lat: 50.062027097,
        //       lng: 19.937775766
        //     },
        //     map: map,
        //   }),
        //   150);
          // const marker = new google.maps.Marker({
          //   position: {
          //     lat: 50.062027097,
          //     lng: 19.937775766
          //   },
          //   map: map,
          // });

      })
      .catch(e => {
        // do something
        console.log("map not working")
        console.log(e)
      });
  });

</script>

<template>
  <h3>
    Latitude: {{ currPos.lat.toFixed(2) }}, Longitude: {{ currPos.lng.toFixed(2) }}
  </h3>
  <div id="map">
  </div>
</template>

<style scoped>
  #map {
  display: flex;
  place-items: center;
  place-content: center;
  width: 1000px;
  height: 1000px;
}
</style>
