:: Run App With Args
@ECHO OFF
cd /D %~dp0
start MegaTecBattDriverRestart.exe Enable {745a17a0-74d3-11d0-b6fe-00a0c90f57da} HID\VID_0001&PID_0000\6&7EFA158&0&0000
:: start MegaTecBattDriverRestart.exe Disable {745a17a0-74d3-11d0-b6fe-00a0c90f57da} HID\VID_0001&PID_0000\6&7EFA158&0&0000
:: start MegaTecBattDriverRestart.exe Toggle {745a17a0-74d3-11d0-b6fe-00a0c90f57da} HID\VID_0001&PID_0000\6&7EFA158&0&0000
:: start MegaTecBattDriverRestart.exe ToggleMegaTec
pause