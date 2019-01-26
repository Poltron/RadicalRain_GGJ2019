﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderGitan : MonoBehaviour
{
    [HideInInspector]
    public float Speed;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + Speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("PlayerLost");
            GameManager.Instance.PlayerLost(other.gameObject.GetComponent<PlayerController>());
        }
        if (other.tag == "Wall")
        {
            Destroy(gameObject);
        }
        if (other.tag == "Item")
        {
            Destroy(other.gameObject);
        }
    }
}
