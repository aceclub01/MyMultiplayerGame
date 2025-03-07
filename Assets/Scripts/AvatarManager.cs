using Photon.Pun;
using TMPro; // Add TMP namespace
using UnityEngine;

public class AvatarManager : MonoBehaviour
{
    public GameObject[] avatarPrefabs;  // Array of avatar prefabs
    public TMP_Text avatarSelectionText; // TMP_Text for avatar selection text

    void Start()
    {
        int avatarIndex = (int)PhotonNetwork.LocalPlayer.CustomProperties["Avatar"]; // Retrieve selected avatar index
        Instantiate(avatarPrefabs[avatarIndex], transform.position, Quaternion.identity);

        avatarSelectionText.text = "Avatar Selected: " + avatarPrefabs[avatarIndex].name; // TMP_Text update
    }
}
