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
            .state('product.add', {
                url: '/product/add',
                emplateUrl: 'Script/app/product/add/product.add.view.html',
            });
    }
})();