# Oni Stubs
Stub dlls made for Oxygen not including, that emulate the APIs found within the source dlls.

## Missing features / Known issues
 - Events
 - Delegates
 - Nested generic classes that are 2+ deep
 - Members whose types use a security critical type (Like HashSet)

 ## Dev guide

 - Use restore lib to copy the dlls.
 - Update the libraries dependencies to match the target dlls
 - Run the T4 templates found within the solution to regenerate the types

 ## Alternative method to create stubs

 - Decomplile the projects and compile with the `-refout` compiler option.