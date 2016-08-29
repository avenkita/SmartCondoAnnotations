using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic; //this is where the List<T>() class comes from
using System.Xml;

public class ReadAnnotationName : MonoBehaviour
{

    //creates a list that will enable code's access to AnnotationInfo.xml file
    public static List<AnnotationsInfoObject> ListofAnnotations = new List<AnnotationsInfoObject>();

    [SerializeField]
    private Text annotation = null;

    public static void ReadAnnotationXML()
    {
        //Load data (text) from xml file
        //Allow code to access different nodes through tag names
        TextAsset textXML = (TextAsset)Resources.Load("AnnotationsInfo", typeof(TextAsset));
        XmlDocument xml = new XmlDocument();
        xml.LoadXml(textXML.text);
        XmlNodeList transformList = xml.GetElementsByTagName("Notes");

        //stores loaded data into list to be accessed later
        //cumulatively searches through sets of nodes, then nodes within nodes, etc.
        foreach (XmlNode transformInfo in transformList)
        {
            XmlNodeList transformcontent = transformInfo.ChildNodes;
            foreach (XmlNode transformItems in transformcontent)
            {
                XmlNodeList transformcontent2 = transformItems.ChildNodes;
                AnnotationsInfoObject w = new AnnotationsInfoObject();
                foreach (XmlNode transformItems2 in transformcontent2)
                {
                    if (transformItems2.Name == "Name") { w.Name = transformItems2.InnerText; }
                    if (transformItems2.Name == "HowtoUse") { w.HowtoUse = transformItems2.InnerText; }
                }
                ListofAnnotations.Add(w);

            }
        }
    }

    //call AnnotationInfoObject function to retrieve list's data
    public static List<AnnotationsInfoObject> getAnnotations()
    {
        ReadAnnotationXML();
        return ListofAnnotations;

    }

    //searches for name of object by accessing the node it is stored in within xml
    //instantiates text found
    //with every additional annotation, each annotation# and list element number must be increased by 1 from a point according to the XML
    //raycast returns 3D object's name during runtime
    void Update()
    {

        List<AnnotationsInfoObject> mylist = getAnnotations();

        string annotation1 = mylist[0].Name;
        string annotation2 = mylist[1].Name;
        string annotation3 = mylist[2].Name;
        string annotation4 = mylist[3].Name;
        string annotation5 = mylist[4].Name;
        string annotation6 = mylist[5].Name;
        string annotation7 = mylist[6].Name;
        string annotation8 = mylist[7].Name;
        string annotation9 = mylist[8].Name;
        string annotation10 = mylist[9].Name;
        string annotation11 = mylist[10].Name;
        string annotation12 = mylist[11].Name;
        string annotation13 = mylist[12].Name;
        string annotation14 = mylist[13].Name;
        string annotation15 = mylist[14].Name;
        string annotation16 = mylist[15].Name;
        string annotation17 = mylist[16].Name;
        string annotation18 = mylist[17].Name;
        string annotation19 = mylist[18].Name;
        string annotation20 = mylist[19].Name;
        string annotation21 = mylist[20].Name;
        string annotation22 = mylist[21].Name;

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction, (Color.cyan));


        if (Physics.Raycast(ray, out hit))
            {

                if (hit.collider.name == "pokrivalo")
                {
                    annotation.text = annotation1;
                }

                if (hit.collider.name == "TV") //this is the bedroom tv
                {
                    annotation.text = annotation2;
                }

                if(hit.collider.name == "Back Door")
                {
                    annotation.text = annotation3;
                }
                
                if(hit.collider.name == "Kitchen Island")
                {
                    annotation.text = annotation4;
                }

                if(hit.collider.name == "AutoPantry")
                {
                    annotation.text = annotation5;
                }

                if(hit.collider.name == "Kitchen Sink")
                {
                    annotation.text = annotation6;
                }

                if(hit.collider.name == "Toaster")
                {
                    annotation.text = annotation7;
                }

                if (hit.collider.name == "Component#2_001") //this is the dishwashwer; couldn't add box collider
                {
                    annotation.text = annotation8;
                }

                if (hit.collider.name == "Component#1_001") //this is the dishwashwer; couldn't add box collider
                {
                    annotation.text = annotation8;
                }

                if (hit.collider.name == "Kitchen Outlet")
                {
                    annotation.text = annotation9;
                }

                if(hit.collider.name == "Stove")
                {
                    annotation.text = annotation10;
                }

                if(hit.collider.name == "Range Hood")
                {
                    annotation.text = annotation11;
                }

                if(hit.collider.name == "Group_001") //this is the microwave; couldn't add box collider
                {
                    annotation.text = annotation12;
                }

                if(hit.collider.name == "Oven")
                {
                    annotation.text = annotation13;
                }

                if(hit.collider.name == "Fridge")
                {
                    annotation.text = annotation14;
                }

                if (hit.collider.name == "Plane03") //this is the bathtub; couldn't add box collider
                {
                    annotation.text = annotation15;
                }

                if (hit.collider.name == "Toilet")
                {
                    annotation.text = annotation16;
                }

                if (hit.collider.name == "SR74L") //this is the bathroom sink; couldn't add box collider
                {
                    annotation.text = annotation17;
                }

                if (hit.collider.name == "Soap Dispenser")
                {
                    annotation.text = annotation18;
                }

                if(hit.collider.name == "Bathroom Outlet")
                {
                    annotation.text = annotation19;
                }

                if(hit.collider.name == "Dining Table")
                {
                    annotation.text = annotation20;
                }

                if(hit.collider.name == "Front Door")
                {
                    annotation.text = annotation21;
                }

                if(hit.collider.name == "Floor")
                {
                    annotation.text = annotation22;
                }

            }

     }
 }

