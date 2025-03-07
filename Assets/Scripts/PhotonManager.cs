using Photon.Pun;
using UnityEngine;
using TMPro;
using Photon.Realtime;
public class PhotonManager : MonoBehaviourPunCallbacks
{
    public TMP_Text connectionStatusText;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        connectionStatusText.text = "Connected to Master Server";
        Debug.Log("Connected to Photon Master Server");
    }

    public override void OnDisconnected(Photon.Realtime.DisconnectCause cause)
    {
        connectionStatusText.text = "Disconnected: " + cause.ToString();
        Debug.Log("Disconnected from Photon: " + cause.ToString());
    }

    public override void OnJoinedRoom()
    {
        connectionStatusText.text = "Joined Room: " + PhotonNetwork.CurrentRoom.Name;
    }
}
