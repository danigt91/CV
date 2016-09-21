define(['angularAMD', 'ui.router', 'common'], function (angularAMD) {
    
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
            .state('home.index', angularAMD.route({
                url: '/home'
            }))
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
            .state('video.index', angularAMD.route({
                url: '/video'
            }))
            .state('account', {
                abstract: true,
                views: {
                    'menu': angularAMD.route({
                        templateUrl: 'App/MenuPublico',
                        controllerUrl: 'controllers/Menu/MenuPublicCtrl'
                    }),
                    'content': angularAMD.route({
                        templateUrl: 'Account/Index',
                        controllerUrl: 'controllers/Account/AccountCtrl'
                    })
                }
            })
            .state('account.login', angularAMD.route({
                url: '/login',
                templateUrl: 'Account/Login',
                controllerUrl: 'controllers/Account/AccountLoginCtrl'
            }))
            .state('account.register', angularAMD.route({
                url: '/register',
                templateUrl: 'Account/Register',
                controllerUrl: 'controllers/Account/AccountRegisterCtrl'
            }))
        ;

        // Else
        $urlRouterProvider
        .otherwise('/home');
    }]);

    //return angularAMD.bootstrap(app);
    return app;
});