(function ($, angular) {

    angular.module("app")
    .controller("AppCtrl", ["$scope", "$rootScope", function ($scope, $rootScope) {

        $rootScope.appRoot = "/"
        $rootScope.appName = "View Streaming Seek";

    }]);

})(jQuery, angular);