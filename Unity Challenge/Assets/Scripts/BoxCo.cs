using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BoxCo : MonoBehaviour {
    public Text text;
    public AudioSource collectsound;
    public Text countText,scoreText,resulttext;
    private float count,score;
    float timeLeft = 60.0f;
    public Text timetext;




        void Start ()
    {
         collectsound.Play(0);
         count = 0;
         score = 0;
         CountText();
      
    }

	    void Update ()
     { 
         timeLeft -= Time.deltaTime;
           timetext.text = "Time Left:" + Mathf.Round(timeLeft);
           if (timeLeft < 0)
           {
             SceneManager.LoadScene("Scenethree");
         }
     }


    void OnCollisionStay(Collision col)
    {
       
            if (col.collider.tag == "Red")
            {
                Destroy(col.gameObject);
                text.text = "You Hit Red";
                collectsound.Play(1);
                count = count + 1;
                score = score + 15;
                CountText();

            }
            if (col.collider.tag == "Blue")
            {
                 Destroy(col.gameObject);
                 text.text = "You Hit Blue";
                 collectsound.Play(1);
                 count = count + 1;
                 score = score + 20;
                 CountText();
        }   
            
    }
    void CountText()
    {
        countText.text = "Count: " + count.ToString();
        scoreText.text = "Score: " + score.ToString();
        if (count == 10) 
        {
            Invoke("ChangeLevel", 4.0f);
            score = score + timeLeft;
            score = Mathf.Round(score * 1f) / 1f;
            resulttext.text = "Your Total Score:" + score.ToString();
        }

       



    }
    void ChangeLevel()
    {
        SceneManager.LoadScene("Scenethree");
    }

}
