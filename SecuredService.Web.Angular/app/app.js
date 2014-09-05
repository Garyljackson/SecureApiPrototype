'use strict';

var app = angular.module('secureServiceApp', ['ngRoute', 'LocalStorageModule']);

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
        when('/login', {
            templateUrl: '/app/views/login.html',
            controller: 'loginController'
        }).
        when('/signup', {
            templateUrl: '/app/views/signup.html',
            controller: 'signupController'
        }).
        otherwise({
            redirectTo: '/home'
        });
  }]);

app.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});

