# Asynchronous programming

## What's it?


## In C#...
- Supports language-level asynchronous programming model, TAP(Task-based Asynchronous Pattern), which makes easier to write asynchronous code. TAP is one of several ways of writing asynchronous code in C#.


## When needed?
- I/O-bound work: Requesting data from a network, accessing a database, or reading and writing to a file system.
- CPU-bound work: Performing an expensive calculation.


## How to use?
- I/O-bound work: Await an operation that returns a Task or Task<T> inside of an async method.
- CPU-bound work: Await an operation that is started on a background thread with the Task.Run method.

## async keyword
- Turns a method into an async method, which allows you to use the await keyword in its body.

## await keyword
- Yields control to the caller of the method that performed await and suspends the calling method until the awaited task is complete.
- When used with Task.Run() method, that work is done on background thread.
- Can only be used inside an async method.

## Note
- Check if CPU-bound work is costly enough compared with the overhead of context switches when multithreading.
- Because LINQ uses deferred (lazy) execution, async calls won't happen immediately as they do in a foreach loop unless you force the generated sequence to iterate with a call to .ToList() or .ToArray().
- Consider using ValueTask where possible in order to avoid the extra allocations.

# References
- https://learn.microsoft.com/en-us/dotnet/csharp/async
