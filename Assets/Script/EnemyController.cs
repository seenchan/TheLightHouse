using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject Player;

    private Vector3 targetPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetPos = this.transform.position - Player.transform.position;
        this.GetComponent<Rigidbody>().AddForce(new Vector3(targetPos.x, 0, targetPos.z));
    }
}
