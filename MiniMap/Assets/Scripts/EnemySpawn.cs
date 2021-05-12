using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {
    public GameObject enemyPrefab;

    private float time = 0;

    private float enemyNum = 0;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        time += Time.deltaTime;
        if (time >= 5 && enemyNum <= 15) {
            Instantiate(enemyPrefab, new Vector3(Random.Range(-5, 5), 1, Random.Range(-5, 5)), Quaternion.identity);
            enemyNum++;
            time = 0;
            GameObject go = MiniMap.Instance.AddIocn(MiniMap.IconType.Enemy);
        }
    }
}
