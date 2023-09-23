# MegaTec Battery Driver Restart

[<img src="img/4.jpg" width="500"/>](img/4.jpg)

This application was made for the old **MegaTec UPS** devices that use the *UPSilion* software.

Using Windows 11 with the UPSilion software works however when plugged in to USB3.0/USB.3.1 every time the PC boots up 
you will get an error "The UPS device has been disconected"

Now if you toggle the driver enable/disable in the `computer managment` > `Device Manager` > `HID-compliant` device *VID_0001* & *PID_0000*

The UPS will connect again, and this must be done everytime you boot up.

Since the pc asks to restart after changing the device enable/disable

You will get an error `The data is invalid` if running it more than once without restarting (*sometimes also running for the first time)

It will also only successfully change the driver once after a restart but the toggle does work.
