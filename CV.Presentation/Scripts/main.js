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
        "kendo.all.min": "http://kendo.cdn.telerik.com/2016.1.406/js/kendo.all.min",
        "kendo-culture": "libs/kendo/2016.3.914/cultures/kendo.culture." + document.culture + ".min",
        "kendo-messages": "libs/kendo/2016.3.914/messages/kendo.messages." + document.culture + ".min"
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
        "kendo.all.min": { deps: ["angular"] },
        "kendo-culture": ['kendo.all.min'],
        "kendo-messages": ['kendo-culture']
        //'ngRoute': ['angular']
    },    
    deps: ['angularAMD', 'app', 'controllers/App/AppCtrl'],
    callback: function (angularAMD, app, appCtrl) {
        //debugger;
        angularAMD.bootstrap(app);
    }
});