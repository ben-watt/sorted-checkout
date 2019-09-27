# Sorted Checkout

## Process

I decided to opt for a TDD style approach to this exercise. I don't always get the chance to do so and for a task such as this, it ensures you approach it in a simple and logical way. 

## Maintainability

With regards to maintainability, I've tried to keep method names clear and descriptive with small methods and classes having a single responsibility. 

## Abstraction and Future Requirements

If the offer calculation logic was more complicated, I would probably refactor that out into an `IOfferService` which takes in an item or list of items and returns the most valid offer. Before creating an `ICheckout` interface for external consumers I would perhaps consider changing the interface to have one function on `Checkout` simply `decimal Scan(Item item)` that takes in an `Item` and returns the total, simplifying the API for callers.