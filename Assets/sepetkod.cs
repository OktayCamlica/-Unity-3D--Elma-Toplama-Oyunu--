using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sepetkod : MonoBehaviour
{
    public float hız;
    int skor = 0;
    public TextMeshProUGUI skor_txt;

  private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="elma")
        {
            skor += 10;
            //   Debug.Log(skor.ToString());
            skor_txt.text = skor.ToString();
            Destroy(collision.gameObject);
        }
    } 

    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(hız * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hız * Time.deltaTime, 0, 0);
        }

    }
}
