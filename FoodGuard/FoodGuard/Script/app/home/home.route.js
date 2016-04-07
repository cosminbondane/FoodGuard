(function () {
    'use strict';

    angular
        .module('app.home')
        .config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
            $stateProvider
                .state('default', {
                    url: '/home',
                    templateUrl: 'Script/app/home/home.view.html'
                });
        }]);
})();