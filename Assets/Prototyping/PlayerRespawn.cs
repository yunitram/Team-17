using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] public Transform SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Respawn() {
        transform.position = SpawnPoint.position;
    }
}
