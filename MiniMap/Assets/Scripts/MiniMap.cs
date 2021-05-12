using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class MiniMap : MonoBehaviour {
    // Start is called before the first frame update
    public static MiniMap Instance;
    public GameObject iconPrefab;
    public Transform miniMapTrs;
    private Hashtable iconList;
    public Sprite ememyIcon;
    public Sprite playerIcon;
    void Awake() {
        Instance = this;
        iconList = new Hashtable();
        iconList.Add("playIconList", new List<GameObject>());
        iconList.Add("enemyIconList", new List<GameObject>());
    }
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public enum IconType {
        Player,
        Enemy,
    }
    public void AddIocn(IconType iconType) {
        GameObject icon = Instantiate(iconPrefab, miniMapTrs);
        icon.transform.localPosition = Vector3.zero;
        icon.transform.localScale = Vector3.one;
        icon.transform.localRotation = Quaternion.identity;
        List<GameObject> list;
        switch (iconType) {
            case IconType.Enemy:
                list = (List<GameObject>)iconList["enemyIconList"];
                list.Add(icon);
                icon.name = "EnemyIcon" + list.Count;
                icon.GetComponent<Image>().sprite = ememyIcon;
                break;
            case IconType.Player:
                list = (List<GameObject>)iconList["playIconList"];
                list.Add(icon);
                icon.name = "PlayerIcon" + list.Count;
                icon.GetComponent<Image>().sprite = playerIcon;
                break;
        }
    }
}
