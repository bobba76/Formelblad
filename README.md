# Formelblad

Ett formelblad med metoder för grundläggande textbaserade C#-projekt. 

## Installation

Placera Formula.cs filen i ditt projekt. 

Högst upp i din source fil skriver du:

```c#
using Formula;
```

## Användning

Alla metoder finns under Klassen - Common

```c#
# Retunerar en siffra; Vid felaktig input från användaren, meddela ett felmeddelande. 
int siffra = Common.ParseInt("Du måste ange ett heltal.")
```

## Metoder
```c#
----------------------------------------------------------------------------------------------------------------
# Forces input to be an int.
	int ParseInt(string errorMessage);

----------------------------------------------------------------------------------------------------------------
# Forces input to be an int.
# Message before input.
	int ParseInt(string word, string errorMessage);

----------------------------------------------------------------------------------------------------------------
# Forces input to be equal to one of the alternatives.
	string GetSpecificString(string[] alternatives, string text, string errorMessage);

----------------------------------------------------------------------------------------------------------------
# Forces input to be equal to one of the alternatives or number of placement in array + 1.
	string GetSpecificStringOrInt(string[] alternatives, string text, string errorMessage);

----------------------------------------------------------------------------------------------------------------
# Forces input (string) with limited amount of letters.
	string LimitedRange(string toShortMessage, string toLongMessage, int minLength, int maxLength);

----------------------------------------------------------------------------------------------------------------
# Forces input (string) with limited amount of letters.
	string LimitedRange(string word, string toShortMessage, string toLongMessage, int minLength, int maxLength);

----------------------------------------------------------------------------------------------------------------
# Forces input (int) that's withing max and minimum value.
	int LimitedRange(string word, string parseIntMessage, string toLow, string toHigh, int minValue, int maxValue);

----------------------------------------------------------------------------------------------------------------
# Print a specific number of rows in the console.
	void Row(int amount);

----------------------------------------------------------------------------------------------------------------
# Makes the first letter in a string to uppercase
	string FirstLetterToUpper(string str);
----------------------------------------------------------------------------------------------------------------
```