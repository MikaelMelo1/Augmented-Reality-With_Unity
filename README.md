
# Animals in 3D
This project uses Unity and Vuforia to create an interactive Augmented Reality (AR) experience with animals. Point your device's camera at the target images and see 3D models of animals appear on your screen, accompanied by their respective real-life photos! A fun and immersive way to learn about the animal kingdom.

## Features

Platform: Unity 2022.3.50f1

AR SDK: Vuforia Engine 10.27.3

Functionalities:
- Image recognition.
- Object tracking.
- Simple animal animations.
- Display of the real animal image.
- Supported Devices: Android (arm7, amd64) 8+


## Prerequisites

- Unity 2022.3.50f1 installed with the Vuforia module added.

To install Vuforia Engine:
- Open Unity Hub.
- Go to "Installs".
- Select version 2022.3.50f1 and click on the three vertical dots.
- Click on "Add Modules".
- Check the "Vuforia Engine" option and click "Done".
- A Vuforia license key (free or paid).
- An AR compatible Android device (arm7 or amd64) with Android 8.0 or higher.
- Printed targets for image recognition (available in the Assets/Targets folder)
## How to run the project



Clone this repository.


```bash
git clone https://github.com/MikaelMelo1/Augmented-Reality-With_Unity
```

Open the project in Unity.

Insert your Vuforia license key in Vuforia Configuration (Window > Vuforia Configuration).

Print the targets available in the Assets/Targets folder.

Build and run the project on your Android device.



## Project Structure

- Assets: Contains all project assets, including 3D models, textures, scripts, and scenes.
- Scenes: Contains the Unity scenes.
- Scripts: Contains the C# scripts that control the project's behavior.
- Models: Contains the 3D models of the animals.
- Materials: Contains the materials used in the 3D models.
- Prefabs: Contains the prefabs used in the project.
- Targets: Contains the images of the targets for printing.
- ProjectSettings: Contains the Unity project settings
## Demo

https://youtu.be/D0m47gDsghQ