# TapVRap 2
The name lies this will be a motion controlled gamepad for the Tap Strap.

# HackCU resutls
We got the raw data and saw the live feed of that data.  
We only used accelerometer data because of time constraitns.  
Data was output to a file that was immediatly read by a python script that ploted changes in each of the 3 axis returned by the Tap Strap.  
user32.dll was used to generate keyboard events.  

# Issues
user32.dll made keyboard events that were only chars. It did not behave like a gamepad.  

# To work on
Look into the arduino game libraries.
Look into the pyvjoy module in python.  
Make a linux fork of the python SDK so I can actually develop something to work for me D:  

# Plan of action
Being the linux user I am, I will make this work on linux first.
Step one(Hard): Get raw data in linux  
Step two(easierByComparison): look at the data again and set up good custom gestures
Step Three(easiest): Tie those gestures to certain in game actions
Step four(hardest): Play Hollow Knight and be good at the game with hand motions

# Steps for Step one
Fork Python-tap-sdk and add linux support......yeah....oof 
Here is my progress with that....
https://github.com/jnunez101/tap-python-sdk

