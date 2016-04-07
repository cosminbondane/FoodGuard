(function () {
    'use strict';

    angular
        .module('app.common')
        .factory('Rest', RestService);

    RestService.$inject = ['$resource'];
    /* @ngInject */
    function RestService($resource) {

        var factory = function () { };

        var service = {
            subscribe: function () { return $resource("/api/Subscribe/Subscribe"); },
            products: function () { return $resource("/api/Product/GetProducts") }
        };

        return service;
    }
})();
