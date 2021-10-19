using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool won = false;
    public float water= 10f;
    // Start is called before the first frame update
    void Start()
    {
        startTime= Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (won)
            return;
        float t= Time.time - startTime;
        string minutes= ((int) t/60).ToString();
        string seconds= (t % 60).ToString("f0");
        timerText.text = minutes + ':'+ seconds;

        void OnCollisionEnter2D(Collision col)
  {
      Debug.Log("OnCollisionEnter2D is called");
      if (col.gameObject.tag == "Water")
      {
          startTime += water;
      }
  }

    
    
    
    }
    public void Win(){
        won= true;
        timerText.color=Color.yellow;
    }
}
