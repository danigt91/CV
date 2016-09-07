(function ($, angular) {

    angular.module("app")
    .controller("AppCtrl", ["$scope", "$rootScope", function ($scope, $rootScope) {

        $rootScope.appRoot = "/"

        $rootScope.technologyProvided = "";
        $rootScope.appName = "";
        $rootScope.autor = "";

        $rootScope.footer = $rootScope.technologyProvided + " - " + $rootScope.appName;

        $scope.$watch("[$root.technologyProvided, $root.appName, $root.autor]", function () {
            $rootScope.footer =
                $rootScope.technologyProvided + " - " +
                $rootScope.appName + " - " +
                $rootScope.autor;
        });

    }]);

})(jQuery, angular);