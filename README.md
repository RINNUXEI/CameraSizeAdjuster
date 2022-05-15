# CameraSizeAdjuster
A Unity script to adjust camera size according to different aspect ratios.

![CameraSizeAdjuster](https://user-images.githubusercontent.com/12996966/168434015-742cc329-3ab2-4bfa-a54c-210f1babe602.png)

# Features
- Automatically adjust the camera's size so that the center area always keeps its original aspect ratio. 
- Use pillarboxing if the target screen is wider than original.
- Use letterboxing if the target screen is taller than original.
- Support both orthographic and perspective cameras.
- Preview of original aspect ratio viewport.

# How to use
1. Import the unitypackage into your Unity project.
2. Make sure that the CameraSizeAdjusterEditor.cs is under an Editor folder.
3. Attach CameraSizeAdjuster.cs onto your camera object.
4. Set the *Base Aspect Ratio* field to your desired original aspect ratio.
5. When your camera is under orthograpic projection, set the *Base Camera Size* field to your desired original camera size.
6. Notice that the size of your camera changes properly responding to different screen sizes.  
7. When your camera is under perspective projection, set the *Base Camera FOV* field to your desired original camera FOV.
6. Notice that the field of view of your camera changes properly responding to different screen sizes.
7. You can toggle on the *Show Base Aspect Area* field to show a preview of your original aspect ratio viewport.
