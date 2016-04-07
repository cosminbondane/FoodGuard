(function () {
    'use strict';

    angular
        .module('app.product')
        .config(['$stateProvider', function ($stateProvider) {

            $stateProvider
                .state('product', {
                    url: '/product',
                    templateUrl: 'Script/app/product/view/product.view.html',
                    controller: 'productViewController',
                    controllerAs: 'vm'
                })
                .state('product.add', {
                    url: '/product/add',
                    templateUrl: 'Script/app/product/add/product.add.view.html',
                });
        }]);
})();