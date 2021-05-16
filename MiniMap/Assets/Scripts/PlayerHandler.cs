using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour {
    // Start is called before the first frame update
    public float speed = 4f;
    private GameObject playerIcon;
    private RectTransform UiTrs;
    Vector2 pos = Vector2.zero;
    private float x;
    private float y;

    void Start() {
        playerIcon = MiniMap.Instance.AddIocn(MiniMap.IconType.Player);
        UiTrs = playerIcon.GetComponent<RectTransform>();
    }

    void Awake() {

    }

    // Update is called once per frame
    void Update() {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(h, 0, v) * speed * Time.deltaTime);
        if (UiTrs != null) {
            x = (transform.localPosition.x / 100) * 200 + 100;
            y = (transform.localPosition.z / 100) * 200 - 100;
            if (x >= 0 && x <= 200 && y >= -200 && y <= 0) {
                playerIcon.SetActive(true);
                pos.x = x;
                pos.y = y;
                UiTrs.anchoredPosition = pos;
            } else {
                playerIcon.SetActive(false);
            }

        }
        // if (Input.GetKeyDown(KeyCode.P)) {
        //     MiniMap.Instance.AddIocn(MiniMap.IconType.Player);
        // }
        // if (Input.GetKeyDown(KeyCode.E)) {
        //     MiniMap.Instance.AddIocn(MiniMap.IconType.Enemy);
        // }
    }
}
