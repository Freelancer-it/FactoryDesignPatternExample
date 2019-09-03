- Factory Design Pattern -

What:
A Factory Method Design pattern is a creational pattern.

Why:
Encapsulate creating objects and easily expandable.

How:
By abstracting the instantiating of objects and having subclasses arrange the instantiering.
By overriding a factory method, the subclasses can decide for themselves what type of object will be created.

Real World Examples:
- Software that now uses Database 1 conn string and in the future database 2 conn string can easily switch.
- In game you have different bonuses that you can get. Each bonus has its own value that the player receives.
- An application has employees with different functions. Each function has a specific salary that the employee earns.