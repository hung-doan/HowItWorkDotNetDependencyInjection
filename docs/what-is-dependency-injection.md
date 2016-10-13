#What is dependency injection (DI) ?
**Dependency injection** is a software design pattern that implements inversion of control for resolving dependencies.

**Dependency**: Is an object that you can use. 

**Injection**: Is the way to inject to increate the instance of your object(dependency).

**Dependency Injection** is about: Passing the object to the client, rather than allowing a client to build or find the object


---
In following code: `LogService` is a `Dependency` and We create an instance of this `Dependency` manually.

=> This is not follow `Dependency Injection` pattern

```C#
public class LogService {

}

public class UserService {
  private LogService _logger;
  public UserService() {
    _logger = new LogService();
  }
}

public static void main() {
  var userService = new UserService();
}
```

---

In following code: `LogService` is a `Dependency` and We create an instance of this `Dependency` by passing `LogService` instance to `UserService constructor`

=> We passing the object to the client (UserService), so this code follow `Dependency Injection` pattern

```C#

public class ILogService {

}

public class LogService: ILogService {

}

public class UserService {
  private LogService _logger;
  public UserService(LogService logger) {
    _logger = logger;
  }
}

public static void main() {
  var logger = new LogService();
  var userService = new UserService(logger);
}
```

In this example you can see that: I passed the `LogService` instance in to the contructor of `UserService` (Passing the object to the client) instead of let the `UserService` create `LogService` instance by itself (client build object by itself)

By using `Dependency injection`, I will help you to manage all your dependencies at a single point. It give you a genral picture of how were your dependencies used. 

You know `polymorphism` of OOP (Object-oriented programming) right ? `Dependency injection` will help you more familiar with `polymorphism` of OOP. 

So, there is a small side effect of `Dependency injection` is make your code more modular and single point of failure:  

> Imagine that your `LogService` class was used in 1,000 difference files. In next version of your application you don't want use your old logger, you want to replace it by a more powerful logging tools.  It sounds great, but the bad thing is that you have to replace your old `LogService` by `MorePowerfulLogService`, and you have do that in 1,000 files.

**Your story would be:**

**Boss:** Change `LogService` to  `MorePowerfulLogService`, you have one second!

**Me:** What? It can't be. It would take me a whole day. There is 1,000 file use `LogService`, I have do edit them all. Please give me 3 days. 

**Boss:** Really ? It just like change the class name, It's easy, you have one day.

`LIFE IS  NOT EASY`




**Then, DJ come into play to save your life:**

**Boss:** Change `LogService` to  `MorePowerfulLogService`, you have one second!

**Me:** Hey DJ, My boss don't like the old LogService, please switch to MorePowerfulLogService. We have one second

**DJ:** The challenge accepted. It's done, one second as expected. 

`HAPPY ENDING`


## At some point of view I make a simple formular like this 

    Polymorphism + Object Injection = Dependency Injection
*(do you agree with me?)*



### But I think the most important benefit of DJ is `Testable`.

DJ will help you test your app much more easier.  


## There are three main styles of dependency injection:
* Constructor Injection
* Setter Injection
* Interface Injection

