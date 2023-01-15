using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{

    public float flapStrenght;

    public Rigidbody2D myRigidBody;

    public LogicManager logicScript;

    private bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive & Input.GetKeyDown(KeyCode.Space)) {
            myRigidBody.velocity = Vector2.up * flapStrenght;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        isAlive = false;
        logicScript.gameOver();
    }
}
