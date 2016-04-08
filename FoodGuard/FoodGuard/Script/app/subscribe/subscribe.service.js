(function () {
    'use strict';

    angular
        .module('app.subscribe')
        .factory('SubscribeService', SubscribeService);

    SubscribeService.$inject = ['Rest'];
    /* @ngInject */
    function SubscribeService(REST) {
        return {
            subscribe: function (charity) {
                return REST.subscribe().save(charity).$promise;
            }
        }
    }
})();
