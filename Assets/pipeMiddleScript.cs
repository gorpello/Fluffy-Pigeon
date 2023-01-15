using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMiddleScript : MonoBehaviour
{

    public LogicManager logicScript;

    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("Increase Point");
        if(collision.gameObject.layer == 3) {
            logicScript.addScore(1);
        }
        
    }

}
