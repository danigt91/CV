define(['app'], function (app) {
    return function ($scope, $http) {

        $scope.resources = {};

        $scope.user = {};


        $scope.createAccount = function () {
            $http.post("http://localhost:50674/api/Account/Register", $scope.user)
            .then(function (response) {
                debugger;
            }, function (error) {
                debugger;
            });
        }

        $scope.login = function () {
            $http.post("http://localhost:50674/AccountWeb/Login", $scope.user)
            .then(function (response) {
                debugger;
            }, function (error) {
                debugger;
            });
        }

    };
});