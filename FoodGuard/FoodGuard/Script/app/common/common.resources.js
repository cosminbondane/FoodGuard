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
            products: function () { return $resource("/api/Product/GetProducts") },
            productsByTypeId: function (typeId) { return $resource("/api/Product/GetProductsByTypeId") },
            offersByTypeId: function (typeId, day) { return $resource("/api/Offer/GetOffersByTypeId") }
        };

        return service;
    }
})();
