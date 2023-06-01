### This is the source Code for [this guide](https://dev.to/nawodyaishan/begin-your-c-game-development-journey-using-this-challenge-1d59)
---
# Functionality Documentation

The following program uses C# to calculate the distance between two points and the angle from the first point to the second point, based on the Pythagorean theorem.

This implementation is typically useful in the field of game development to find distances and angles between game objects or players in a 2D space.

## Classes

### `Program` Class

The main class of this application, which houses all the logic.

#### Fields

The class has four static `float` fields:

- `point1X` and `point1Y`: These represent the x and y coordinates respectively of the first point.
- `point2X` and `point2Y`: These represent the x and y coordinates respectively of the second point.

#### `Main(string[] args)` Method

This is the entry point of the application. It begins by accepting a string from the console which should contain the coordinates of two points. The points should be in the following format: `"x1 y1 x2 y2"`, where `x1` and `y1` are the coordinates for the first point, and `x2` and `y2` are the coordinates for the second point.

It then calls the `GetInputValuesFromString(string input)` method to parse the input string and assign the coordinate values to the relevant fields.

Next, the program calculates the distance between the two points using the Pythagorean theorem: 

```csharp
float distance = (float) Math.Sqrt((Math.Pow(point1X - point2X, 2) + Math.Pow(point1Y - point2Y, 2)));
```

The angle from the first point to the second is calculated using the `Math.Atan2` function and converted to degrees:

```csharp
double angle = (float)Math.Atan2(point2Y - point1Y, point2X - point1X);
angle *= (float)180/Math.PI;
```

These values are then printed to the console.

The application will continue to accept new input from the console until the user inputs a string that starts with 'q', which will exit the application.

#### `GetInputValuesFromString(string input)` Method

This method is used to parse an input string and extract the coordinates for two points. The method assumes the input string is in the format: `"x1 y1 x2 y2"`. It uses the `IndexOf(' ')` function to find the spaces in the string and the `Substring` function to extract the coordinate values.

## Usage

To run this application, a user would input a string of four numbers separated by spaces, representing two 2D coordinates (e.g., `"1 1 4 5"`). The application will then output the distance between these two points and the angle from the first point to the second, rounded to six and five decimal places respectively.

The user can then input another set of coordinates or type 'q' to quit the application.
