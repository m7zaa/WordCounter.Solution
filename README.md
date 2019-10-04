# _Word Counter_

#### _Counts specific words in a given sentence, 2019_

#### By _**Micah Zaayer**_

## Description

_The user inputs a sentence and a word. The program returns how many instances the word shows in the sentence._

## Setup/Installation Requirements

* _Clone from GitHub_
* _In the terminal, input the following commands:_
* _$ dotnet restore_
* _$ dotnet run_


## Specs
| Behavior | Why | Input | Output |
| ------------- |------------- |:-------------:| -----:|
| 1. Program looks for word match. | Matching two single words is most simple behavior. | cat, cat | true |
| 2. Program counts amount of times chosen word appears in user input. | After turning sentence into array of strings, it's comparing two words at a time through the whole sentence. | The cat is cat. | 2 |
| 3. Program only counts full-word matches only. | The most complex behavior.  | There's a cat in the cathedral!  | 1 |






## Known Bugs

_There are no known bugs at this time._

## Support and contact details

_If you encounter any issues, contact Micah Zaayer at zaayer@protonmail.com_

## Technologies Used

_C# and .NET_

### License

*MIT Licensed*

Copyright (c) 2019 **_Micah Zaayer_**