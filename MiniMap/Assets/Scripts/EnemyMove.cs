using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    // Start is called before the first frame update
    private float speed = 4;
    private float time = 2;
    private float x = 0;
    private float z = 0;
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        time += Time.deltaTime;
        if (time >= 2) {
            time = 0;
            x = Random.Range(-1f, 1f);
            z = Random.Range(-1f, 1f);
        }
        transform.Translate(new Vector3(x, 0, z) * speed * Time.deltaTime);
    }
}
