using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetStarInfo : MonoBehaviour
{
    public string starName { get; set; }

    public GetStarInfo(string name)
    {
        starName = name;
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        //checks if you are looking at a star
        if (Physics.Raycast(transform.position, transform.forward, out var hit, Mathf.Infinity))
        {
            var obj = hit.collider.gameObject;
            if (obj.GetComponent<NamedStar>() != null)
            {
                NamedStar star = obj.GetComponent<NamedStar>();
                starName = star.Data.Name;
                Debug.Log($"looking at {starName}", this);
            }
        }
    }
}
