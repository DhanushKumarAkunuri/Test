## Pre-requisites
1. Dotnet 8.0 or higher

## How to run the program
1. open the folder in terminal
2. run the command `dotnet run`


## Contents in the folder
1. Program.cs - The main program file
2. input.txt - The input file (Feel free to change the input in this file)

## Assumptions
1. The input in the input.txt file is separated by line breaks.

## Output
The output will be displayed in the terminal in the format of : `input string: output string`

## Working
1. The program reads the input from the input.txt file
2. We have an upper limit of 100 characters for the input string. Strings above 100 characters will run in parallel. The reason for this is running in parallel for small strings will be slower than running in sequence.

