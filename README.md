# Pass the Pigs Console Game

Pass the Pigs is a fun and addictive dice game where players roll pig-shaped dice and earn points based on the position the pigs land in. This version of the game is implemented in C# and played through the console.

## How to Play

1. **Installation**: Clone the repository or download the source code files to your local machine.

2. **Requirements**: Ensure you have .NET Core installed on your machine to run the game.


3. **Build**: Open a terminal or command prompt and navigate to the project directory. Run the following command to build the game:

```shell
dotnet build
```

4. **Run**: After the build is successful, run the following command to start the game:
```shell
dotnet run
```

5. **Gameplay**: The game will ask how many players are playing. The minimum number of players is 2, and the maximum is 4. After you enter the number of players in the console, the game will ask for each player's name. Then, the game starts! Follow the prompts and enter your choices via the console.
- "Yes" if you want to trow more.
- "No" if u dont want to trow more.

6. **Scoring**: The game will calculate and display the score based on the position of the pigs. The score will accumulate as you progress through the game.
- All the possible pig landings:
```
1. "Sider": Both pigs land on their sides. Worth 1 point.
2. "Razorback": One pig lands on its back, the other in any other position. Worth 5 points.
3. "Trotter": One pig lands on its stomach, the other in any other position. Worth 5 points.
4. "Snouter": One pig lands on its snout, the other in any other position. Worth 10 points.
5. "Leaning Jowler": One pig lands on its side, the other in any other position. Worth 15 points.

6. "Double Razorback": Both pigs land on their backs. Worth 20 points.
7. "Double Trotter": Both pigs land on their stomachs. Worth 20 points.
8. "Double Snouter": One pig lands on its snout, the other on its back. Worth 40 points.
9. "Double Leaning Jowler": One pig lands on its snout, the other on its side. Worth 60 points.

10. "Pig Out": Both pigs land in any position except the defined combinations above. No points are scored, and the turn passes to the next player.
11. "Makin' Bacon": Both pigs are touching and both are resting on the table - Player's total score from the game is wiped out; play passes to next player.
```
7. **Winning**: The game continues until a player reaches the winning score of **100** points or more. Once a player reaches or exceeds the winning score, they will be declared the winner, and the game will exit automatically.

## Features
- Simulates the Pass the Pigs dice game in the console.
- Interactive gameplay with clear instructions and prompts.
- Real-time scoring system to track the progress of each player.
- Supports multiple rounds and allows for replayability.

## Dependencies
The Pass the Pigs console game has the following dependencies:

- .NET Core (version 6.0 or higher)