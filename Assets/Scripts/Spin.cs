using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float z = 17f;

    

    // Start is called before the first frame update
    void Start()
    {
       
    }
    //Set Parent Position
    private Vector3 target = new Vector3(5.4f, -1.5f, -50.5f);

    // Update is called once per frame
    void Update()
    {
        //Parent Object 
        GameObject originalGameObject = GameObject.Find("Sun");
       

        //Mercury Object
        GameObject child = originalGameObject.transform.GetChild(0).gameObject;
        child.transform.RotateAround(target, Vector3.up, 11.4f * Time.deltaTime);

        // Earth Object
        GameObject child2 = originalGameObject.transform.GetChild(1).gameObject;
        child2.transform.RotateAround(target, Vector3.up, 2.7f * Time.deltaTime);
    



        // Jupiter Object
        GameObject child3 = originalGameObject.transform.GetChild(2).gameObject;
        child3.transform.RotateAround(target, Vector3.up, 0.2f * Time.deltaTime);
        child3.transform.Rotate(new Vector3(0, 2.424f, 0)); //Self Spining

        // Saturn Object
        GameObject child4 = originalGameObject.transform.GetChild(3).gameObject;
        child4.transform.RotateAround(target, Vector3.up, 0.1f * Time.deltaTime);
        child4.transform.Rotate(new Vector3(0, 2.243f, 0)); //Self Spining


        // Uranus Object
        GameObject child5 = originalGameObject.transform.GetChild(4).gameObject;
        child5.transform.RotateAround(target, Vector3.up, 0.03f * Time.deltaTime);
        child5.transform.Rotate(new Vector3(0, -1.395f, 0)); //Self Spining

        // Nept Object 
        GameObject child6 = originalGameObject.transform.GetChild(5).gameObject;
        child6.transform.RotateAround(target, Vector3.up, 0.02f* Time.deltaTime);
        child6.transform.Rotate(new Vector3(0, 1.491f, 0)); //Self Spining

        // Pluto Object
        GameObject child7 = originalGameObject.transform.GetChild(6).gameObject;
        child7.transform.RotateAround(target, Vector3.up, 0.01f  * Time.deltaTime);
        child7.transform.Rotate(new Vector3(0, 0.157f, 0)); //Self Spining

        // Venus Object
        GameObject child8 = originalGameObject.transform.GetChild(7).gameObject;
        child8.transform.RotateAround(target, Vector3.up, 4.5f * Time.deltaTime);
        child8.transform.Rotate(new Vector3(0, -4f, 0)); //Self Spining

        // Mars Object
        GameObject child9 = originalGameObject.transform.GetChild(8).gameObject;
        child9.transform.RotateAround(target, Vector3.up, 1.5f * Time.deltaTime);
        child9.transform.Rotate(new Vector3(0, 0.976f, 0)); //Self Spining


    }

 

    

   

}
