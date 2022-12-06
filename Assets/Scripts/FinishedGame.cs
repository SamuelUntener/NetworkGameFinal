using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishedGame : NetworkBehaviour
{

    public Button btnHost;
    public Button btnClient;
    public TMPro.TMP_Text txtStatus;

    public void StartNewGame()
    {
        btnHost.onClick.AddListener(OnHostClickedNew);
        btnClient.onClick.AddListener(OnClientClickedNew);
        Application.targetFrameRate = 30;
    }

    private void StartNewHost()
    {
        NetworkManager.Singleton.StartHost();
        NetworkManager.SceneManager.LoadScene(
            "Lobby",
            UnityEngine.SceneManagement.LoadSceneMode.Single);
    }



    private void OnHostClickedNew()
    {
        btnClient.gameObject.SetActive(false);
        btnHost.gameObject.SetActive(false);
        txtStatus.text = "Starting Host";
        StartNewHost();
    }

    private void OnClientClickedNew()
    {
        btnClient.gameObject.SetActive(false);
        btnHost.gameObject.SetActive(false);
        txtStatus.text = "Waiting on Host";
        NetworkManager.Singleton.StartClient();
    }
}