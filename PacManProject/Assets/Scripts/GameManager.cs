using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // to call the game manager form any script
    public static GameManager instance = null;

    //the object with all the dots
    [SerializeField] GameObject dotReference;
    // total of dots in the map
    int dotCount;

    private void Awake()
    {
        // force the singleton pattern of the gameMAnager

        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

    // before anything count the dots on the map
    dotCount = dotReference.GetComponentsInChildren<DotBehaviour>().Length;    
    }
    // update how much dots are at the map
    public void AteDot()
    {
        dotCount--;
        //When all the dots are gone re load the scene 
        if (dotCount<=0)
        {

            SceneManager.LoadScene(0);
        }
    }
}
