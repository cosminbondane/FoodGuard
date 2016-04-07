(function () {
    'use strict';

    angular
        .module('app.subscribe')
        .factory('SubscribeService', SubscribeService);

    SubscribeService.$inject = ['Rest'];
    /* @ngInject */
    function SubscribeService(REST) {
        return {
            subscribe: function (email) {
                return REST.subscribe().save(email).$promise;
           }
        }
    }
})();
