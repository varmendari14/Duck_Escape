using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatTracker : MonoBehaviour
{
    public int ducksLeft;
    public bool didLose = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void setDucks(int numDucks)
    {
        ducksLeft = numDucks;
    }

    public void decrementDucks()
    {
        ducksLeft--;
        if (ducksLeft < 0)
        {
            ducksLeft = 0;
        }
    }

    public void setDidLose(bool lost)
    {
        didLose = lost;
    }
}
