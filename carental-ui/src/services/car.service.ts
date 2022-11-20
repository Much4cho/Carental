import axios from 'axios'

export default class CarService {

    getAll() {
        axios.get('"https://localhost:7250/api/cars"')
        .then(function (response) {
          // handle success
          console.log(response);
        })
        .catch(function (error) {
          // handle error
          console.log(error);
        })
        .then(function () {
          // always executed
        });
    }
  
  }