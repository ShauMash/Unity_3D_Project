#  CAVE Labs Unity 3D Project  
## 🌀 Maze Explorer 3D

> "Maze Explorer 3D" is a **Maze Runner-style game** built in **Unity 3D**, where the player controls a robot navigating through challenging maze environments filled with static and dynamic obstacles.

---

## 🎮 Game Overview

- 🌐 **Platform**: Unity 3D  
- 🧭 **Genre**: Puzzle / Maze / Adventure  
- 🤖 **Player**: Controllable robot character  
- 🧱 **Levels**: 2 Maze Levels + Menu & Credits  
- 🎯 **Goal**: Complete both levels to reach the final credits screen

---

## 🧩 Project Structure

The project contains **four scenes**, played in the following order:

1. 🏁 **Menu Scene** – Main game menu with Start button  
2. 🧱 **Level 1** – Basic static maze with obstacles  
3. ⚙️ **Level 2** – Advanced maze with **moving & rotating walls**  
4. 🎉 **Credits Scene** – Displays a thank-you message and returns to menu  

---

## 🕹️ Gameplay Flow

### 🏁 Menu Scene
- Displays the **game title** and a **Start** button  
- On pressing Start ➝ Loads **Level 1**

### 🧱 Level 1 Scene
- Static maze with **walls and obstacles**  
- The robot:
  - Can **move and jump slightly**
  - ❌ Cannot **jump high or climb walls**
- Player must find the **Finish Line** to advance

### ⚙️ Level 2 Scene
- Maze complexity increases:
  - 🔄 **Rotating walls**
  - ⬆️⬇️ **Moving obstacles**
- Timing and precision are required
- On finishing ➝ Loads **Credits Scene**

### 🎉 Credits Scene
- Displays a **"Thank You for Playing"** message
- Contains **"End Game"** button ➝ Returns to **Menu Scene**

---

## ✨ Features

- 🔄 Smooth scene transitions  
- 🤖 Robot player controller with realistic limitations  
- 🚧 Static and dynamic obstacles  
- 🧠 Puzzle-solving and reflex-based movement  
- 🔁 Full loop back to the main menu after completion

---

## 🕹️ Controls

| Action              | Key/Method         |
|---------------------|--------------------|
| Move                | `WASD` / `Arrow Keys` |
| Jump                | `Spacebar`         |
| UI Interactions     | Mouse / Keyboard   |
| Sprint              | Left-Shift         |

---

## 🛠️ Installation & Setup

1. **Clone** or **Download** this project  
2. **Open** it in Unity (recommended: `Unity 2021.x` or later)
3. **Build Settings** ➝ Add scenes in the following order:
    ```
    1. Menu
    2. Level 1
    3. Level 2
    4. Credits
    ```
4. Press **Play** in Unity Editor to test  
5. Optionally, **Build** for PC/WebGL or your desired platform

---

## 📌 Notes

- Ensure scenes are added in the **correct order** in Build Settings  
- Robot is **not meant to bypass challenges** via high jumps  
- Game loop ensures **full playthrough before returning to Menu**

---

## 🖼️ Scenes
| ![image](https://github.com/user-attachments/assets/11c3c004-7226-45c4-9be0-0d08b347d9c0) |
 | ![image](https://github.com/user-attachments/assets/524866a6-e3bb-4009-b360-152d4c4fc868) |
 | ![image](https://github.com/user-attachments/assets/99ed95bd-8615-48af-ba8a-0ce822cf6d5e) |
 | ![image](https://github.com/user-attachments/assets/6743d2b6-f618-491a-8530-257e0e8fd0d5) |
 

## Thank You !!

