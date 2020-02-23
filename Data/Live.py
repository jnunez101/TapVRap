from pylive import live_plotter
import numpy as np
import time

def cleanData(line):
    
    return line.astype(np.float)

def follow(thefile):
    thefile.seek(0,2)
    while True:
        line = thefile.readline()
        if not line:
            time.sleep(0.1)
            continue
        yield line

if __name__ == '__main__':
    logfile = open("E:/laure/Documents/HackUTD/TapVRap/tap-standalonewin-sdk-master/TAPWinApp/bin/Debug/data.txt","r")
    loglines = follow(logfile)
    axis = 1
    
    size = 100
    x = np.linspace(0,1,size+1)[0:-1]
    y = np.zeros(len(x))
    
    line1 = []
    for line in loglines:
        data = line.split(',')
        data = np.array(data)
        newData = cleanData(data)
    
        y[-1] = newData[axis]
        line1 = live_plotter(x,y ,line1)
        y = np.append(y[1:],0.0)
    
