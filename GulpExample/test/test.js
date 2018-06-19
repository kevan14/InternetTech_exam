var expect = require('chai').expect;
var service = require('../src/app');

describe('addTwoNumbers', function(){
    it('should add two numbers', function() {

        // 1. Arrage case
        var x = 10;
        var y = 20;
        var sum1 = x + y;

        // 2. act 
        var sum2 = service.add_two_numbers(x, y);

        // 3. assertion
        expect(sum2).to.be.equal(sum1)
    });
});

describe('This Will Fail', function(){
    it('should add two numbers', function() {

        // 1. Arrage case
        var x = 10;
        var y = 20;
        var sum1 = x + y;

        // 2. act 
        var sum2 = service.add_two_numbers(x, y+1);

        // 3. assertion
        expect(sum2).to.be.equal(sum1)
    });
});