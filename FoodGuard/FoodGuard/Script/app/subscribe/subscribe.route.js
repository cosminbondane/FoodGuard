(function () {
    'use strict';

    angular
        .module('app.subscribe')
        .config(configProductRoute);

    configProductRoute.$inject = ['$stateProvider'];

    function configProductRoute($stateProvider) {
        $stateProvider
            .state('subscribe', {
                url: '/subscribe',
                templateUrl: 'Script/app/subscribe/subscribe.html',
                controller: 'subscribeController',
                controllerAs: 'vm'
            })
    }

})();