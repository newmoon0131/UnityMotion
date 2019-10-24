using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cSharpTutorial : MonoBehaviour {

    [Header("欄位")]
    [Range(0 , 100)]
    public int score = 80;

    [Header("速度")]
    [Range(-1,5)]
    public float speed = 1.5f;

    [Header("道具") , Tooltip("放置紅色藥水")]
    public string prop = "藥水";

    [Header("任務")]
    public bool mission = false;

    public Vector2 v2 = new Vector2(10, 80);
    public Vector3 v3 = new Vector3(10, 40,50);

    public Color blue = Color.blue;
    public Color red = new Color(0.7f, 0.1f, 0.2f);
}
