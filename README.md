# Bea's gift
#### Video Demo: https://youtu.be/A_MXcc4jNsI
#### Description:
1. **Technical information**

   This project is a 2D endless running game for Android. It was created with Unity v2021.3.1.11f1 using C# as the programming language. The Unity template used as a base was 2D Mobile v2.0.1. It is a preloaded template with recommended packages and settings for 2D mobile development with target platforms: Android and iOS. Among the preloaded packages are:
   - com.unity.collab-proxy v1.15.7
   - com.unity.feature.2d v1.0.0
   - com.unity.feature.mobile v1.0.0
   - Rider Editor v3.0.12
   - Visual Studio Editor v2.0.12
   - Visual Studio Code Editor v1.2.4
   - Test Framework v1.1.30
   - TextMeshPro v3.0.6
   - Timeline v1.6.3
   - Unity UI v1.0.0
   - com.unity.visualscripting v1.7.6
   
   The texture compression format used was ASTC. The minimum API level selected was Android 5.1 ´Lollipop´ (API Level 22). The scripting backend configured was Mono and the API compatibility level configured was .NET Standard 2.1. The video game has music, sounds, physics, collisions, animations, among other assets and components. All assets were downloaded from the Unity Asset Store and imported using the Unity Package Manager. A database was not used as it was not required in this case. The game does not require an internet connection.
   
2. **About the game**
   
   The game is about a girl who runs endlessly from the left side of the screen to the right in order to capture food. The goal is to get as many points as possible. The highest score is recorded and that value is not lost when the game is closed. It has several scenes that vary according to the player's score, every five points obtained the scene changes. In the upper right corner there is an icon that when pressed shows a simple pause menu with options to resume or exit the game. If the girl hits an obstacle, the game ends and a game over menu is displayed. This shows the current score obtained by the player and the maximum score. It also has a ¨Play again¨ button that restarts the game when pressed.
   
3. **Assets**

   Inside the Assets folder you will find all the main content of the project organized by folders: animations, audio, icons, prefabs, scenes, scripts and sprites. The content of each folder will be explained below.
   
   - 3.1 **Animations**
   
     In the Animations folder you will find all the animations of the main character: the girl. The animations used are: Run and Jump. While the game is running, the girl runs and only jumps when the user touches the mobile screen. Also in the folder are the animations of one of the obstacles: the boy. The only animation used is "algo_walkingFrontLeft" which allows you to see the boy walking to the left.
     
   - 3.2 **Audio**
   
     In the Audio folder are three other folders: Music, Sounds, and SoundScripts. The Music folder contains the background song of the game which is repeated throughout the game. The Sounds folder contains different sounds that can be heard during the game, for example: GameOverWaver.wav sound is played when the player loses, Landing.wav is played when the girl hits the ground after jumping, Shout.wav is played when the girl jumps and Swing.wav is played when the girl touches a food. The SoundScripts folder contains two scripts: AudioManager and Sound. The AudioManager script is in charge of controlling everything related to the reproduction of sounds during the game. This script contains a Sounds arrangement where the developer himself can add all the necessary sounds in the game. It has two methods that passing the name of a sound allows you to play or pause the playback of said sound.
   
   - 3.3 **Icons**
     
     In the Icons folder there is a single image that represents the icon of the application once it is installed on the mobile
   
   - 3.4 **Prefabs**
   
     In the Prefabs folder you will find the objects that spawn in the scene during the game. For example: Barrel, Box and Leo are the obstacles that are constantly generated from time to time in the right area of the screen so that the player must avoid them. The other prefabs are foods that are also spawned constantly from time to time in the right area of the screen for the player to capture and thus increase his score.
   
   - 3.5 **Scenes**
   
     In the Scenes folder is where the different scenes of the video game are located. In this case the project is quite simple so there is only one scene.
   
   - 3.6 **Scripts**
   
     In the Scripts folder you will find all the scripts of the project, that is, all the videogame code. Next, the function of each script will be explained in a general way.
     
     - *BackgroundControl_0*: controls the background change of the game. It is responsible for replacing each of the layers of the parallax background to achieve the complete change of the background. It has two functions that allow you to switch to the next or previous background.
     
     - *CameraAnchor*: is in charge of adjusting and coupling the position of all the assets of the videogame within the screen regardless of the resolution or size of the mobile screen.
     
     - *CheckTrigger*: Check if the player collided with any trigger object. If it collided with a food then it plays a sound, increases the score, changes the background if the condition is met and deactivates the food. If it collided with an obstacle then it plays a sound, shows the Game Over menu and destroys the player.
     
     - *DeactivateObject*: deactivates the object if it collides with the limit that is in the left zone of the scene. This allows you to disable objects that no longer serve a purpose within the scene and thus avoid affecting performance.
     
     - *FoodSpawner*: randomly spawns a food object every certain amount of time. This time is chosen randomly in a small range. Food is spawned in the right area of the screen.
     
     - *GameManager*: this script contains methods that control the general configuration of the game. Among these methods are: AddScore() which increases the score; UpdateScore() which updates the score displayed on the screen; GameOver() which displays the Game Over panel when the player loses; RestartLevel() that is responsible for restarting the game; ChangeBackground() which takes care of changing the background every time the player earns five points; PauseGame() which displays the Pause panel and stops the game from running.
     
     - *InitialPosition*: saves the initial position of an object.
     
     - *MoveObject*: moves the object to the left with a certain speed.
     
     - *MusicManager*: control the music of the game. It has two methods, one to play and one to stop the music.
     
     - *ObjectPooler*: This script creates an "object pool". Before starting the game, it instantiates a certain number of objects and stores them in a list, creating a "pool" to later be used during the game. In this case, two pools were created: one for obstacles and the other for food. Once an item is needed from a pool, it is activated and used. When it is no longer needed then the object is deactivated. This increases the performance of the game since it allows you to avoid instantiating or destroying an object during the game, it is only done once, at the beginning.
     
     - *ObstacleSpawner*: randomly spawns an obstacle object every certain amount of time. This time is chosen randomly in a small range. Obstacle is spawned in the right area of the screen.
     
     - *ParallaxBackground_0*: controls the behavior of the parallax background. It sets each layer that makes up the background, controls the speed of each, and controls the speed of the camera along with the background.
   
   - 3.7 **Sprites**
   - 3.8 **TextMesh Pro**
