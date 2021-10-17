# Oni Stubs
Stub dlls made for Oxygen not including, that emulate the APIs found within the source dlls.

 ## Dev guide

 - Use restore lib to copy the dlls.
 - Update the libraries dependencies to match the target dlls
 - Run the T4 templates found within the solution to regenerate the types
 - Packaging can be done at the solution level with `nuget pack`