using UnityEngine ;
using System.Collections ;
using UnityEngine.UI ;
using EasyUI.Toast ;

/* -------------------------------
   Created by : Hamza Herbou
   hamza95herbou@gmail.com
---------------------------------- */

namespace EasyUI.Helpers {

   public class ToastUI : MonoBehaviour {
      [Header ("UI References :")]
      [SerializeField] private CanvasGroup uiCanvasGroup ;
      [SerializeField] private RectTransform uiRectTransform ;
      [SerializeField] private Image uiImage ;
      [SerializeField] private Text uiText ;

      [Header ("Toast Colors :")]
      [SerializeField] private Color[] colors ;

      [Header ("Toast Fade In/Out Duration :")]
      [Range (.1f, .8f)]
      [SerializeField] private float fadeDuration = .3f ;


      void Awake () {
         uiCanvasGroup.alpha = 0f ;
      }

      public void Init (string text, float duration, ToastColor color, ToastPosition position) {
         Show (text, duration, colors [ (int)color ], position) ;
      }

      public void Init (string text, float duration, Color color, ToastPosition position) {
         Show (text, duration, color, position) ;
      }



      private void Show (string text, float duration, Color color, ToastPosition position) {
         uiText.text = (text.Length > 55) ? text.Substring (0, 55) + "..." : text ;
         uiImage.color = color ;


         Vector2 anchoredPosition, anchorMin, anchorMax ;
         switch (position) {
            case ToastPosition.Top:
               uiRectTransform.anchoredPosition = new Vector2 (0, -42f) ;
               uiRectTransform.anchorMin = new Vector2 (0.5f, 1) ;
               uiRectTransform.anchorMax = new Vector2 (0.5f, 1) ;
               break ;
            case ToastPosition.Middle:
               uiRectTransform.anchoredPosition = new Vector2 (0, 0) ;
               uiRectTransform.anchorMin = new Vector2 (0.5f, 0.5f) ;
               uiRectTransform.anchorMax = new Vector2 (0.5f, 0.5f) ;
               break ;
            case ToastPosition.Bottom:
               uiRectTransform.anchoredPosition = new Vector2 (0, 42f) ;
               uiRectTransform.anchorMin = new Vector2 (0.5f, 0) ;
               uiRectTransform.anchorMax = new Vector2 (0.5f, 0) ;
               break ;
         }

         StopAllCoroutines () ;
         StartCoroutine (FadeInOut (duration, fadeDuration)) ;
      }

      private IEnumerator FadeInOut (float toastDuration, float fadeDuration) {
         // Anim start
         yield return Fade (uiCanvasGroup, 0f, 1f, fadeDuration) ;
         yield return new WaitForSeconds (toastDuration) ;
         yield return Fade (uiCanvasGroup, 1f, 0f, fadeDuration) ;
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

      public void Dismiss () {
         StopAllCoroutines () ;
         uiCanvasGroup.alpha = 0f ;
      }

      private void OnDestroy () {
         EasyUI.Toast.Toast.isLoaded = false ;
      }
   }

}
