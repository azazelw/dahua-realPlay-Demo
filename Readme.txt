[Introduction]
The demo program introduces SDK initialization, login, logout, auto reconnection, start monitoring, stop monitoring, snapshot, enable saving stream, disable saving stream, PTZ control.
The demo program demonstrates selecting channel and stream type before live view, PTZ control ( including direction control), and the function of changing step, zoom, focus and iris when the device is connected. 

[Interfaces]
NETClient.Init Initialize SDK and set disconnection callback
NETClient.SetAutoReconnect Set auto reconnection callback
NETClient.SetDVRMessCallBack Set snapshot callback
NETClient.LoginWithHighLevelSecurity Login
NETClient.Logout  Logout
NETClient.RealPlay Start real time monitor
NETClient.SetRealDataCallBack Set real time monitoring data callback
NETClient.StopRealPlay Stop monitoring
NETClient.SnapPictureEx Snapshot
NETClient.SnapPictureEx  Local snapshot
NETClient.SaveRealData Save monitoring data
NETClient.StopSaveRealData Stop saving  monitoring data
NETClient.PTZControl PTZ control
NETClient.Cleanup Release SDK resources

[Notice]
1. When the compiling environment is VS2010, NETSDKCS library can support the version of .NET Framework 4.0 or newer. If you want to use the version older than .NET Framework 4.0, change the method of using NetSDK.cs in IntPtr.Add. We will not support the modification.
2. The demo program supports  single channel and single device live view.
3. The demo program does not support multiple devices login.
4. Issue: No response to snapshot. Cause: The device does not support. For example: intelligent traffic device has special snapshot interface, but it does not support common snapshot; Whether NVR can snapshot depending on whether the connected IPC supports snapshot. 
5. Start saving. If the saved record is in Dahua video format, it can be only played by Dahua playing SDK or Dahua player.
6. Copy all file in the libs directory of General_NetSDK_ChnEng_CSharpXX_IS_VX.XXX.XXXXXXXX.X.R.XXXXXX to the build directory of bin directory of the corresponding demo programs.
7. Copy all file in the libs directory of General_NetSDK_ChnEng_CSharpXX_IS_VX.XXX.XXXXXXXX.X.R.XXXXXX to the build directory of bin directory of the corresponding demo programs.


