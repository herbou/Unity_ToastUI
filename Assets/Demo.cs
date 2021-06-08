using UnityEngine ;
using EasyUI.Toast ;
using UnityEngine.UI ;

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

   public void ShowMessageTop () {
      Toast.Show ("Top Toast", 3f, ToastColor.Magenta, ToastPosition.Top) ;
   }

   public void ShowMessageMiddle () {
      Toast.Show ("<b>Middle</b> Toast", 3f, ToastColor.Blue, ToastPosition.Middle) ;
   }

   public void DismissToast () {
      Toast.Dismiss () ;
   }
}
