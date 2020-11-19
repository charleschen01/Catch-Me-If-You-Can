# Catch-Me-If-You-Can
- *Catch Me If You Can* is a game designed and developed in Cambridge University Game Gig 2019. 
- The game is developed using Unity. To run the game, simply load the project directory into Unity.

## Game Rules
- This is a 2-player game. Each player controls one ball. The white ball is controlled using W,A,S,D and the brown ball is controlled using arrow buttons. 
- The aim of the game is for one ball to "catch" the other. Each round consists of 10 seconds. In each round, one ball is the catcher while the other is the runner. If the catcher touches the runner, catcher scores 1 point. If the catcher could not touch the runner within the limit of 10 seconds, the runner scores 1 point. 
- A total of 10 rounds will be played. The white ball will start as the catcher, and the role of catcher and runner switch after each round. The player who has a higher score after 10 rounds wins the game.



![alt text](https://github.com/charleschen01/Catch-Me-If-You-Can/blob/master/Game%20Scene.png)

## Content
All codes reside in the folder *Catch-Me-If-You-Can/Catch Me If You Can/Assets/Scripts*:
- ***GameLogic.cs***: the main script controlling the game lifecycle

- ***Player1.cs***, ***Player2.cs***: enable players to control the movements of two balls using keyboard

- ***MovingCapsule.cs***, ***MovingTile.cs***, ***RotatingBar.cs***: set up moving objects in the game scene

