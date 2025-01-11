# Uncommon C# Code Errors and Bugs

This repository demonstrates some common and uncommon C# code errors and how to resolve them.  The examples highlight issues that can be subtle and difficult to detect, such as improper handling of exceptions, unexpected integer division results, and the misuse of logical operators.

## Bugs and Solutions

The `bug.cs` file contains examples of the following error types:

* **NullReferenceException:** Accessing members of a null object.
* **Unexpected Integer Division:** Using integer division when a floating-point result is needed.
* **Logical Operator Misuse:** Incorrect use of logical operators (&&, ||).
* **Assignment in Conditional:** Using `=` instead of `==` in conditional statements.
* **Improper Exception Handling:** Catching exceptions without proper handling.

The `bugSolution.cs` file provides corrected versions of the code, demonstrating how to avoid these errors.