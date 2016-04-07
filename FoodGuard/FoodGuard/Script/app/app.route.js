(function () {
    'use strict';

    angular
        .module('app')
        .config(['$urlRouterProvider', function ($urlRouterProvider) {
            $urlRouterProvider.otherwise("/home");
        }]);
})();