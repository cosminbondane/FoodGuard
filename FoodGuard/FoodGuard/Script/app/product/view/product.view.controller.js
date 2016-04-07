(function () {
    'use strict';

    angular
        .module('app.product')
        .controller('productViewController', productViewController);

    productViewController.$inject = ['ProductService'];

    function productViewController(ProductService) {
        var vm = this;
        vm.products = [];
        vm.right = 1;

        init();

        function init() {

            ProductService.getProductList().then(function (response) {
                if (response.success) {
                    vm.products = response.data.data;
                }
            });

            angular.forEach(vm.products, function (item) {
                item.isRight = isRight();
            })
        }

        function isRight() {
            var right = false;
            if (vm.right == 1 || vm.right == 2) {
                right = true;
            }

            vm.right++;

            if (vm.right == 3) {
                vm.right = -1;
            }

            return right;
        }
    }

})();