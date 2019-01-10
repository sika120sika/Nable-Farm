using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public Vector3 a,b;
    public float tmp = 0;
    bool moveFlg = false;
    public float MS =100;
    void Update () {
         transform.Translate(Input.GetAxis("Horizontal")*1f, Input.GetAxis("Vertical")*1f, 0);
        if (Input.GetMouseButton(0))
        {
            a = transform.position;
            b = Input.mousePosition;
            b = Camera.main.ScreenToWorldPoint(b);
            b = new Vector3(b.x,b.y,0);
            tmp = 0;
            moveFlg = true;
        }

        if (moveFlg)
        {
            Vector3 tmpVec = b - a;
            tmpVec = tmpVec.normalized;
            transform.position += tmpVec * 0.1f;
            tmpVec = transform.position - b;
            if (tmpVec.magnitude<1)
            {
                moveFlg = false;
            }
        }
        if (transform.position.y < -100)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("B");
        }
	}
}
