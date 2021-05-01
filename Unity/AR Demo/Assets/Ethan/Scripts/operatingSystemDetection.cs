/*
Ethan Herndon
Capstone CST 499; Search and Rescue AR prototype
Spring 2021
Description: This program detects which operating system the game is on, then
determining actions from there.
Reference: https://mariusschulz.com/blog/detecting-the-operating-system-in-net-core
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class operatingSystemDetection : MonoBehaviour
{

    public Text OSText; //This text is only for testing.

    // Start is called before the first frame update
    void Start()
    {
        if (OperatingSystem.IsWindows()) //check if we are on Windows.
        {
            OSText.text = "Windows";
            //Debug.Log("We're on Windows!");
            //TODO: Allocate functionality to host.
        }

        if (OperatingSystem.IsLinux()) //check if we are on Android in this case.
        {
            OSText.text = "Android";
            //Debug.Log("We're on Android!");
            //TODO: Allocate functionality to client.
        }

    }

    public static class OperatingSystem
    {
        public static bool IsWindows() =>
          RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        public static bool IsLinux() =>
          RuntimeInformation.IsOSPlatform(OSPlatform.Linux);

        /*public static bool IsMacOS() =>
        RuntimeInformation.IsOSPlatform(OSPlatform.OSX)*/

    }

}