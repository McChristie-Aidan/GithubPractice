using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    GameObject Player = null;
    Vector3 PlayerPosition;
    public float speed = 30f;
    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        if (Player == null)
        {
            Player = GameObject.Find("Player");
        }
        PlayerPosition = Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3.MoveTowards(this.gameObject.transform.position, PlayerPosition, speed * Time.deltaTime);
    }
}
