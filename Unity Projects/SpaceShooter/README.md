# 2D Space Shooter

A 2D arcade-style space shooter game developed with Unity.

## Game Overview
In this game, the player controls a spaceship and shoots incoming asteroids while avoiding collisions.  
Asteroids spawn from different positions and increase in number over time.  
The game ends when the player collides with an asteroid.

## Core Gameplay Systems

### Player System
- 2D spaceship movement with boundary limits
- Tilt animation based on movement direction
- Collider-based interaction system

### Shooting System
- Laser prefab instantiation
- Controlled fire rate
- Projectile movement and collision detection
- Automatic projectile destruction

### Enemy (Asteroid) System
- Asteroid prefab creation
- Movement behavior
- Collision-based destruction
- Explosion effect on impact
- Spawn from multiple positions
- Wave-based spawning system
- Increasing difficulty with multiple asteroids

### Game Management
- Score tracking system
- UI-based score display
- Game Over logic
- Timed destruction of explosion effects
- Centralized scene management

### Audio System
- Shooting sound effects
- Explosion sound effects
- Basic game audio setup

## Technical Implementation

- Prefab-based architecture (player, laser, asteroid, explosion)
- Spawn manager for wave control
- Class-based boundary system
- Organized scene structure
- Physics2D collision system
- Script-driven gameplay logic in C#

## Technologies Used
- Unity Engine (2D Mode)
- C#
- Unity 2D Physics
- Unity UI System
- Prefabs & Scene Management

## Project Status
This project is functionally complete as a small arcade prototype.  
It demonstrates implementation of core gameplay loops, spawning logic, and basic game state management.

## Purpose
The goal of this project was to build a structured 2D arcade-style game and gain hands-on experience with:
- Shooting mechanics
- Wave spawning systems
- Collision and destruction logic
- Basic game architecture design
