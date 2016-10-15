require.config({
    baseUrl: "/Scripts",
    paths: {
        'jquery': 'libs/jquery/jquery-2.2.0.min',
        'bootstrap': 'libs/bootstrap/bootstrap.min',
        'respond': 'libs/respond/respond',
        'angular': 'libs/angular/angular',
        'angularAMD': 'libs/angularAMD/angularAMD.min',
        'ngload': 'libs/angularAMD/ngload.min',
        'ui.router': 'libs/angular-ui-router/angular-ui-router',
        'kendo': 'libs/kendo/2016.3.914/kendo.all.min',
        "kendo.all.min": "http://kendo.cdn.telerik.com/2016.1.406/js/kendo.all.min"
        //'ngRoute': 'libs/angular-route/angular-route.min'
    },
    shim: {
        'bootstrap': ['jquery'],
        'respond': ['bootstrap'],
        'angular': ['jquery'],        
        'angularAMD': ['angular'],
        'ngload': ['angularAMD'],
        'ui.router': ['angular'],
        'kendo': ['angular'],
        "kendo.all.min": { deps: ["angular"] }
        //'ngRoute': ['angular']
    },    
    deps: ['angularAMD', 'app', 'controllers/App/AppCtrl'],
    callback: function (angularAMD, app, appCtrl) {
        //debugger;
        angularAMD.bootstrap(app);
    }
});