(function () {
    'use strict';

    angular
        .module('app.subscribe')
        .controller('subscribeController', subscribeController);

    subscribeController.$inject = ['SubscribeService'];

    function subscribeController(SubscribeService) {
        var vm = this;

        vm.subscribe = subscribe;

        init();

        function init() {
        }

        function subscribe() {
            var charity = {
                Email: vm.email
            };

            SubscribeService.subscribe(charity).then(function (response) {
                if (response.success) {
                    vm.email = "";
                }
            });
        }
    }
})();