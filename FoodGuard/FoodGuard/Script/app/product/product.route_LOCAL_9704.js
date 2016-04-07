(function () {
    'use strict';

    angular
        .module('app.product')
        .config(configRoute);

    configRoute.$inject = ['$stateProvider'];

    function configRoute($stateProvider) {
        $stateProvider
            .state('product', {
                url: '/product',
                templateUrl: 'Script/app/product/view/product.view.html',
                controller: 'productViewController',
                controllerAs: 'vm'
            })
            .state('products', {
                url: '/products',
                templateUrl: 'Script/app/product/list/product.list.html',
                controller: 'productListController',
                controllerAs: 'vm'
            })
            .state('product.add', {
                url: '/product/add',
                templateUrl: 'Script/app/product/add/product.add.view.html',
                controller: 'productAddController',
                controllerAs: 'vm'
            })
            .state('product.edit', {
                url: '/product/edit/:id',
                templateUrl: 'Script/app/product/add/product.add.view.html',
                controller: 'productAddController',
                controllerAs: 'vm'
            });
    }
})();