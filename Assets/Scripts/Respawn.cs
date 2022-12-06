using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
using UnityEngine.SceneManagement;
using TMPro;

public class Respawn : NetworkBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var scene = NetworkManager.SceneManager.LoadScene(
            "Arena1",
            UnityEngine.SceneManagement.LoadSceneMode.Single);
    }
}
