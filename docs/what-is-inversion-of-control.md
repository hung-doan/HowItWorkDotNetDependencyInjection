#The introduction
**Inversion of control (IoC)** is a `design principle` describing a `Software Architecture` in which the `flow of control` of a system is `inverted` in comparison to procedural programming

In traditional procedural programming: Your code expresses the flow of control. Your code decides when to call a function, when to read result from the function, and when to process those results.

```C#
// Sample code for traditional procedural programming

public static int main(){
  
  return 1;
}
```
-----------------
However, **Inversion of control (IoC)** is about: There is a framework. You receive the flow of control from that framework instead of doing it by your self. You don't decide when to call a function. The control is inverted - it calls me rather me calling the framework. This phenomenon is Inversion of Control (also known as the Hollywood Principle - "Don't call us, we'll call you").

```C#
// Sample code for IoC principle

public static int main(){
  
  return 1;
}
```

#Implementation techniques

There are several basic techniques to implement inversion of control:

* Using a factory pattern
* Using a service locator pattern
* Using a dependency injection
* Using template method pattern
* ...(and more)

#References

1. http://martinfowler.com/bliki/InversionOfControl.html
2. http://www.martinfowler.com/articles/injection.html
3. https://en.wikipedia.org/wiki/Inversion_of_control
