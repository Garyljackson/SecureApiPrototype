'use strict';
app.factory('securePingService', ['$http', function ($http) {

    var serviceBase = 'https://localhost:44307/';
    var securePingServiceFactory = {};

    var _securePing = function () {

        return $http.get(serviceBase + 'api/v1/securePing').then(function (results) {
            return results;
        });
    };

    securePingServiceFactory.securePing = _securePing;

    return securePingServiceFactory;

}]);