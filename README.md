# RA Maze — Augmented Reality Maze Game
An augmented reality maze game developed in Unity as a student project for the Augmented Reality course at UNESP (Universidade Estadual Paulista), in 2023.

## About the Project
This project was developed as part of an undergraduate course in Augmented Reality. The course activities introduced Unity and augmented reality development through a sequence of practical projects.
The maze game was based on a guided classroom activity, which students could customize by creating their own maze designs, objects, levels, and physical references.
In this version, I customized the game using a gelatin box as the physical object tracked by the augmented reality system.

## Features
- Augmented reality maze displayed over a physical object
- Physical object tracking using Vuforia MultiTarget
- Custom physical reference based on a gelatin box
- Three difficulty levels: Easy, Medium, and Hard
- Coin collection and score system
- Moving walls in Medium and Hard levels
- Red coins that deduct points in the Hard level
- Level progression
- Main menu and information screen

## Technologies
- Unity 3D
- C#
- Vuforia Engine
- Android

## Project Details
| | |
|---|---|
| Unity Version | 2021.3.1f1 |
| Vuforia Engine | 10.12.3 |
| Platform | Android |
| Development Context | Undergraduate course project |
| Institution | UNESP – Universidade Estadual Paulista |

## How to Open the Project
1. Install **Unity 2021.3.1f1** using Unity Hub.
2. Clone or download this repository.
3. Open the project folder using Unity Hub.
4. Install the Vuforia Engine package separately, as it is not included in this repository.
5. Configure Vuforia according to its installation requirements.
6. Open the project scenes and run or build the application for a compatible Android device.
> **Note:** Vuforia Engine is not included in this repository because of GitHub's file size restrictions. Additional setup may be required before the project can run correctly.

## Augmented Reality Setup
The game uses Vuforia MultiTarget tracking to recognize the physical box.
The reference object is a gelatin box, and the tracking configuration uses images corresponding to its sides. The virtual maze is displayed in relation to the tracked physical object.
For the AR experience, a compatible Android device and the correctly configured Vuforia environment are required.

## Project Report
The academic report documents the development process, implementation, and project details.
📄 **[Read the Project Report](Documentation/maze-game-report.pdf)**

## Demo Video
▶️ **[Watch the Game Demonstration](Documentation/video-of-the-maze-game-in-action.mp4)**
The video demonstrates the augmented reality game running on a mobile device.

## Academic Context
Developed as a practical student project during the undergraduate Augmented Reality course at UNESP, Bauru, Brazil, in 2023.
The project was part of a structured teaching activity and includes personal customizations to the original guided exercise.
