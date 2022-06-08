using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class Button : MonoBehaviour
{
    public int currentNo = 0;
    private float nextPos = -100;
    // Start is called before the first frame update
    void Start()
    {
//         var player = GameObject.Find("Player");
//         var tf = player.GetComponent<Transform>();
//         var posY = tf.position;
//         posY.y += 1.2f;
//         tf.position = posY;
    }

    // Update is called once per frame
    void Update()
    {
                // if (nextPos > -100) {
//             var tf = GetComponent<Transform>();
        var player = GameObject.Find("Player");
        var tf = player.GetComponent<Transform>();
        
        if(tf.position.x < nextPos) {
            var pos = tf.position;
//             pos.x += 0.1f;
            pos.x = nextPos;
            tf.position = pos;
        } 
    }
    
    void LastUpdate()
    {
//         var player = GameObject.Find("Player");
//         var tf = player.GetComponent<Transform>();
//         var pos = tf.position;
//         pos.y -= 1.2f;
//         tf.position = pos;
    }

    public void OnClick () {
        Debug.Log("押された");
         var player = GameObject.Find("Player");
        var tf = player.GetComponent<Transform>();
        var posY = tf.position;
        posY.y += 1.2f;
        tf.position = posY;
        // gameObject.GetComponent<DiceLabel>().Text = 1;
        var dl = (GameObject)GameObject.Find("DiceLabel");
        var rand = new System.Random();
        var nextDiceNum = rand.Next(0, 6);
        dl.GetComponent<Text>().text = nextDiceNum.ToString();

        var areas = GameObject.Find("Areas");
        var children = areas.GetComponentsInChildren<Transform>();

        currentNo += Math.Min(13, nextDiceNum);
        var nextSum = currentNo;
        var target = children.First((child) => {
            var area = child.GetComponent<Area>();
            if (area != null) {
                return area.No == nextSum;
            } else {
                return false;
            }
        });
        // var length = children.Length;
        // Debug.Log(target.GetComponent<Area>());
        var ps = target.GetComponent<Transform>();
        var nextX = ps.position.x;
        this.nextPos = nextX;
        
        posY.y -= 1.2f;
        tf.position = posY;
        Debug.Log("nextPos" + nextPos);

        // var player = GameObject.Find("Player");
        // var tf = player.GetComponent<Transform>();
        // var pos = tf.position;
        // pos.x = nextX;
        // tf.position = pos;
    }
}
