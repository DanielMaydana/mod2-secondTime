const PROPS_BY_KIND = {
  human: {
    health: 100,
    increment: 450
  },
  elf: {
    health: 150,
    increment: 600
  },
  troll: {
    health: 400,
    increment: 50
  },
  dwarf: {
    health: 300,
    increment: 480
  }
}
function isNull(fieldName, value) {
  if (value === null) throw new Error(`The ${fieldName} of the character can\'t be \'null\'`);
  else return value
}
function getHealthByKind(type) {
  return PROPS_BY_KIND[type].health;
}
class Character {
  constructor(alias, age, type) {
    this.alias = isNull('alias', alias);
    this.age = isNull('age', age);
    this.type = isNull('type', type);
    this.level = 1;
    this.health = getHealthByKind(type);
  }
  levelUp() {
    this.health += PROPS_BY_KIND[this.type].increment;
  }
}

module.exports = Character