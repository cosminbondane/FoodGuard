(function () {
    'use strict';

    angular
        .module('app.product')
        .config(configRoute);

    configRoute.$inject = ['$stateProvider'];

    function configRoute($stateProvider) {
        $stateProvider
            .state('offer', {
                url: '/offer',
                templateUrl: 'Script/app/product/offer/product.offer.html',
                controller: 'productOfferController',
                controllerAs: 'vm'
            })
            .state('products', {
                url: '/products/:type',
                templateUrl: 'Script/app/product/list/product.list.html',
                controller: 'productListController',
                controllerAs: 'vm'
            })
            .state('products_add', {
                url: '/products/add',
                templateUrl: 'Script/app/product/add/product.add.view.html',
                controller: 'productAddController',
                controllerAs: 'vm'
            })
            .state('products_edit', {
                url: '/products/edit/:id',
                templateUrl: 'Script/app/product/add/product.add.view.html',
                controller: 'productAddController',
                controllerAs: 'vm'
            });
    }
})();