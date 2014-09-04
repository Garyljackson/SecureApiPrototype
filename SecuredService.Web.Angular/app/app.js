'use strict';

var app = angular.module('secureServiceApp', ['ngRoute']);

app.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/home', {
            templateUrl: '/app/views/home.html',
            controller: 'homeController'
        }).
        otherwise({
            redirectTo: '/home'
        });
  }]);

