using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    // Start is called before the first frame update
    private float speed = 4;
    private float time = 2;
    private float x = 0;
    private float z = 0;


    Vector2 pos = Vector2.zero;
    private float iconX;
    private float iconY;
    private GameObject ememyIcon;
    private RectTransform UiTrs;
    void Start() {
        ememyIcon = MiniMap.Instance.AddIocn(MiniMap.IconType.Enemy);
        UiTrs = ememyIcon.GetComponent<RectTransform>();
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
        if (UiTrs != null) {
            iconX = (transform.localPosition.x / 100) * 200 + 100;
            iconY = (transform.localPosition.z / 100) * 200 - 100;
            if (iconX >= 0 && iconX <= 200 && iconY >= -200 && iconY <= 0) {
                ememyIcon.SetActive(true);
                pos.x = iconX;
                pos.y = iconY;
                UiTrs.anchoredPosition = pos;
            } else {
                ememyIcon.SetActive(false);
            }

        }
    }
}
