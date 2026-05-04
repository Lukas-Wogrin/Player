# Player C# Console App
A C# console application that demonstrates binary serialization with a Player class.
If a save file exists, it loads and displays the players — otherwise it creates 3 players and saves them.
# How It Works
Program checks if player.bin exists
File exists → loads players from binary file and displays them
File missing → creates an array of 3 players, saves them to player.bin
Players are displayed using a custom ToString() method
# Concepts Used
Object-oriented programming (OOP)
Custom Player class with ToString() override
Binary serialization / deserialization
File I/O (player.bin)
Arrays
# Technologies
C# (.NET)
Visual Studio
