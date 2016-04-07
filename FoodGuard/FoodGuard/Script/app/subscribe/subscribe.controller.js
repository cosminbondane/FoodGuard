(function () {
    'use strict';

    angular
        .module('app.subscribe')
        .controller('subscribeController', subscribeController);

    subscribeController.$inject = [];

    function subscribeController() {
        var vm = this;

        init();

        function init() {
        }

    }

})();