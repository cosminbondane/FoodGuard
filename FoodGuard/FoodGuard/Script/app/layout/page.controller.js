(function () {

    'use strict';

    angular
        .module('app.layout')
        .controller('pageController', pageController);

    pageController.$inject = ['$state'];

    function pageController($state) {
        $state.go('home');
    }

})();