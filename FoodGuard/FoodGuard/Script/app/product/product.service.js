(function () {
    'use strict'

    angular
        .module('app.product')
        .factory('ProductService', ProductService);

    ProductService.$inject = ['$q', 'Rest'];

    function ProductService($q, RestService) {

        var service = {};

        service.getProductById = getProductById;
        service.addProduct = addProduct;
        service.editProduct = editProduct;
        service.viewProduct = viewProduct;
        service.getProductList = getProductList;
        service.getProductsByTypeId = getProductsByTypeId;
        service.getOffersByTypeId = getOffersByTypeId;

        function getProductById(productId) {

        }
        function addProduct(newProduct) {
        }
        function editProduct(currentProduct) {
        }
        function viewProduct(productId) {
        }

        function getProductList() {
            var deferred = $q.defer();

            RestService.products().get().$promise.then(function (response) {
                if (response.success) {
                    deferred.resolve(response.data);
                } else {
                    deferred.reject(response.error);
                }
            });

            return deferred.promise;
        }

        function getProductsByTypeId(typeId) {
            var deferred = $q.defer();

            RestService.productsByTypeId().get({ typeId: typeId }).$promise.then(function (response) {
                if (response.success) {
                    deferred.resolve(response.data);
                } else {
                    deferred.reject(response.error);
                }
            });

            return deferred.promise;
        }

        function getOffersByTypeId(typeId, days) {
            var deferred = $q.defer();

            RestService.offersByTypeId().get({ typeId: typeId, days: days }).$promise.then(function (response) {
                if (response.success) {
                    deferred.resolve(response.data);
                } else {
                    deferred.reject(response.error);
                }
            });

            return deferred.promise;
        }

        return service;
    }

})();