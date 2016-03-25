var app = angular.module('pageRoutingApp');
    app.controller('HomeController', function ($scope) {
        $scope.Message = "This is HOME page";
        $scope.items = ['Home', 'Dator', 'Mobil', 'Tillbehör', ];
    });
