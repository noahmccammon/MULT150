using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GoalScript blue, green, red, orange;
    private bool isGameOver = true;
    private float elapsedTime = 0;
    private bool isRunning = true;
    void Update()
    {
        //If all four goals are solved then the game is over
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;
        if (isRunning)
        {
            elapsedTime = elapsedTime + Time.deltaTime;
        }
        if (isGameOver)
            isRunning = false;
    }
    void OnGUI()
    {
        if (isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, "Good Job!");
        }
        // If the player finished the game, show the final time
        if (isGameOver)
        {
            GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height - 115, 130, 40), "Your Time Was");
            GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height - 100, 20, 30), ((int)elapsedTime).ToString());
        }
        else if (isRunning)
        {
            // If the game is running, show the current time
            GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height - 115, 130, 40), "Your Time Is");
            GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height - 100, 20, 30), ((int)elapsedTime).ToString());
        }
    }
    private void StartGame()
    {
        elapsedTime = 0;
        isRunning = true;
        isGameOver = false;
    }
}
