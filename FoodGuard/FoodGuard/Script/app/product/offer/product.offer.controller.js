(function () {
    'use strict';

    angular
        .module('app.product')
        .controller('productOfferController', productOfferController);

    productOfferController.$inject = ['ProductService'];

    function productOfferController(ProductService) {
        var vm = this;
        vm.products = [];
        vm.right = 1;

        init();

        function init() {

           ProductService.getProductList().then(function (response) {
                if (response != undefined) {
                    vm.products = response;

                    angular.forEach(vm.products, function (item) {
                        item.isRight = isRight();
                    })
                }
            });

          
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