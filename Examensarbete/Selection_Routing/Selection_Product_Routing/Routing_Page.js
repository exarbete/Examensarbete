
    var app = angular.module('pageRoutingApp', ['ngRoute']);


    app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

        $routeProvider
        .when('/', {
            redirectTo: function () {
                return '/home';
            }
        })
        .when('/home', {
            templateUrl: '/Selection_Routing/Selection_Product/Home.html',
            controller: 'HomeController'
        })
        .when('/dator', {
            templateUrl: '/Selection_Routing/Selection_Product/Computer.html',
            controller: 'ComputerController'
        })
        .when('/telefon', {
            templateUrl: '/Selection_Routing/Selection_Product/Telephone.html',
            controller: 'TelephoneController'
        })
        .when('/tillbehor', {
            templateUrl: '/Selection_Routing/Selection_Product/Accessories.html',
            controller: 'AccessoriesController'
        })
        .when('/test', {
            templateUrl: '/Selection_Routing/Selection_Product/Test.html',
            controller: 'TestController'
        })
        
        .when('/ovrigatillbehor', {
            templateUrl: '/Selection_Routing/Selection_Product/Test.html',
            controller: 'TestController'
        })

        .otherwise({
            redirectTo: '/home'
        })

        //$locationProvider.html5Mode(true); 
        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false
        });

    }]);



