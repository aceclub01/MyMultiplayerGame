using Photon.Pun;
using UnityEngine;
using TMPro;  // Make sure you are using TextMeshPro for Text components
using Photon.Realtime;
public class LobbyUI : MonoBehaviour
{
    public TMP_Text roomText;
    public TMP_Text playerNameText;
    public TMP_InputField playerNameInput;
    public GameObject joinRoomButton1;
    public GameObject joinRoomButton2;
    public GameObject joinRoomButton3;

    // This function will be called when the player clicks the 'Join Room 1' button
    public void OnJoinRoom1ButtonClicked()
    {
        string playerName = playerNameInput.text;
        PhotonNetwork.NickName = playerName;
        PhotonNetwork.JoinRoom("Room1"); // Joining the fixed Room1
        playerNameText.text = "Player: " + playerName;
        roomText.text = "Room: Room 1";
    }

    // This function will be called when the player clicks the 'Join Room 2' button
    public void OnJoinRoom2ButtonClicked()
    {
        string playerName = playerNameInput.text;
        PhotonNetwork.NickName = playerName;
        PhotonNetwork.JoinRoom("Room2"); // Joining the fixed Room2
        playerNameText.text = "Player: " + playerName;
        roomText.text = "Room: Room 2";
    }

    // This function will be called when the player clicks the 'Join Room 3' button
    public void OnJoinRoom3ButtonClicked()
    {
        string playerName = playerNameInput.text;
        PhotonNetwork.NickName = playerName;
        PhotonNetwork.JoinRoom("Room3"); // Joining the fixed Room3
        playerNameText.text = "Player: " + playerName;
        roomText.text = "Room: Room 3";
    }

    // Optionally, you can have a function for when the player disconnects
    public void OnDisconnectButtonClicked()
    {
        PhotonNetwork.Disconnect();
    }
}
