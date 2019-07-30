# C# Toolbox 
A point of reference for C#

## Introduction
##### C# vs .NET
- C#: The language
- .NET: The framework for buuilding applications
  - CLR (Common Language Runtime)
  - Class Library
  
  __CLR History__
    - C/C++ translate to machine code
    - Java translates to bytecode
    - C# translates to IL code (Intermediate Language)
    
    _So, CLR is an application sitting in memory whose job it is to translate IL code to machine code (Just-In-Time Compilation, JIT)_
    
##### Application Structure
- Application: made up of classes who interact at runtime
- Assembly: Container for related namespaces, DLL or EXE
- NameSpace: Container for related classes, i.e for working with databases, graphics, security
- Class: 
  - Data (Attributes - make, model, colour)
  - Methods (Behaviour - Start(), Stop())
  
  _When you compile an application the compiler builds one or more assembly's_

##### Using Statements
- using System; 
  - namespace in the .NET framework
  - basic utility classes, primitive types
- using System.Collections.Generic;
  - work with lists, collections etc
- using System.Linq;
  - used to work with data
- using System.Text;
  - work with ASCII and Unicode character encodings
- using System.Threading.Tasks;
  - used to build multi threaded apps
  
##### Namespaces
```c#
namespace MyProg
{
  // code in this namespace has access to any classes defined within it
}
```
- each namespace contains a class called Program by default. This class contains a main method.
The CLR executes from main first.
_To use a class defined in a different namespace, we must import it with a using statement_

## Naming Conventions
|PascalCase|camelCase|
| -------------| -------------|
|ClassName|methodArguments|
|ConstructorName|localVariables|
|MethodName|fieldName|
|ConstantsName||
|PropertiesName||
|EnumTypeName||

## Data Types   

## Shortcuts & Nice Code Snippets


###### For Reference
README markdown - https://pandao.github.io/editor.md/en.html
