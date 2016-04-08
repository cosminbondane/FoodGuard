(function () {
    'use strict';

    angular
        .module('app')
        .config(['$urlRouterProvider', '$stateProvider', '$locationProvider', function ($urlRouterProvider, $stateProvider, $locationProvider) {
            
            $urlRouterProvider.when('', '/default');

            $urlRouterProvider.otherwise('/default');

            $stateProvider
                .state('default', {
                    url: '/',
                    templateUrl: 'Script/app/home/home.view.html'
                });
        }]);
})();