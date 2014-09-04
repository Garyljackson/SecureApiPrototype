'use strict';

app.controller('securePingController', ['$scope', 'securePingService', function ($scope, securePingService) {

    securePingService.securePing().then(function(results) {
        $scope.pingResponse = results.data;
    }, function (error) {
        alert(error.data.message);
    });

}]);