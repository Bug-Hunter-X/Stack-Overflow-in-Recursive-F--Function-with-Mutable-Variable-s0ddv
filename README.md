# Stack Overflow Bug in Recursive F# Function

This repository demonstrates a common error in F#: a stack overflow exception caused by excessive recursion when using a mutable variable within a recursive function.  The `bug.fs` file contains the faulty code, while `bugSolution.fs` provides a corrected version.

## Bug Description

The original code attempts to count to one million using recursion and a mutable variable.  However, this approach results in a stack overflow because each recursive call adds a new stack frame, eventually exceeding the available stack space.

## Solution

The solution replaces the recursive approach with a tail-recursive function, using `let rec loop acc x = ...`.  This eliminates the need for a growing stack as the tail call optimization removes the need for new stack frames. In addition, it also removes the mutable variable making the code more functional.