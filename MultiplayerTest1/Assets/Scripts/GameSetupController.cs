using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameSetupController : MonoBehaviour
{
    //public GameObject prefab;
    void Start()
    {
        CreatePlayer();
    }

    private void CreatePlayer()
    {
        Debug.Log("Creating Player");
        GameObject instance= PhotonNetwork.Instantiate("FingerPrint", Vector3.zero, Quaternion.identity);
        instance.GetComponent<FingerPrintMovement>().enabled=true;
    }

    

}
