# ZigZag-Game-Clone

Welcome to the **ZigZag-Game-Clone** project! This repository contains a Unity-based recreation of the popular zigzag-style game. It is designed to be simple yet effective for learning or further development.

## Table of Contents
- [Features](#features)
- [Installation](#installation)
- [Gameplay](#gameplay)
- [Project Structure](#project-structure)
- [Assets](#assets)
- [Known Issues](#known-issues)
- [Future Improvements](#future-improvements)
- [License](#license)

---

## Features
- Start and restart mechanics
- Basic score display at the top of the screen
- Mobile compatibility
- Dynamic mechanics:
  - Ground color changes over time using Lerp
  - Cubes fall after the ball passes them
- Optimized performance:
  - 50 cubes are pre-generated at the start and reused during gameplay, reducing memory usage

## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/batuhancetinkaya1/ZigZag-Game-Clone.git
   ```
2. Open the project in Unity (tested with Unity version 2022.3.44f1).
3. Play the game by opening the `Main Scene` and pressing the Play button in the Unity Editor.

You can also play the game directly on [itch.io](https://batuhancetinkaya.itch.io/zigzag-game-clone).

## Gameplay
The goal of the game is to guide the ball along a zigzag path by tapping the screen to change its direction. The player earns points based on the distance covered.

### Controls
- Tap the screen or click the mouse to change the ball's direction.

## Project Structure
Below is a high-level overview of the project structure:

### [Assets](https://github.com/batuhancetinkaya1/ZigZag-Game-Clone/tree/main/Assets)
Contains all the resources required for the game, such as scripts, prefabs, and materials.

### [Scripts](https://github.com/batuhancetinkaya1/ZigZag-Game-Clone/tree/main/Assets/Scripts)
Includes C# scripts for handling game mechanics:
- **BallController.cs**: Manages the ball's movement and direction.
- **GroundManager.cs**: Handles ground generation and color changes.
- **GameManager.cs**: Controls the game state and scoring.

### [Prefab](https://github.com/batuhancetinkaya1/ZigZag-Game-Clone/tree/main/Assets/Prefab)
Contains reusable game objects like cubes and the ball.

### [Material](https://github.com/batuhancetinkaya1/ZigZag-Game-Clone/tree/main/Assets/Material)
Includes materials used for ground and other visual elements.

### [Scenes](https://github.com/batuhancetinkaya1/ZigZag-Game-Clone/tree/main/Assets/Scenes)
Contains the main gameplay scene.

## Known Issues
- No significant issues reported.

## Future Improvements
- Add sound effects and background music
- Implement an advanced leaderboard system
- Include additional visual effects and animations
- Introduce power-ups or special mechanics for added variety

## License
This project is open source and available under the [MIT License](LICENSE). Feel free to use, modify, and distribute the code as per the license terms.

---

Happy coding! If you encounter any issues or have suggestions, please open an issue in the repository or reach out. 🚀
