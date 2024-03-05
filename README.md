# MSBuildTaskSameSolution

Sample how to use MSBuild task within same solution.

Most inconviniet in this setup is that you cannot modify MSBuild task without shutting down build server.
Workaround for this is `RoslynCodeTaskFactory`, but this maybe not appropriate for everybody.

If you decide keep tasks in same solution, learn to run `dotnet build-server shutdown` often.
