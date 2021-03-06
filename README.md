# Epicodus Independent Project - March 6, 2020

### Created by: Brandan Sayarath

## Description

This is the Epicodus independent end-of-week assignment for Friday, March 6, 2020.  The purpose of this assignment is to create a console application that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence.  This application will only check for exact matches.  For instance, if provided the word "cat" and sentence "I'm walking to the cathedral." the first three letters of the word cathedral would not be counted.

## Behavior Driven Development Specifications

| Specification             | Input 	|     Output      |
|-------------------------	|-------	|----------------	|
| Program displays welcome message and asks the user for the word they want counted | "Epicodus" | "The word to be counted is "Epicodus." |
|Program asks the user for a sentence | "Epicodus is a coding bootcamp." | The program then searches for the word Epicodus in the user's given sentence | 
|Program returns message stating how many times the word is used in the sentence | Word: "Epicodus" <br> Sentence: "Epicodus is a coding bootcamp" | "Epicodus is used 1 time(s) in your given sentence." |


## Setup/Installation Requirements

Clone this repository via Terminal using the following commands:
* ```$ cd desktop```
* ```$ git clone https://github.com/brandanpdx/word-counter```
* ```$ cd word-counter```

To run the program, navigate to the WordCounter production folder by typing the following into the terminal: 

* ```$ cd WordCounter```

Then run the program by typing:
* ```$ dotnet run```


## Support and Contact

Please email Brandan Sayarath: brandan@brandan.tech for any questions.

## Technologies Used

This program was created with:

* C#
* .NET

## License

This code is licensed under MIT permissive free software license

Copyright (c) 2020 Brandan Sayarath

