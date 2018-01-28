using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    [SerializeField]
    private float patrolDistance;
    Rigidbody2D rb;
    private float startPoint;
    private float endpoint;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        startPoint = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {

    }
}
