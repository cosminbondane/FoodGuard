(function () {
    'use strict'

    angular
        .module('app.product')
        .controller('productListController', productListController);

    productListController.$inject = ['$state', 'ProductService'];

    function productListController($state, ProductService) {
        var vm = this;
        vm.category = 'Bakery';

        var typeId = parseInt($state.params.id);

        if (typeId === 0) {
            ProductService.getProductList().then(function (result) {
                vm.products = result;
            }, function (error) {
                alert(error.message);
            });
        } else {
            ProductService.getProductsByTypeId(typeId).then(function (result) {
                vm.products = result;
            }, function (error) {
                alert(error.message);
            });
        }
    }

})();