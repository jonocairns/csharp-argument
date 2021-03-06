# Argument Validator

[![Build Status](https://travis-ci.org/jonocairns/csharp-argument.svg?branch=master)](https://travis-ci.org/jonocairns/csharp-argument)
[![NuGet](https://img.shields.io/nuget/v/Intergen.Argument.svg)](https://www.nuget.org/packages/Intergen.Argument/1.0.0)

Utility used to validate method input parameters.

1) Install-Package Intergen.Argument

2) OPTIONAL - if you use resharper, import the live template in the root folder. This will let you use shortcuts like checkn, checkne etc.

3) Start validating public methods!

```csharp

public static string SomeMethod(string inputString, Object someObject)
{
    Argument.CheckIfNullOrEmpty(inputString, "inputString");
    Argument.CheckIfNull(someObject, "someObject");
    
    // Do stuff with validated arguments...
    
    return "An exception will be thrown with good information if any of the inputs are invalid!";
}
        

```
