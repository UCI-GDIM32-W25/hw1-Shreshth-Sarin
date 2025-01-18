[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
W1L2 - HW1 break down
- Add a description in itch.
- WASD to move. Space to plant.
- Plain green background.
- The game starts with a player prefab. 
- Text UI - Seeds planted: 0. Seeds remaining: 5.
- Press space to plant only one seed at a time.a
  
Objects

- Player
	- Attributes
		- Bunny sprite
	- Actions
		- Input: WASD to move
		- Output: player changing location
- Plant
	- Space to plant
	- Seed is planted at player’s location
	- Increase seed planted + decrease seed remaining
	- One seed planted at a time
- UI
	- Seeds planted
		- Attributes: text
		- Actions: number increases
	- Seeds remaining
		- Attributes: text
		- Actions: number decreases

## Devlog
I added the Player bunny sprite and implemented the WASD move actions in Update() inside Player.cs. This update function also checks for the Space Key pressed down to plant the seed. When the space key is pressed down, the player will plant a single plant at its current position. 

This is done by calling the PlantSeed() function in Player.cs. This function also handles in the incremation of Seeds Planted text UI and decrementation of Seeds Left text UI. There is an if statement to check if the number is 0 or not. Only one _plantPrefab is Instantiated at the Player's position.

To change the text UI, the PlantSeed() function calls the UpdateSeeds(int seedsLeft, int seedsPlanted) function in PlantCountUI.cs. This function is called twice in Player.cs - 

1. In Start() to display the original number count.
2. In PlantSeed() which is called in Update(). This ensures the changes in the numbers after every seed planted.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
I'm giving you full marks for this Devlog because you adequately described how the code you wrote implemented each feature, but for the next Devlog, I would advise being a little bit more specific to make it even clearer. For example, I would have specificically called out the attributes and actions you listed for each object and how they related to the code. You'll need to do this for the HW2 Devlog, so please carefully read the prompt and make sure you're being really specific to continue recieving full marks :)

Please consider formatting your break-down activities with the hyphen '-' symbol as suggested above, and make sure your break-down is in the right section. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
