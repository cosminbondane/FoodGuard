(function () {
    'use strict';

    angular
        .module('app.home')
        .config(configRoute);

    configRoute.$inject = ['$stateProvider'];

    function configRoute($stateProvider) {
        $stateProvider
            .state('home', {
                url: '/',
                templateUrl: 'Script/app/home/home.view.html'
            });
    }

})();