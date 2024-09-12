# MyResults - A generic result wrapper.

Result and Error classes for you to copy and modify as you need.

---

```csharp
public class UserService
{
    public static Result<Guid> CreateUser(string email, string password)
    {
        if (string.IsNullOrWhiteSpace(email))
        { 
            // implicit conversion
            return new Error("Email is required");
        }

        if (string.IsNullOrWhiteSpace(password))
        {
            // or
            return Result<Guid>.WithError("Password is required");
        }

        //...

        var userId = Guid.NewGuid();

        // implicit conversion
        return userId; 

        // or
        return Result<Guid>.Success(Guid.NewGuid());
    }
}
```
