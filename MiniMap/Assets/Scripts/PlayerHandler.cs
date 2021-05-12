using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour {
    // Start is called before the first frame update
    public float speed = 4f;
    void Start() {

    }

    void Awake() {
        MiniMap.Instance.AddIocn(MiniMap.IconType.Player);
    }

    // Update is called once per frame
    void Update() {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(h, 0, v) * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.P)) {
            MiniMap.Instance.AddIocn(MiniMap.IconType.Player);
        }
        if (Input.GetKeyDown(KeyCode.E)) {
            MiniMap.Instance.AddIocn(MiniMap.IconType.Enemy);
        }
    }
}
