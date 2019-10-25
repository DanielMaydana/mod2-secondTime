const myObj = {
    id: 1,
    count: 0,
    months: [0, 1, 2],
    getMapped: function () {
        return this.months.map((x, i) =>
            `${this.id + i} ${this.count + 4 * i} ${x}`
        )
    },
}

console.log(myObj.getMapped())