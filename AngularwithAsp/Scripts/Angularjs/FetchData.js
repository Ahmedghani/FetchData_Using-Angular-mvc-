angular.module('MyApp')

 .controller('fetchdata', function ($scope,contactservice)
{
     $scope.contact = null;
     contactservice.GetData().then(function(d){
         $scope.contact = d.data;

     }, function () {
         alert('failed');
     })
})
.factory('contactservice', function ($http) {
    var faac = {};
    faac.GetData = function () {
        return $http.get('/Data/GetData');
    }
    return faac;
});