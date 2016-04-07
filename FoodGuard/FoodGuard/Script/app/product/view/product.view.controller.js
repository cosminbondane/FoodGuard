(function () {
    'use strict';

    angular
        .module('app.product')
        .controller('productViewController', productViewController);

    productViewController.$inject = [];

    function productViewController() {
        var vm = this;
    }

})();