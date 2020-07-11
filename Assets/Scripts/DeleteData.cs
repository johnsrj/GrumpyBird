using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class DeleteData : MonoBehaviour
{
    private Button button { get { return GetComponent<Button>(); } }
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(() => DelData());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DelData()
    {
        PlayerPrefs.DeleteAll();
    }
}
