<script setup lang="ts">
  import { onMounted } from 'vue'
  import { Loader } from '@googlemaps/js-api-loader';

  const GOOGLE_MAPS_API_KEY = "";

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

  onMounted(() => {
    // Promise
    loader
      .load()
      .then((google) => {
        new google.maps.Map(document.getElementById("map")!, mapOptions);
      })
      .catch(e => {
        // do something
        console.log("map not working")
        console.log(e)
      });
  })

</script>

<template>
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
