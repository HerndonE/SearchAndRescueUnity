using UnityEngine;
using Random = UnityEngine.Random;

public class CameraPainter : MonoBehaviour{
    public Camera cam;
    private Camera pilotCamera;
    [Space]
    public bool mouseSingleClick;
    [Space]
    public bool randomTorF;
    [Space]
    public Color paintColor;

    void Start() {


        pilotCamera = GameObject.Find("pilotCamera").GetComponent<Camera>();

        pilotCamera.enabled = false;

        cam.GetComponent<Camera>().enabled = true;
        

        if (randomTorF == true)
        {
            paintColor = new Color((float)Random.Range(50, 200) / 255.0f, (float)Random.Range(50, 200) / 255.0f, (float)Random.Range(50, 200) / 255.0f);
        }
    }


    
    public float radius = 1;
    public float strength = 1;
    public float hardness = 1;

    void Update(){

      /*  bool click;
        click = mouseSingleClick ? Input.GetMouseButtonDown(0) : Input.GetMouseButton(0);*/

        //if (click){
            //Vector3 position = cam.position;//Input.mousePosition;
            Ray ray = new Ray(cam.transform.position, cam.transform.forward);//cam.ScreenPointToRay(position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100.0f)){
                Debug.DrawRay(ray.origin, hit.point - ray.origin, Color.red);
                transform.position = new Vector3(hit.point.x, 30.0f, hit.point.z);
                //transform.position = new Vector3(hit.point.x, 30.0f, hit.point.z);
                Paintable p = hit.collider.GetComponent<Paintable>();
                if(p != null){
                    PaintManager.instance.paint(p, hit.point, radius, hardness, strength, paintColor);
                }
            }
        //}

    }

}
