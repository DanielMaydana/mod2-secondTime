var assert = require('assert');
var Character = require('./Character.js');
describe('Array', function () {
  describe('#new Character()', function () {
    it('should create a character with health 100 when instantiated as human', function () {
      const expected = 100;
      const actual = new Character('daniel', 25, 'human');
      assert.equal(actual.health, expected);
    });
    it('should create a character with health 150 when instantiated as elf', function () {
      const expected = 150;
      const actual = new Character('daniel', 25, 'elf');
      assert.equal(actual.health, expected);
    });
    it('should create a character with health 400 when instantiated as troll', function () {
      const expected = 400;
      const actual = new Character('daniel', 25, 'troll');
      assert.equal(actual.health, expected);
    });
    it('should create a character with health 300 when instantiated as dwarf', function () {
      const expected = 300;
      const actual = new Character('daniel', 25, 'dwarf');
      assert.equal(actual.health, expected);
    });
    it('should throw an exception when passed a null value as alias', function () {
      const expected = 'The alias of the character can\'t be \'null\'';
      const actual = () => new Character(null, 25, 'dwarf');
      assert.throws(actual, Error, expected);
    });

    it('should throw an exception when passed a null value as age', function () {
      const expected = 'The age of the character can\'t be \'null\'';
      const actual = () => new Character('daniel', null, 'dwarf');
      assert.throws(actual, Error, expected);
    });
    it('should throw an exception when passed a null value as type', function () {
      const expected = 'The type of the character can\'t be \'null\'';
      const actual = () => new Character('daniel', 25, null);
      assert.throws(actual, Error, expected);
    });
  });
  describe('#levelUp()', function () {
    it('should increase the health to 550 when a level 1 human is leveled up', function () {
      const expected = 550;
      const actual = new Character('daniel', 25, 'human');
      actual.levelUp();
      assert.equal(actual.health, expected);
    });
    it('should increase the health to 750 when a level 1 elf is leveled up', function () {
      const expected = 750;
      const actual = new Character('daniel', 25, 'elf');
      actual.levelUp();
      assert.equal(actual.health, expected);
    });
    it('should increase the health to 780 when a level 1 dwarf is leveled up', function () {
      const expected = 780;
      const actual = new Character('daniel', 25, 'dwarf');
      actual.levelUp();
      assert.equal(actual.health, expected);
    });
    it('should increase the health to 450 when a level 1 troll is leveled up', function () {
      const expected = 450;
      const actual = new Character('daniel', 25, 'troll');
      actual.levelUp();
      assert.equal(actual.health, expected);
    });
  });
});