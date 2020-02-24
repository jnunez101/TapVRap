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

