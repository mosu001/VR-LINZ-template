/**********************************************************************************************************************************************************
 * XRUX_SetText
 * ------------
 *
 * 2021-08-29
 *
 * Changes the text on a TextMeshPro item.  Add this to a TextMeshPro item and then use this in XR UX controls.
 *
 * Roy Davies, Smart Digital Lab, University of Auckland.
 **********************************************************************************************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// ----------------------------------------------------------------------------------------------------------------------------------------------------------
// Public functions
// ----------------------------------------------------------------------------------------------------------------------------------------------------------
public interface IXRUX_SetText
{
    void Input(Vector3 newTitle); // Change the text
    void Input(string newTitle); // Change the text
    void Input(int newTitle); // Change the text
    void Input(float newTitle); // Change the text
    void Input(bool newTitle); // Change the text
    void Input(XRData newTitle); // Change the text

    string Text();
}
// ----------------------------------------------------------------------------------------------------------------------------------------------------------



// ----------------------------------------------------------------------------------------------------------------------------------------------------------
// Main class
// ----------------------------------------------------------------------------------------------------------------------------------------------------------
[AddComponentMenu("OpenXR UX/Tools/XRUX Set Text")]
public class XRUX_SetText : MonoBehaviour, IXRUX_SetText
{
    // ------------------------------------------------------------------------------------------------------------------------------------------------------
    // Public variables
    // ------------------------------------------------------------------------------------------------------------------------------------------------------

    // ------------------------------------------------------------------------------------------------------------------------------------------------------



    // ------------------------------------------------------------------------------------------------------------------------------------------------------
    // Private variables
    // ------------------------------------------------------------------------------------------------------------------------------------------------------
    private TextMeshPro textDisplay;
    // ------------------------------------------------------------------------------------------------------------------------------------------------------



    // ------------------------------------------------------------------------------------------------------------------------------------------------------
    // Overloaded functions for various types
    // ------------------------------------------------------------------------------------------------------------------------------------------------------
    public void Input(float theItem) { Input (theItem.ToString()); }
    public void Input(int theItem) { Input (theItem.ToString()); }
    public void Input(bool theItem) { Input (theItem.ToString()); }
    public void Input(Vector3 theItem) { Input (XRData.FromVector3(theItem)); }
    public void Input(XRData theItem) { Input (theItem.ToString()); }
    public void Input(string theItem)
    {
        if (textDisplay != null) textDisplay.text = theItem;
    }
    // ------------------------------------------------------------------------------------------------------------------------------------------------------



    // ------------------------------------------------------------------------------------------------------------------------------------------------------
    // ------------------------------------------------------------------------------------------------------------------------------------------------------
    public string Text()
    {
        return ((textDisplay == null) ? "" : textDisplay.text);
    }
    // ------------------------------------------------------------------------------------------------------------------------------------------------------



    // ------------------------------------------------------------------------------------------------------------------------------------------------------
    // Refresh the display when turned on.
    // ------------------------------------------------------------------------------------------------------------------------------------------------------
    void OnEnable()
    {
        textDisplay = GetComponent<TextMeshPro>();
    }
    // ------------------------------------------------------------------------------------------------------------------------------------------------------



    // ------------------------------------------------------------------------------------------------------------------------------------------------------
    // Set up the variables ready to go.
    // ------------------------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        textDisplay = GetComponent<TextMeshPro>();
    }
    // ------------------------------------------------------------------------------------------------------------------------------------------------------
}