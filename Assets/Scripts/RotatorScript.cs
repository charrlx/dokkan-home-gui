using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorScript : MonoBehaviour
{
    // Start is called before the first frame update
    float mPrevPosX = 0;
    float mPosDelta = 0;
    float rotation = 0;

    [Header("Character Art")]
    [SerializeField] GameObject vegito;
    [SerializeField] GameObject jiren;
    [SerializeField] GameObject rose;
    [SerializeField] GameObject broly;
    [SerializeField] GameObject ssb;
    [SerializeField] GameObject goku;
    
    [Header("LR Icons")]
    [SerializeField] GameObject one;
    [SerializeField] GameObject two;
    [SerializeField] GameObject three;
    [SerializeField] GameObject four;
    [SerializeField] GameObject five;
    [SerializeField] GameObject six;

    //[SerializeField] ParticleSystem clickpoint;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            mPosDelta = Input.mousePosition.x - mPrevPosX;
            rotation = mPosDelta / -10;
            transform.Rotate(0, 0, rotation);
            //Tried to implement cursor click feedback
           /* Vector3 cursor = Input.mousePosition;
            ParticleSystem LastClick = Instantiate(clickpoint, cursor, Quaternion.identity);
            Destroy(LastClick, 1f);*/
        }

        mPrevPosX = Input.mousePosition.x;

    }

    private void LateUpdate()
    {
        if (transform.rotation.eulerAngles.z >= 330 || transform.rotation.eulerAngles.z <= 30)
        {
            //LR Headings
            six.SetActive(false);
            two.SetActive(false);
            one.SetActive(true);
            //Characters
            goku.SetActive(false);
            jiren.SetActive(false);
            vegito.SetActive(true);
        }

        if (transform.rotation.eulerAngles.z >= 30 && transform.rotation.eulerAngles.z <= 90)
        {
            //LR Headings
            one.SetActive(false);
            three.SetActive(false);
            two.SetActive(true);
            //Characters
            vegito.SetActive(false);
            rose.SetActive(false);
            jiren.SetActive(true);
        }

        if (transform.rotation.eulerAngles.z >= 90 && transform.rotation.eulerAngles.z <= 150)
        {
            //LR Headings
            two.SetActive(false);
            four.SetActive(false);
            three.SetActive(true);
            //Characters
            jiren.SetActive(false);
            broly.SetActive(false);
            rose.SetActive(true);
        }
        
        if (transform.rotation.eulerAngles.z >= 150 && transform.rotation.eulerAngles.z <= 210)
        {
            //LR Headings
            three.SetActive(false);
            five.SetActive(false);
            four.SetActive(true);
            //Characters
            rose.SetActive(false);
            ssb.SetActive(false);
            broly.SetActive(true);
        }

        if (transform.rotation.eulerAngles.z >= 210 && transform.rotation.eulerAngles.z <= 270)
        {
            //LR Headings
            four.SetActive(false);
            six.SetActive(false);
            five.SetActive(true);
            //Characters
            broly.SetActive(false);
            goku.SetActive(false);
            ssb.SetActive(true);
        }

        if (transform.rotation.eulerAngles.z >= 270 && transform.rotation.eulerAngles.z <= 330)
        {
            //LR Headings
            five.SetActive(false);
            one.SetActive(false);
            six.SetActive(true);
            //Characters
            ssb.SetActive(false);
            vegito.SetActive(false);
            goku.SetActive(true);
        }
    }
}
