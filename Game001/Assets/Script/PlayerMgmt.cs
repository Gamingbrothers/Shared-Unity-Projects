using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMgmt : MonoBehaviour {

    public GameObject seeker;

    void OnMouseDown()
    {
        GameObject unit = (GameObject)Instantiate(seeker, transform.position, Quaternion.identity); 
    }

}
