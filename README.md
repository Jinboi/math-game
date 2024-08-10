<div align="center">

<img src="./img/mathGameLogo.png" alt="math game logo" width="100px" />
<h1> Math Game</h1>

</div>

Welcome to the Math Game App!

This demo helps young children sharpen their math skills with fun and simple math questions.  

You can choose your difficulty and number of questions. 

You can even choose a Random option if you're up for the challenge!

## Features

- **Basic Math Questions**: Addition, Subtraction, Multiplication, Division.
- **Integer-Only Division**: All division problems ensure integer results with dividends.
- **Game History**: You can view all the history of your previous games. However, your data will get deleted once you've closed the Math Game application.
- **Difficulty Levels**: Select from different levels of difficulty to match your skill.
- **Timer**: You'll be able to see how long you took to clear your game.
- **Number of Questions**: You can choose your own number of questions you want to attempt.
- **Random Game**: Get questions from random operations for an extra challenge.

## Getting Started

### Prerequisites

- .NET 8 SDK installed on your system.

### Installation

#### Console

1. Clone the repository:
	- `git clone https://github.com/Jinboi/math-game.git`

2. Navigate to the project directory:
	- `cd src\math-game\MathGame.ConsoleApplication`

3. Run the application using the .NET CLI:
	- `dotnet run`


# UNTILL HERE



### Console Screenshots

When you start the application, you will be asked to type your name:

![math game console name](./img/math-game-console-name.PNG)

After which, the application will welcome you:

![math game console welcome](./img/math-game-console-welcome.PNG)

You will then be presented with a menu:

![math game console main menu](./img/math-game-console-main-menu.PNG)

Choose an option:
- **V**: to view the games history page, including date, game type, score and time taken.
- **A**: to play an Addition game.
- **S**: to play a Subtraction game.
- **M**: to play a Multiplication game.
- **D**: to play a Division game.
- **R**: to play a game with a mix of questions from all operations.
- **Q**: to quit the application.

If you choose to play a game, you will then be presented with a difficulty menu:
    
![math game console difficulty menu](./img/math-game-console-difficulty-menu.PNG)

Choose an option:
- **Easy**: numbers between 1-10.
- **Medium**: number between 1-100.
- **Hard**: number between 1-1000

Then, enter how many questions you want to answer and the game will then start with your your selected options.

On completion, the game will be recorded to an SQLite3 database.

### MAUI

When you start the application, you will be presented with a menu:

![math game maui main menu](./img/math-game-maui-main-menu.png)

Choose an option:
- **+**: to play an Addition game.
- **-**: to play a Subtraction game.
- **×**: to play a Multiplication game.
- **÷**: to play a Division game.
- **🔀**: to play a game with a mix of questions from all operations.
- **View Previous Games**: to view the games history page, including date, game type, score and time taken.

If you choose to play a game, you will then be presented with a difficulty menu:
    
![math game maui difficulty menu](./img/math-game-maui-difficulty-menu.png)

Use the slider to choose how many questions you want to answer.

Then choose a difficulty and the game will then start with your your selected options:
- **Easy**: numbers between 1-10.
- **Medium**: number between 1-100.
- **Hard**: number between 1-1000

On completion, the game will be recorded to an SQLite3 database.

## How It Works

- **Menu Navigation**: Navigate through the menu using the provided options to set up your game.
- **Question** Generation: Based on your selected operation and difficulty, the app generates questions.
- **Timer**: The timer starts when you begin answering and stops when you finish.
- **History Recording**: After completing a game, your score and time are recorded in the history.    

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes. For major changes, please open an issue first to discuss what you would like to change.

## License

This project is licensed under the MIT License. See the [LICENSE](./LICENSE) file for details.

## Contact

For any questions or feedback, please open an issue.

---
***Happy Math Gaming!***