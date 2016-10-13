#The introduction
**Dependency injection** is a software design pattern that implements inversion of control for resolving dependencies.

**Dependency**: Is an object that you can use. 

**Injection**: Is the way to inject to increate the instance of your object(dependency).

**Dependency Injection** is about: Passing the object to the client, rather than allowing a client to build or find the object


---
In following code: `UserRepo` is a `Dependency` and We create an instance of this `Dependency` `UserRepo` manually.
=> This is not follow `Dependency Injection` pattern

```C#
public class UserService{
  private UserRepo _repo;
  public UserService() {
    _repo = new UserRepo();
  }
}

public static void main(){
  var userService = new UserService();
}
```

---

In following code: `UserRepo` is a `Dependency` and We create an instance of this `Dependency` by passing `UserRepo` instance to `UserService constructor`
=> We passing the object to the client (UserService), so this code follow `Dependency Injection` pattern

```C#
public class UserService{
  private UserRepo _repo;
  public UserService(UserRepo repo) {
    _repo = repo;
  }
}

public static void main(){
  var userService = new UserService();
}
```
