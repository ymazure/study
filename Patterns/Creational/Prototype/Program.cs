using Prototype;

var product1 = new Product(30, "Coconut", 2);

// easy to create instances of Product type, when we need same state
var product2 = product1.Clone();
var product3 = product1.Clone();
var product4 = product1.Clone();