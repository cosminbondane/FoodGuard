(function () {
    'use strict';

    angular
        .module('app.subscribe')
        .controller('subscribeController', subscribeController);

    subscribeController.$inject = [];

    function subscribeController() {
        var vm = this;

        vm.subscribe = subscribe;

        init();

        function init() {
        }

        function subscribe() {
            SubscribeService.subscribe(vm.email).then(function (response) {
                if (response.success) {
                }
            });
        }
    }
})();