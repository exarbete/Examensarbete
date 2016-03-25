var app = angular.module('pageRoutingApp');
app.controller('menuController', ['$scope', '$http', function ($scope, $http) {
    $scope.SiteMenu = [];
    $http.get('/home/GetMenu_Data').then(function (data) {
        var menues = data.data;
        $scope.SiteMenu = menues;

     
    }, function (error) {
        alert('Error');
    })

}]);