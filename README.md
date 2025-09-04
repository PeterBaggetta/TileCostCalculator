# TileCostCalculator

**TileCostCalculator** is a simple C# program designed to calculate the total cost of flooring a room.  
It was created as part of a learning project for the Rakete Mentoring curriculum.  

## Features
- **Basic cost calculation**: Enter the width, length, and cost per unit of flooring to calculate the total price for rectangular rooms.  
- **Support for non-rectangular rooms**: Handle more complex room layouts beyond simple rectangles.  
- **Labor cost estimation**: Calculate not only material costs but also estimated labor costs for installation.  
- **Input validation**: Ensures only valid numerical inputs are accepted to prevent calculation errors.  

## How It Works
1. The user provides the dimensions of the room (width and length).  
2. The program asks for the cost per flooring unit.  
3. The program calculates the area and multiplies it by the unit cost to find the total price.  
4. For non-rectangular rooms, the user can provide additional measurements, and the program adjusts the calculation.  
5. Optional labor costs are also included in the final total.  

## Purpose
This project was developed for educational purposes to practice:  
- Writing interactive command-line programs in C#
- Implementing input validation  
- Performing basic mathematical calculations  
- Introducing additional complexity (non-rectangular areas, labor cost factors)  
