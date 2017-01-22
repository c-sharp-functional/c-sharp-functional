# Farity
An intuitive functional library for C# programmers

**[Work In Progress]**

## Why Farity?

There are already several excellent libraries for C# which allow the use of the functional prardigm.
Typically, they are written in a way that enables programmers from other languages like Haskell and F#
quickly get to working in a familiar syntax, etc., inside C#, trying to fix several "problems" C# poses
towards a functional approach. The few libraries that stick to being true to functional style without
outright fighting what C# offers, often try to mimic the syntax in other functional languages, thereby
introducing quirks like dynamic functions that change behavior depending upon the number of arguments supplied,
causing us to lose several advantages that C# offers from the ground-up, starting with static type checking.
Farity has a more focused goal. We wanted a library designed specifically for a functional programming style,
one that makes it easy to create functional pipelines, one that never mutates user data, but one that still
feels like writing C#.

## What's different?

TODO:

* Pure functions
* More extensibility and deferred execution using LINQ (of course)
* Function composition and higher order functions are encouraged
* Type safety not lost to dynamic functions
* Convenient to curry or partially apply

## Philosophy

TODO:

* should feel intuitive, practical, functional.
* should not fight C#.

## Installation

TODO:

* There aren't any packages available for installation yet.

## Build

TODO:

* There is heavy reliance on DOTNET core, make that explicit,
* explain how to build for different systems.

## Documentation

TODO

## The Name

We wanted something that starts with an F, and something to do with functions.
A short name that isn't already taken. Occam's razor landed us 'F' + 'arity'.
No, it's that simple, really. Hopefully we make good use of it.

## Using the test suite

TODO:

* Uses xunit, should be elaborated
* Can use VS test runner
* or dotnet test

## Acknowledgements

TODO:

* inspired by ramda
