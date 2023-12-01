using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class easteregg : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenScene()
    {
        SceneManager.LoadScene("Easter Egg");
    }
}
