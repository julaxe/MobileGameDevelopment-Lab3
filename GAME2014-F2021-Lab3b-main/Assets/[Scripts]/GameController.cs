using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Rect screen;
    public Rect safeArea;

    public Button backButton;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rect screenRect = new Rect(0.0f, 0.0f, Screen.width, Screen.height);
        screen = screenRect;
        safeArea = Screen.safeArea;


        CheckOrientation();
    }

    private static void CheckOrientation()
    {
        //Debug.Log(Screen.orientation);

        // example of how we can adjust code based on orientation changes
        switch (Screen.orientation)
        {
            case ScreenOrientation.LandscapeLeft:
                break;
            case ScreenOrientation.LandscapeRight:
                break;
            case ScreenOrientation.Portrait:
                break;
            default:
                break;
        }
    }
}
