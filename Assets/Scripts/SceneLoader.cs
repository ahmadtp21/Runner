using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	public void LoadScene(int sceneOrder)
    {
        SceneManager.LoadScene(sceneOrder);
        Data.score = 0;
        Data.isGameOver = false;
    }
}
