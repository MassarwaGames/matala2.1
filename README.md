# Question 1: Object Movement, Rotation, Resizing, and Oscillation

## Overview
This part of the project implements the functionality for:
- **Object Movement**: Objects move in a specified direction at a constant speed.
- **Object Rotation**: Objects rotate around a specified axis.
- **Object Resizing**: Objects grow and shrink gradually.
- **Object Oscillation**: Objects move back and forth like a pendulum.

Each object in the scene has an assigned script that governs its behavior, and descriptive labels are displayed above each object using TextMeshPro.

---

## Features
### 1. **Mover Script**
- Moves an object in a specified direction at a constant speed.
- Parameters:
  - **Speed**: Controls the movement speed.
  - **Direction**: Configurable direction vector.

### 2. **Rotator Script**
- Rotates an object around a specified axis.
- Parameters:
  - **Rotation Speed**: Controls how fast the object rotates.
  - **Axis**: Configurable axis for rotation (e.g., X, Y, Z).

### 3. **Resizer Script**
- Gradually grows and shrinks an object like a pulsing effect.
- Parameters:
  - **Resize Speed**: Controls the rate of resizing.
  - **Size Range**: Defines the minimum and maximum size.

### 4. **Oscillator Script**
- Moves an object back and forth like a pendulum.
- Uses trigonometric functions to calculate smooth oscillation.
- Parameters:
  - **Amplitude**: Controls the size of the oscillation.
  - **Frequency**: Determines how quickly the object oscillates.
  - **Direction**: Configurable oscillation axis.

### 5. **Text Labels**
- Each object has a label using **TextMeshPro**:
  - Indicates the type of behavior the object demonstrates (e.g., "Moving", "Rotating", "Oscillating").
  - Follows the object dynamically.

---


[Itch.io Page](https://blackeswadeh.itch.io/question1-game) 
