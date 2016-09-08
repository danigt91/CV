define(['app'], function (app) {
    app
    .controller("AppCtrl", ["$scope", "$rootScope", function ($scope, $rootScope) {

        $rootScope.AppRoot = "/"

        $rootScope.TechnologyProvided = "";
        $rootScope.AppName = "";
        $rootScope.Autor = "";

        $rootScope.Footer = $rootScope.TechnologyProvided + " - " + $rootScope.AppName;

        // Asignacion de resources
        $scope.$watch("resources", function () {
            $rootScope.TechnologyProvided = $scope.resources.TechnologyProvided;
            $rootScope.AppName = $scope.resources.AppName;
            $rootScope.Autor = $scope.resources.Autor;
            $rootScope.Footer =
                $rootScope.TechnologyProvided + " - " +
                $rootScope.AppName + " - " +
                $rootScope.Autor;
        });

    }]);
});