(function () {
    'use strict'

    angular
        .module('app.product')
        .factory('ProductService', ProductService);

    ProductService.$inject = ['$q'];

    function ProductService($q) {

        var service = {};

        service.getProductById = getProductById;
        service.addProduct = addProduct;
        service.editProduct = editProduct;
        service.viewProduct = viewProduct;
        service.getProductList = getProductList;

        //hardcoded product list
        var product = {
            name: "Supa de galuste",
            image: "http://foodguard.smallfootprint.net/images/blog/blog-img-1.jpg",
            oldPrice: 10,
            newPrice: 4,
            expirationDate: '10/01/2015',
            description: "Cea mai buna supa ever"
        }
        var product1 = {
            name: "Orez cu lapte ",
            image: "http://foodguard.smallfootprint.net/images/blog/blog-img-1.jpg",
            oldPrice: 15,
            newPrice: 3,
            expirationDate: '10/01/2015',
            description: "Bun Bun"
        }
        var product2 = {
            name: "Pateu vegetal",
            image: "http://foodguard.smallfootprint.net/images/blog/blog-img-1.jpg",
            oldPrice: 20,
            newPrice: 13,
            expirationDate: '10/01/2015',
            description: "Bio"
        }
        var product3 = {
            name: "Supa de galuste",
            image: "http://foodguard.smallfootprint.net/images/blog/blog-img-1.jpg",
            oldPrice: 10,
            newPrice: 4,
            expirationDate: '10/01/2015',
            description: "Cea mai buna supa ever"
        }
        var product4 = {
            name: "Orez cu lapte ",
            image: "http://foodguard.smallfootprint.net/images/blog/blog-img-1.jpg",
            oldPrice: 15,
            newPrice: 3,
            expirationDate: '10/01/2015',
            description: "Bun Bun"
        }
        var product5 = {
            name: "Pateu vegetal",
            image: "http://foodguard.smallfootprint.net/images/blog/blog-img-1.jpg",
            oldPrice: 20,
            newPrice: 13,
            expirationDate: '10/01/2015',
            description: "Bio"
        }

        var products = [];

        products.push(product);
        products.push(product1);
        products.push(product2);
        products.push(product3);
        products.push(product4);
        products.push(product5);

        //

        function getProductById(productId) {

        }

        function addProduct(newProduct) {

        }

        function editProduct(currentProduct) {

        }

        function viewProduct(productId) {

        }

        function getProductList() {
            var deferred = $q.defer();

            deferred.resolve(products);
            return deferred.promise;
        }

        return service;
    }

})();