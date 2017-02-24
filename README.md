# Farity
An intuitive functional library for C# programmers

**[Work In Progress]**

## Why Farity?

There are already several excellent libraries for C# which allow the use of the functional prardigm. Typically, they are written in a way that enables programmers from other languages like Haskell and F# quickly get to working in a familiar syntax, etc., inside C#, trying to fix several "problems" C# poses towards a functional approach. The few libraries that stick to being true to functional style without outright fighting what C# offers, often try to mimic the syntax in other functional languages, thereby introducing quirks like dynamic functions that change behavior depending upon the number of arguments supplied, causing us to lose several advantages that C# offers from the ground-up, starting with static type checking. Farity has a more focused goal. We wanted a library designed specifically for a functional programming style, one that makes it easy to create functional pipelines, one that never mutates user data, but one that still feels like writing C#.

## What's different?

The primary distinguising features of Farity are:

* Farity emphasizes a purer functional style. Immutability and side-effect free functions are at the heart of its design philosophy. This can help you get the job done with simple, elegant code.
* Farity functions that operate on lists or sets always use the `IEnumerable<T>` type and the deferred execution that comes with it (very much like LINQ). This can help you get started with functional programming without a steep learning curve. The type system is very familiar and works as expected.
* Farity encourages the use of function composition and higher-order functions in order to write complex logic with robust functions that can easily be tested. Breaking down complex logic will feel more natural after solving a few problems in this style, and will also help with thinking about problems in other paradigms.
* Farity works with C# and its types (well, mostly) and doesn't fight the system. This means there are no dynamic methods, and everything you write is easy to understand, validate, and determine. There is no magiv under the hood that feels strange.
* The parameters to Farity functions are arranged to make it convenient for currying and/or partial application. This also encourages constructing new functions from old ones by supplying only a few of the parameters. The data to be operated on is generally supplied last.

These points make it very easy to build functions as a sequence of simpler functions, each of which transforms the data and passes it along to the next, all the while retaining static type checking. Farity is designed to support this style of coding.

## Philosophy

Using Farity should feel much like just using C#. It is intuitive, practical, functional C#. We're not re-introducing Tuples, we're not borrowing consed lists, we're not porting over all of the Clojure or Haskell or F# functions.

Our basic data structures are POCOs, and our usual collections are IEnumerables (usually Lists). We also keep other native features of C#, such as static type checking, deferred exection in IEnumerables, and conventions for naming functions.

Functional programming is in good part about immutable objects and side-effect free functions. While Farity does not _enforce_ this, it enables such style to be as frictionless as possible.

We aim for an implementation both clean and elegant, but the API is king. We sacrifice a great deal of implementation elegance for even a slightly cleaner API.

Last but not least, Farity strives for performance. A reliable and quick implementation wins over any notions of functional purity.

## Installation

We're still in pre-release, but you can help by trying out Farity. Farity is available as a [nuget package](https://www.nuget.org/packages/Farity/1.0.0-alpha1) for dotnet core apps. Alternatively, one can install it using the command `Install-Package Farity -IncludePrerelease` in the Package Manager Console. The latest version is `1.0.0-alpha1`.

## Build

TODO:

* There is heavy reliance on DOTNET core, make that explicit,
* explain how to build for different systems.

## Documentation

TODO

## The Name

We wanted something that starts with an F, and something to do with functions. A short name that isn't already taken. Occam's razor landed us 'F' + 'arity'. No, it's that simple, really. Hopefully we make good use of it.

## Using the test suite

TODO:

* Uses xunit, should be elaborated
* Can use VS test runner
* or dotnet test

## Acknowledgements

The source code for generic operators is based on the wonderful [MiscUtil library](http://www.yoda.arachsys.com/csharp/miscutil/).

TODO:

* inspired by ramda
