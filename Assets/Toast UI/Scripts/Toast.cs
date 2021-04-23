using UnityEngine ;

/* -------------------------------
   Created by : Hamza Herbou
   hamza95herbou@gmail.com
---------------------------------- */

namespace EasyUI.Toast {

   public static class Toast {
      public static bool isLoaded = false ;

      private static ToastUI toastUI ;

      private static void Prepare () {
         if (!isLoaded) {
            GameObject instance = MonoBehaviour.Instantiate (Resources.Load<GameObject> ("ToastUI")) ;
            instance.name = "[ TOAST UI ]" ;
            toastUI = instance.GetComponent <ToastUI> () ;
            isLoaded = true ;
         }
      }

      public static void Show (string text) {
         Prepare () ;
         toastUI.Init (text, 2F, ToastColor.Black) ;
      }

      public static void Show (string text, float duration) {
         Prepare () ;
         toastUI.Init (text, duration, ToastColor.Black) ;
      }

      public static void Show (string text, ToastColor color) {
         Prepare () ;
         toastUI.Init (text, 2F, color) ;
      }

      public static void Show (string text, Color color) {
         Prepare () ;
         toastUI.Init (text, 2F, color) ;
      }

      public static void Show (string text, float duration, ToastColor color) {
         Prepare () ;
         toastUI.Init (text, duration, color) ;
      }

      public static void Show (string text, float duration, Color color) {
         Prepare () ;
         toastUI.Init (text, duration, color) ;
      }

   }

}
