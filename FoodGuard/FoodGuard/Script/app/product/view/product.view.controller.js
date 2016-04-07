(function () {
    'use strict';

    angular
        .module('app.product')
        .controller('productViewController', productViewController);

    productViewController.$inject = [];

    function productViewController() {
        var vm = this;
        vm.products = [];
        vm.right = 1;

        init();

        function init() {
            //after service is up
            //ConsumerService.getProducts().then(function (response) {
            //    if (response.success) {
            //        vm.products = [];                 
            //    }
            //});

            var product = {
                name: "Supa de galuste",
                image: "http://foodguard.smallfootprint.net/images/blog/blog-img-1.jpg",
                oldPrice: 10,
                newPrice: 4,
                description: "Cea mai buna supa ever"
            }

            var product1 = {
                name: "Orez cu lapte ",
                image: "http://foodguard.smallfootprint.net/images/blog/blog-img-1.jpg",
                oldPrice: 15,
                newPrice: 3,
                description: "Bun Bun"
            }

            var product2 = {
                name: "Pateu vegetal",
                image: "http://foodguard.smallfootprint.net/images/blog/blog-img-1.jpg",
                oldPrice: 20,
                newPrice: 13,
                description: "Bio"
            }
            var product3 = {
                name: "Supa de galuste",
                image: "http://foodguard.smallfootprint.net/images/blog/blog-img-1.jpg",
                oldPrice: 10,
                newPrice: 4,
                description: "Cea mai buna supa ever"
            }

            var product4 = {
                name: "Orez cu lapte ",
                image: "http://foodguard.smallfootprint.net/images/blog/blog-img-1.jpg",
                oldPrice: 15,
                newPrice: 3,
                description: "Bun Bun"
            }

            var product5 = {
                name: "Pateu vegetal",
                image: "http://foodguard.smallfootprint.net/images/blog/blog-img-1.jpg",
                oldPrice: 20,
                newPrice: 13,
                description: "Bio"
            }

            vm.products.push(product);
            vm.products.push(product1);
            vm.products.push(product2);
            vm.products.push(product3);
            vm.products.push(product4);
            vm.products.push(product5);

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