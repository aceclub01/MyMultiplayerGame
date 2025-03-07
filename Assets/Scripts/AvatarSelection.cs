using TMPro; // Add TMP namespace
using UnityEngine;

public class AvatarSelection : MonoBehaviour
{
    public TMP_Text avatarNameText;  // TMP_Text for displaying avatar name

    void Start()
    {
        avatarNameText.text = "Select your Avatar"; // TMP_Text update
    }

    // This function will set the avatar name based on selected avatar
    public void SetAvatarName(string avatarName)
    {
        avatarNameText.text = "Selected Avatar: " + avatarName; // TMP_Text update
    }
}
