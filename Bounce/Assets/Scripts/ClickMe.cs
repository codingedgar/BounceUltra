using UnityEngine;
using System.Collections;

public class ClickMe : MonoBehaviour {

	void OnMouseDown()
    {
        this.gameObject.SetActive(false);
    }
}
