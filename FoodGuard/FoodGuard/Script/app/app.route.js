(function () {
    'use strict';

    angular
        .module('app')
        .config(['$urlRouterProvider', '$stateProvider', function ($urlRouterProvider, $stateProvider) {
            $urlRouterProvider.otherwise("/home");

            $stateProvider
                .state('default', {
                    url: '/',
                    templateUrl: 'Script/app/home/home.view.html'
                });
        }]);
})();