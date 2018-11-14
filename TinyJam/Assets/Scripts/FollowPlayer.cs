using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public GameObject player = null;

    public float offset = 10.0f;

	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.transform.position.x + offset, transform.position.y, -10);

	}
}
