const PROPS_BY_KIND = {
  human: {
    health: 100,
    healthIncrement: 450,
    manaIncrement: 
  },
  elf: {
    health: 150,
    healthIncrement: 600
  },
  troll: {
    health: 400,
    healthIncrement: 50
  },
  dwarf: {
    health: 300,
    healthIncrement: 480
  }
}
function isNull(fieldName, value) {
  if (value === null) throw new Error(`The ${fieldName} of the character can\'t be \'null\'`);
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
    this.health += PROPS_BY_KIND[this.type].healthIncrement;
  }
}

module.exports = Character