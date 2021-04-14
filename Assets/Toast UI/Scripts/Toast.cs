using UnityEngine ;

namespace EasyUI.Toast {

   public static class Toast {

      private static ToastUI toastUI ;

      static Toast () {
         if (object.ReferenceEquals (toastUI, null)) {
            GameObject instance = MonoBehaviour.Instantiate (Resources.Load<GameObject> ("ToastUI")) ;
            MonoBehaviour.DontDestroyOnLoad (instance) ;
            toastUI = instance.GetComponent <ToastUI> () ;
         }
      }

      public static void Show (string text) {
         toastUI.Init (text, 2F, ToastColor.Black) ;
      }

      public static void Show (string text, float duration) {
         toastUI.Init (text, duration, ToastColor.Black) ;
      }

      public static void Show (string text, ToastColor color) {
         toastUI.Init (text, 2F, color) ;
      }

      public static void Show (string text, Color color) {
         toastUI.Init (text, 2F, color) ;
      }

      public static void Show (string text, float duration, ToastColor color) {
         toastUI.Init (text, duration, color) ;
      }

      public static void Show (string text, float duration, Color color) {
         toastUI.Init (text, duration, color) ;
      }

   }

}
