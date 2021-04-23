using UnityEngine ;
using EasyUI.Toast ;

public class Demo : MonoBehaviour {

   public void ShowMessage1 () {
      Toast.Show ("Hello GameDevs") ;
   }

   public void ShowMessage2 () {
      Toast.Show ("Hello GameDev, How are you?", 3f, ToastColor.Green) ;
   }

   public void ShowMessage3 () {
      Toast.Show ("This is another toast message, just ignore it :D", 4f, new Color (1f, .4f, 0f)) ;
   }
}
