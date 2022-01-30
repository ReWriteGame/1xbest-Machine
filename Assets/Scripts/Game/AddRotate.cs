using UnityEngine;

[RequireComponent(typeof(Roulette))]
public class AddRotate : MonoBehaviour
{
   [SerializeField] private int rotate = 1;
   
   [SerializeField] private bool axisX = false;
   [SerializeField] private bool axisY = false;
   [SerializeField] private bool axisZ = false;

   private float rotateOneCell = 1;
   private Roulette roulette;
   
   private void Start()
   {
      roulette = GetComponent<Roulette>();
      GetRotateOneCell();
   }

   
   
   private void GetRotateOneCell()
   {
      rotateOneCell = 360 / rotate;
   }

   private float AddRotateAxis(float rotate)
   {
      float angle = rotate % rotateOneCell;
      return (rotate += (Mathf.Abs(angle) / 2 > rotateOneCell / 2) ? angle / 2 : -angle / 2); 
   }

   private float Test(float rotate)
   {
      float rotation = rotate <= 180f ? rotate : rotate -360f;
      
      
      print(rotation);
      //print(rotate);
      //print(AddRotateAxis(rotation));
      return rotation + AddRotateAxis(rotation);
      
   }

   public void Test2()
   {
      Test(transform.eulerAngles.x);
   }
   
   /*void Update() {
      float angle = Mathf.LerpAngle(minAngle, maxAngle, Time.time);
      transform.eulerAngles = new Vector3(0, angle, 0);
   }*/
   void Update()
   {
      float Rotation;
      if(transform.eulerAngles.x <= 180f)
      {
         Rotation = transform.eulerAngles.x;
      }
      else
      {
         Rotation = transform.eulerAngles.x - 360f;
      }
      print(Rotation);
   }
}
