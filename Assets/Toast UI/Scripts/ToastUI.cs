using UnityEngine ;
using System.Collections ;
using UnityEngine.UI ;

/* -------------------------------
   Created by : Hamza Herbou
   hamza95herbou@gmail.com
---------------------------------- */

namespace EasyUI.Toast {

   public enum ToastColor {
      Black,
      Red,
      Purple,
      Magenta,
      Blue,
      Green,
      Yellow,
      Orange
   }

   public class ToastUI : MonoBehaviour {
      [Header ("UI References :")]
      [SerializeField] private CanvasGroup uiCcanvasGroup ;
      [SerializeField] private Image uiImage ;
      [SerializeField] private Text uiText ;

      [Header ("Toast Colors :")]
      [SerializeField] private Color[] colors ;

      [Header ("Toast Fade In/Out Duration :")]
      [Range (.1f, .8f)]
      [SerializeField] private float fadeDuration = .3f ;


      void Awake () {
         uiCcanvasGroup.alpha = 0f ;
      }

      public void Init (string text, float duration, ToastColor color) {
         Show (text, duration, colors [ (int)color ]) ;
      }

      public void Init (string text, float duration, Color color) {
         Show (text, duration, color) ;
      }

      private void Show (string text, float duration, Color color) {
         uiText.text = (text.Length > 55) ? text.Substring (0, 55) + "..." : text ;
         uiImage.color = color ;

         StopAllCoroutines () ;
         StartCoroutine (FadeInOut (duration, fadeDuration)) ;
      }

      private IEnumerator FadeInOut (float toastDuration, float fadeDuration) {
         // Anim start
         yield return Fade (uiCcanvasGroup, 0f, 1f, fadeDuration) ;
         yield return new WaitForSeconds (toastDuration) ;
         yield return Fade (uiCcanvasGroup, 1f, 0f, fadeDuration) ;
         // Anim end
      }

      private IEnumerator Fade (CanvasGroup cGroup, float startAlpha, float endAlpha, float fadeDuration) {
         float startTime = Time.time ;
         float alpha = startAlpha ;

         if (fadeDuration > 0f) {
            //Anim start
            while (alpha != endAlpha) {
               alpha = Mathf.Lerp (startAlpha, endAlpha, (Time.time - startTime) / fadeDuration) ;
               cGroup.alpha = alpha ;

               yield return null ;
            }
         }

         cGroup.alpha = endAlpha ;
      }

      private void OnDestroy () {
         Toast.isLoaded = false ;
      }
   }

}
