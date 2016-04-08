(function () {
    'use strict';

    angular
        .module('app.product')
        .controller('productOfferController', productOfferController);

    productOfferController.$inject = ['$state', 'ProductService'];

    function productOfferController($state, ProductService) {
        var vm = this;
        vm.products = [];
        vm.right = 1;

        init();

        function init() {

            var typeId = $state.params.id;

            if (typeId == 0) {
                ProductService.getOffersByTypeId(0, 7).then(function (response) {
                    if (response != undefined) {
                        vm.products = response;
                    }
                });
            }
            else {
                ProductService.getOffersByTypeId(parseInt(typeId), 7).then(function (response) {
                    if (response != undefined) {
                        vm.products = response;
                    }
                });
            }

            angular.forEach(vm.products, function (item) {
                item.isRight = isRight();
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