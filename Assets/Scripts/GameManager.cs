using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void awake()
    {
        instance = this;
        Application.targetFrameRate = 120;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
