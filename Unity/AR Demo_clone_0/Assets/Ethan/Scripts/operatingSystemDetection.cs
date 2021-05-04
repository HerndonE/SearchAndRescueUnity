/*
Ethan Herndon
Capstone CST 499; Search and Rescue AR prototype
Spring 2021
Description: This program detects which operating system the game is on, then
determining actions from there for this project.
Reference: https://mariusschulz.com/blog/detecting-the-operating-system-in-net-core
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

/* Notes
 * Host functionalities:
 * 1. Big Map
 * 2. No Join Button
 * 3. Control Functionality
 * 4. Set a flight path
 * 5. Change camera to default camera
 * 6. UI modified for PC
 * 
 * Client functionalities:
 * 1. No display of IP address
 * 2. No Host Button
 * 3. No Control Functionality
 * 4. No Minimap
 */

public class operatingSystemDetection : MonoBehaviour
{

    public Text OSText; //This text is only for testing.

    //Control Functionality Buttons
    public Button forwardButton;
    public Button backwardButton;
    public Button leftButton;
    public Button rightButton;
    public Button airplaneModeOn;
    public Button airplaneModeOff;

    //Connection Panel
    public Button hostButton;
    public Button joinButton;
    public InputField IPAddressInput;
    public Text IPAddressText;

    //Minimap
    public Camera miniMapCamera;
    public RawImage rawImage;

    //Passenger
    public Camera pilotCamera;

    // Start is called before the first frame update
    void Start()
    {
        //HOST
        if (OperatingSystem.IsWindows()) //check if we are on Windows.
        {
            //OSText.text = "Windows";
            //Debug.Log("We're on Windows!");

            hostFeatures();
        }

        //CLIENT
        if (OperatingSystem.IsLinux()) //check if we are on Android in this case.
        {
            //OSText.text = "Android";
            //Debug.Log("We're on Android!");

            clientFeatures();

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

    public void hostFeatures()
    {
        //OSText.gameObject.SetActive(true);
        joinButton.gameObject.SetActive(false);
        IPAddressInput.gameObject.SetActive(false);

        //TODO: Make Minimap big
        //Since host is a computers. Use WASD for controls and not GUI Buttons?
        //Resize UI
    }

    public void clientFeatures()
    {
        OSText.gameObject.SetActive(false);
        forwardButton.gameObject.SetActive(false);
        backwardButton.gameObject.SetActive(false);
        leftButton.gameObject.SetActive(false);
        rightButton.gameObject.SetActive(false);
        airplaneModeOn.gameObject.SetActive(false);
        airplaneModeOff.gameObject.SetActive(false);

        IPAddressText.gameObject.SetActive(false);
        hostButton.gameObject.SetActive(false);

        miniMapCamera.gameObject.SetActive(false);
        rawImage.gameObject.SetActive(false);

        //pilotCamera.gameObject.SetActive(false);



        //TODO: Resize UI
    }

}