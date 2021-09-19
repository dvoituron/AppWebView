# AppWebView
Light application to display a web site like a real application. Example: Outlook, Teams, ...

# How to use?

1. First, download the last [Release version](https://github.com/dvoituron/AppWebView/releases)
   and exact all files into a local folder. This folder will contains all data stored by the browser.

2. Check if **Microsoft Edge WebView2 Runtime** is already installed on your PC.
   If not, [download the WebView2 Runtime](https://developer.microsoft.com/en-us/microsoft-edge/webview2/) 
   (**Evergreen Standalone** Installer - second columns) and install it.

   If you don't have administration rights on your PC, you can download a **Fixed Version of Edge** (same download page - third column).
   Open the configuration window (Right-click on the top bar) and load this CAB file into the application.
   Restart the application to apply these changes.

3. Run the **AppWebView.exe** file and configure your startup page :
   Right-click on the top bar and select `Configuration...`.
   Restart the application to apply these changes.
   
# Demonstration
  [![Demo](https://img.youtube.com/vi/4by5R63kDkA/0.jpg)](https://www.youtube.com/watch?v=4by5R63kDkA)


# Release notes

1.2 Add a configuration to use a [Fixed Version of Edge](https://developer.microsoft.com/en-us/microsoft-edge/webview2).
    Download the Fixed version of Edge and extract the download CAB into a subfolder of the application.
    You can check the Edge version using the Developer Console F12 and writing `navigator.userAgent` in the console.

1.1 Fix the startup position.

1.0 First version