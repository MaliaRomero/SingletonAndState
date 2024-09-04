using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Chapter.Singleton
{
    public class GameManager : Singleton<GameManager>
    {
        private DateTime _sessionStartTime;
        private DateTime _sessionEndTime;

        void Start()
        {
            //Todo- Load player save, redirect player, call backend
            _sessionStartTime = DateTime.Now;
            Debug.Log("Game session start @: " + DateTime.Now);
        }

        void OnApplicationQuit()
        {
            _sessionEndTime = DateTime.Now;

            TimeSpan timeDifference =
                _sessionEndTime.Subtract(_sessionStartTime);

            Debug.Log(
                "Game session ended @: " + DateTime.Now);
            Debug.Log(
                "Game session lasted: " + timeDifference);
        }
        /*
        void OnGUI()
        {
            if (GUILayout.Button("Next Scene"))
            {
                SceneManager.LoadScene(
                    SceneManager.GetActiveScene().buildIndex + 1);
            }
        }*/
        void OnGUI()
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            // Don't display button if on last scene
            if (currentSceneIndex != 3)
            {
                if (GUILayout.Button("Next Scene"))
                {
                    SceneManager.LoadScene(
                        SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
        }
    }
}