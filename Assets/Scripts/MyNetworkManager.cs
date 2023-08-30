using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class MyNetworkManager : NetworkManager
{
    public override void OnClientConnect() {
        base.OnClientConnect();

        Debug.Log("Client connected to the server.");
    }

    public override void OnServerAddPlayer(NetworkConnectionToClient conn) {
        base.OnServerAddPlayer(conn);

        Color displayColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        MyNetworkPlayer player = conn.identity.GetComponent<MyNetworkPlayer>();

        player.SetDisplayName($"Player {numPlayers}");
        player.SetDisplayColor(displayColor);

        Debug.Log($"There are now {numPlayers} players are on the server.");
    }
}
