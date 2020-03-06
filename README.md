# TapVRap 2
The name lies this will be a motion controlled gamepad for the Tap Strap.

# HackCU resutls
We got the raw data and saw the live feed of that data.  
We only used accelerometer data because of time constraitns.  
Data was output to a file that was immediatly read by a python script that ploted changes in each of the 3 axis returned by the Tap Strap.  
user32.dll was used to generate keyboard events.  

# Issues
user32.dll made keyboard events that were only chars. It did not behave like a gamepad.  

# To work on(Broad goals)
Look into the arduino game libraries.
Look into the pyvjoy module in python.  
Make a linux fork of the python SDK so I can actually develop something to work for me D:  
Set up games to work
Integrate 3 massive formulas to determine position in 3D space

# Things to do with the Data
Clean up noise data....
The accelerometers (spelling it different every time :p) will be spitting out a lot of data.
The human hand is never perfectly still so there will be a lot of noise that will lead to jitters in any game
With the clean data it "should" be possible to inaccuratly track motion in 3D space
Average the 5 accelerometers in each finger to increase accuracy and lower the chances of one accelerometer making your hand fly a mile
FIND UNITS FOR THE DATA!!!!!!BEFORE ANY OF THIS PLEASE


# Plan of action
Being the linux user I am, I will make this work on linux first.
Step one(Hard): Get raw data in linux  
Step two(easierByComparison): look at the data again and set up good custom gestures
Step Three(easiest): Tie those gestures to certain in game actions
Step four(hardest): Play Hollow Knight and be good at the game with hand motions
Step five(somewhat easier): I want to make a program that auto detects the game played and changes its controls to fit the game....
Step six(Probably take a long time): Map the position of the tapstrap in 3 dimensional space using some really really nice formulas(I will derive them on a whiteboard later)
Step seven(hardest by far): Map that to control some form of VR. I 100% believe it will be inaccurate as it will be purely based on math and accelerameters. (maybe implement a recalibration posture/button/action)

# Steps for Step one
Fork Python-tap-sdk and add linux support......yeah....oof 
Here is my progress with that....
https://github.com/jnunez101/tap-python-sdk

