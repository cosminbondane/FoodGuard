(function () {
    'use strict';

    angular
        .module('app.product')
        .controller('productAddController', productAddController);

    productAddController.$inject = ['$state', 'ProductService'];

    function productAddController(ProductService) {
        var vm = this;
        vm.product = {};

        var isEdit = $state.params.id;

        if (isEdit) {
            vm.product = angular.copy(ProductService.getProductById($state.params.id));
        }

        function addProduct() {
            if (isEdit) {
                ProductService.editProduct(vm.product);
            }
            else {
                ProductService.addProduct(vm.product);
            }
        }
    }

})();