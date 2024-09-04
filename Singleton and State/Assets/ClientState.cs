//used more than book to fix overlapping buttons
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Chapter.State
{
    public class ClientState : MonoBehaviour
    {
        private BikeController _bikeController;

        void Start()
        {
            _bikeController =
                (BikeController)
                FindObjectOfType(typeof(BikeController));
        }

        void OnGUI()
        {
            if (GUILayout.Button("Next Scene Unavailable"))
            {
                SceneManager.LoadScene(
                    SceneManager.GetActiveScene().buildIndex + 1);
            }

            if (GUILayout.Button("Start Bike"))
                _bikeController.StartBike();

            if (GUILayout.Button("Stop Bike"))
                _bikeController.StopBike();

            if (GUILayout.Button("Turn Left"))
                _bikeController.Turn(Direction.Left);

            if (GUILayout.Button("Turn Right"))
                _bikeController.Turn(Direction.Right);
        }
    }
}