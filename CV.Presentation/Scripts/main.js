require.config({
    baseUrl: "/Scripts",
    paths: {
        'jquery': 'libs/jquery/jquery-2.2.0.min',
        'bootstrap': 'libs/bootstrap/bootstrap',
        'respond': 'libs/respond/respond.js',
        'angular': 'libs/angular/angular',
        'angularAMD': 'libs/angularAMD/angularAMD.min',
        'ngload': 'libs/angularAMD/ngload.min',
        'ui.router': 'libs/angular-ui-router/angular-ui-router'
        //'ngRoute': 'libs/angular-route/angular-route.min'
    },
    shim: {
        'bootstrap': ['jquery'],
        'respond': ['bootstrap'],
        'angular': ['jquery'],        
        'angularAMD': ['angular'],
        'ngload': ['angularAMD'],
        'ui.router': ['angular']
        //'ngRoute': ['angular']
    },    
    deps: ['angularAMD', 'app', 'controllers/App/AppCtrl'],
    callback: function (angularAMD, app, appCtrl) {
        //debugger;
        angularAMD.bootstrap(app);
    }
});