(function () {
    'use strict'

    angular
        .module('app.product')
        .controller('productListController', productListController);

    productListController.$inject = ['ProductService'];

    function productListController(ProductService) {
        var vm = this;

        ProductService.getProductList().then(function (result) {
            vm.products = result;
        }, function (error) {
            alert(error.message);
        });
    }

})();