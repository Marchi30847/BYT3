# Calculator and Shapes Tests


 /\_/\    /\_/\    /\_/\
( o.o )  ( o.o )  ( o.o )
 > ^ <    > ^ <    > ^ <


Overview

This repository contains two lightweight C# modules designed to practice clean structure and unit testing with NUnit.

Shapes

Implements four geometric classes:
Sphere, Cube, Cylinder, and Rectangle.
Each provides CalculateArea() and CalculateVolume() methods.

Calculator

A simple arithmetic class performing operations:
+, -, *, /.
Handles invalid operators and division by zero gracefully.

Testing

Both modules are fully covered with NUnit test cases, verifying:
	•	positive, negative, and zero values
	•	decimal and boundary inputs (double.MaxValue, double.MinValue)
	•	exceptions and stability under edge conditions
