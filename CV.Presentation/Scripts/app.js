define(['angularAMD', 'ui.router'], function (angularAMD) {
    
    var app = angular.module("app", ["ui.router"]);

    app.config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {

        $stateProvider
            .state('home', {
                abstract: true,
                views: {
                    'menu': angularAMD.route({
                        templateUrl: 'App/MenuPublico',
                        controllerUrl: 'controllers/Menu/MenuPublicCtrl'
                    }),
                    'content': angularAMD.route({
                        templateUrl: 'Home/Home',
                        controllerUrl: 'controllers/Home/HomeCtrl'
                    })
                }
            })
            .state('video', {
                abstract: true,
                views: {
                    'menu': angularAMD.route({
                        templateUrl: 'App/MenuPublico',
                        controllerUrl: 'controllers/Menu/MenuPublicCtrl'
                    }),
                    'content': angularAMD.route({
                        templateUrl: 'Video/Index',
                        controllerUrl: 'controllers/Home/VideoCtrl'
                    })
                }
            })
            .state('home.index', angularAMD.route({
                url: '/home'
            }))
            .state('video.index', angularAMD.route({
                url: '/video'
            }))
        ;

        // Else
        $urlRouterProvider
        .otherwise('/home');
    }]);

    //return angularAMD.bootstrap(app);
    return app;
});