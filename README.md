# Console Star Mover

## Overview

Console Star Mover is a simple console application written in C#. The application allows the user to move a star (`*`) around within a specified console window using the W, A, S, and D keys. The star can be moved left, right, up, and down within the confines of a predefined area. The application will exit when the `Escape` key is pressed.

## Features

- Adjustable console window size.
- Move the star using the keyboard:
  - `W` to move up.
  - `A` to move left.
  - `S` to move down.
  - `D` to move right.
  - `Escape` to exit the application.
- A simple interface with boundary markings.

## Getting Started

### Prerequisites

- .NET Core SDK or .NET Framework installed on your machine.

### Running the Application

1. **Clone the repository or copy the source code**:
    ```bash
    git clone <repository-url>
    cd <repository-directory>
    ```

2. **Build the project**:
    Open a terminal or command prompt and navigate to the directory containing the project. Then run:
    ```bash
    dotnet build
    ```

3. **Run the application**:
    ```bash
    dotnet run
    ```

4. **Interact with the application**:
    - Use the `W`, `A`, `S`, and `D` keys to move the star around the console.
    - Press `Escape` to exit the application.

## Code Explanation

### Main Method

The `Main` method sets up the console window size and prints the welcome message and instructions for the user.

### Drawing the Boundary

A nested loop draws the boundary of the area within which the star can move. The boundary is marked with backticks (`) to create a rectangular area.

### Star Movement

The star's initial position is set with coordinates `(x, y)`. A loop constantly checks for key presses:
- If `W`, `A`, `S`, or `D` is pressed, the star moves in the corresponding direction.
- If `Escape` is pressed, the application exits.

### Key Handling

A `switch` statement is used to handle the key presses:
- Moves the star within the defined boundaries.
- Clears the previous position of the star to prevent trailing.
- Sets the new position and prints the star at that position.

## Code Snippet

Here's a brief code snippet to show how the star is moved based on user input:

```csharp
while (true)
{
    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");

    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

    Console.SetCursorPosition(x, y);
    Console.Write(" ");

    switch (keyInfo.Key)
    {
        case ConsoleKey.A:
            if (x > 2) x--;
            break;
        case ConsoleKey.D:
            if (x < 2 * kenglik - 4) x++;
            break;
        case ConsoleKey.W:
            if (y > 5) y--;
            break;
        case ConsoleKey.S:
            if (y < balandlik + 2) y++;
            break;
        case ConsoleKey.Escape:
            Console.Clear();
            Console.CursorVisible = true;
            return;
    }
}
