'use strict';

var app = angular.module('secureServiceApp', ['ngRoute']);

app.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/home', {
            templateUrl: '/app/views/home.html',
            controller: 'homeController'
        }).
        when('/securePing', {
            templateUrl: '/app/views/securePing.html',
            controller: 'securePingController'
        }).
        otherwise({
            redirectTo: '/home'
        });
  }]);

