# kinect-thesis-exergaming
Thesis Repository - Game Design for Kinect Application for Exergaming case study

On every scene we have a camera - we need to attach the SetAvatarController.

We load the KinectObject only once, statically instantiate for having it being passed through co-routines in C# and Unity. In such way, we are ensuring that the camera is not calibrated again on every scene, but it remains the same throughout the whole game procedures.

Additionally we are having the LoadingScene.unity scene for any loading procedures between the scenes of the game, in order to provide the user with feedback on what is the expected delay. We are also ensuring to asynchronously load our scenes there and not delay with any objects being loaded in a scene environment.

Actions for now are restricted to 3:
1. Wave for initial interaction with the game
2. Push for changing between the scenes
3. SwipeLeft for leaving the game

According to bibliography, gesture should be limited to 6.
