
var app = angular.module('pageRoutingApp');

app.controller('AccessoriesController', ['$scope', '$http', '$location', function ($scope, $http, $location) {
    $scope.SiteSubCategory = [];
    $http.get('/home/GetMenu_Data').then(function (data) {

        $scope.SiteSubCategory = data.data;

    }, function (error) {
        alert('Error');
    })

    $scope.btnfun = function () {
        $location.path("/test");
    }

}]);