using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputUI : MonoBehaviour
{
private string nameInput;
private string ageInput;

  public void ReadNameInput(string s)
  {
    nameInput = s;
    Debug.Log(nameInput);
  }
    public void ReadAgeInput(string s)
  {
    ageInput = s;
    Debug.Log(ageInput);
  }
}
