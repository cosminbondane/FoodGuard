(function () {
    'use strict';

    angular
        .module('app')
        .run(appRun);

    appRun.$inject = ['$rootScope'];

    function appRun($rootScope) {

        $rootScope.$on('$stateChangeStart', function (event, toState, toParams, fromState) {
            //console.log('To state: ' + toState);
            //console.log('From state: ' + fromState);
        });
    }

})();