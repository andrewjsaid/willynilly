Willy Nilly
================

This project aims to abstract away random variables behind a simplified interface.

The project was first used within a module which generated fake data for a demo. For example:

```
    public interface IDemoVariables
    {
        IRandomVariable<bool> UserJoinsThisMinute { get; }    
        IRandomVariable<string> FirstNames { get; }
        IRandomVariable<Gender> Gender { get; }
    }
```

The responsibility of setting up the `IRandomVariable<T>` properties and actually using them could then be delegated to different parts of the code. The consumer could, for example, use it as follows:
```
    if(variables.UserJoinsThisMinute.Measure())
    {
        var user = new User
        {
            FirstName = variables.FirstNames.Measure(),
            Gender = variables.Gender.Measure()
            // Set other properties
        };
    }
```

Implementing the `IDemoVariables` interface could then be up to another module, made easy through a number of `IRandomVariable<T>` implementations which are included in the package.
```
    class MyDemoVariables : IDemoVariables
    {
        public IRandomVariable<bool> UserJoinsThisMinute { get; } = new BooleanVariable(0.25); // 25% chance
        public IRandomVariable<string> FirstNames { get; } = new StringSetVariable(new[] { "Andrew", "Julian", "Ilse" });
        public IRandomVariable<Gender> Gender { get; }  = new EnumVariable<Gender>(); // uniform distribution of declared enum values
    }
```