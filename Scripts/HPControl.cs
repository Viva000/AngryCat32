using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HPControl : MonoBehaviour
{
  public Slider hpbar;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetUpHP(int value)
    {
      hpbar.maxValue = value;
      hpbar.value = value;
    }
    public void UpdateHP(int value)
    {
      hpbar.value = value;
    }
}
