# Unity DAURAR (Dual-Arm-Universal-Robot5-Augmented-Reality)

### This repo is the Unity component for the DAURAR project for the Dual-Arm UR5 manipulators in the MuLIP lab at Tufts University. [ROS_DAURAR](https://github.com/DreVinciCode/ROS_DAURAR) is the ROS component of the project.

I didn't have enough git lfs storage for the vuforia *.tgz file.
Used USB drive to manually transfered file and added file type to gitignore file.

![Alt text](demos/animatedTrajectory.gif)
<br/> Viewed on a Hololens2 Device

![Alt text](demos/future_plan.gif)
<br/> Viewed on an Android Device

## Project is deployed on Andriod and Hololens2


ROS Sharp package: https://github.com/DreVinciCode/ros-sharp (Forked from modified repo for compatability for UWP)
Place both RosSharp folder and Plugins folder into Unity Assets folder.


## Important Configuration Settings

ROS Connector (Script) 
-Set Serializer to Newtonsoft_JSON
-Set Protocol to Web Socket UWP

In Publisher Settings also checkbox "PrivateNetworkClientServer",  "InternetClientSever" , and "InternetClient"
