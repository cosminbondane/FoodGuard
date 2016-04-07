(function () {
    'use strict';

    angular
        .module('app.home')
        .config(configHomeRoute);

    configHomeRoute.$inject = ['$stateProvider', '$urlRouterProvider'];

    function configHomeRoute($stateProvider, $urlRouterProvider) {

        $urlRouterProvider.when('', '/home');

        $stateProvider
            .state('home', {
                url: '/',
                templateUrl: 'Script/app/home/home.view.html'
            });
    }

})();