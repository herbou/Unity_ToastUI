using UnityEngine ;
using EasyUI.Toast ;
using UnityEngine.UI ;

public class Demo : MonoBehaviour {
   [TextArea (5, 20)] public string text ;

   public void ShowMessage1 () {
      Toast.Show (text) ;
   }

   public void ShowMessage2 () {
      Toast.Show ("Hello GameDev, How are you?", 3f, ToastColor.Green) ;
   }

   public void ShowMessage3 () {
      Toast.Show ("This is another toast message, just ignore it :D", 4f, new Color (1f, .4f, 0f)) ;
   }

   public void ShowMessageTopLeft () {
      Toast.Show ("Top Left Toast", 3f, ToastColor.Magenta, ToastPosition.TopLeft) ;
   }

   public void ShowMessageMiddle () {
      Toast.Show ("<b>Middle</b> Toast", 3f, ToastColor.Blue, ToastPosition.MiddleCenter) ;
   }

   public void DismissToast () {
      Toast.Dismiss () ;
   }
}
