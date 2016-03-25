var app = angular.module('pageRoutingApp');

app.controller('TelephoneController', ['$scope', '$http', function ($scope, $http) {
    $scope.SiteSubCategory = [];       
    $http.get('/home/GetMenu_Data').then(function (data) {
                     
        $scope.SiteSubCategory = data.data;
           
    }, function (error) {
        alert('Error');
    })
        
}]);