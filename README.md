# Duck_Escape
* Team Goober's Duck Escape project for Fall 2019 video game design.
* Violet Armendariz varmendariz31@gatech.edu varmendariz3
* Jacob Cianci jcianci3@gatech.edu jcianci3
* Raj Shiddapur rshiddapur3@gatech.edu rshiddapur3
* Brian Piejak bpiejak3@gatech.edu bpiejak3
* Matthew Orubina morubina3@gatech.edu morubina3
* Alexandra Foote afoote8@gatech.edu afoote8

## Controls
* Hold ```W``` - Go Forward, Release W - Stop
* Hold ```A/D``` - Turn Left/Right
* Hold ```W & Left Shift``` - Run
* Hold ```W & Left Ctrl``` - Crouch
* ```Left Click``` - Swing Net
* ```Right Click``` - Place Box
* ```Spacebar``` - Jump

## Goals
Catch all the ducks before time runs out! Try to find the ugly duckling and the rubber duck if you can.
Tips:
* The ducks will run away if you approach from the front! Try sneaking up on them
* Geese will attack you and decrease your health!
* In the second level, falling through the water will kill you.
* You can move the boulders out of the way to reveal secrets!

## Tech Requirments
1. Implemented in Unity
2. Is in 3D
3. Control the human character to catch birds, all birds behave differently. Ducks run away if approached from the front, geese will attack the player and damage them, and swans will wait patiently for the user to catch them.
4. Ducks (and later, geese and swans) have AI to follow a path, and run away/attack when they see the player.
5. In level 2, the player must figure out puzzles to get to some of the birds (hidden in caves with boulders in front, hiding on top of platforms).
6. Human and birds have sounds associated with them. The human has various movement sounds, there is a sound that plays when the birds are caught, the birds make their sounds. The controls work to effectively impact the game.
7. Choose to try and find the ugly duckling or the rubber duck. Also choose where and when you would like to place your bird box.
8. Press ```esc``` to bring up the in game menu. GUI around edge to show players what is going on. Title screen with options for different screens.

## Known Bugs
* Sometimes, inconsistently, the ducks will be spooked off stage, and dissapear momentarily. They always eventually return to their path.

## Assets
1. Park assets came from https://assetstore.unity.com/packages/3d/environments/urban/low-poly-park-61922
2. All sounds came from freesound.org
3. Overworld Music is Stardew Valley Opening
4. Main Menu Music is Minecraft Volume Alpha Mice on Venus
5. The human and bird models were created by us.

## Who Did What
* Violet: Created Human, Human Setup (Controls, Sounds etc.), Team Management, General Fixes
* Jacob: UI, Ugly and Rubber Duck Checks, Ending Cutscene, General Fixes
* Brian: Bird AI, UI, Sounds on Birds, Ending Cutscene, Health, Assets Screen, General Fixes
* Matt: Created Birds, Bird AI, Level Management, General Fixes
* Raj: Pause Menu, Health, Title Screen, General Fixes
* Alex: Created Levels, Water Damage, General Fixes

## What Scenes to Open
1. TitleScreen
2. Level1
3. Level2

