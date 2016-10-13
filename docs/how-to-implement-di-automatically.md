# How to implement DI automatically ?

There is no magic happend with DI.  It would be easy after answer bellow questions:

1. How to create an instance of object at Run-time?
2. How get all constructor parameters of an Object?
3. Where were your objects created ?

**Answers:**

1. How to create an instance of object at Run-time?
The easiest way is use `Activator.CreateInstance` method to create an instance of type T at Run time.

  If you are considering about performance, you may want to take a look at: `compiled lambda expressions`, `DynamicMethod`

2. How get all constructor parameters of an Object? 
 * You can use `Type.GetConstructors` to get all the public constructor 
 * and `ConstructorInfo.GetParameters` to get all constructor parameters 



