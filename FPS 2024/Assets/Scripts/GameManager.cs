using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviourPunCallbacks
{
    #region Singleton
    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    #endregion

    const string playerPrefabPath = "Prefabs/Player";

    int playerInGame;
    List<PlayerController> playerList = new List<PlayerController>();
    PlayerController playerLocal;
    private void Start()
    {
        photonView.RPC("AddPlayer", RpcTarget.AllBuffered);// so quem ta na ssla e carregou a cena atual esse buff
    }
    private void CreatePlayer()
    {
        PlayerController player = NetworkManager.instance.InstanceRPC(playerPrefabPath, new Vector3(30, 1, 30), Quaternion.identity).GetComponent<PlayerController>();
        player.photonView.RPC("Initialize", RpcTarget.All);
    }
    [PunRPC]
    private void AddPlayer()
    {
        playerInGame++;
        if (playerInGame == PhotonNetwork.PlayerList.Length)
        {
            CreatePlayer();
        }
    }
}
