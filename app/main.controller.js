
(function() {
   'use strict';

   angular
   // naming module myApp
       .module('topspotApp')
       // naming controller mainController
       .controller('mainController', mainController);

   mainController.$inject = ['$http'];

   /* @ngInject */
   function mainController($http) {
       var vm = this;
       vm.title = 'mainController';

       activate();

       ////////////////
// function that gets the json data
       function activate() {
           $http({
               method:"GET",
               url:"http://localhost:50135/api/topspots"
           }).then(function(response) {
               vm.topSpots = response.data;
           });
       }
   }
})();