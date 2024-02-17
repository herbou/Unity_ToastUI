# Toast UI for your Game messages
A powerful,Customizable, and esay-to-use Toast UI for Unity

<img src="https://www.mediafire.com/convkey/6af4/br7apcoostvua8mzg.jpg" alt="Toast ui" height="80" />

### Video tutorial : https://youtu.be/405lXPINdx0
<br><br>
## ■ Supporting Platforms :
- All platforms (Standalone Builds, Android, iOS, WebGl, and more..)
<br><br>
## ■ How to use?  :
### 1- Import **Toast UI** folder to your project inside Assets.
⚠️ NOTE! : No need to add any prefab to the scene
### 3- Add **EasyUI.Toast** namespace in your script :
```c#
using EasyUI.Toast ;
```
<br>

### 4- Now Simply write ```Toast.Show()```:
```c#
// Simple :
Toast.Show ("Hello Devs") ;

// With duration :
Toast.Show ("Hello Devs", 3f) ;
```
<br>

## ■ Change colors :
```c#
// Built-in Colors  ( Black, Red, Purple, Magenta, Blue, Green, Yellow, Orange ) :
Toast.Show ("Hello Devs", 3f, ToastColor.Green) ;

// Custom Colors :
Toast.Show ("Hello Devs", 4f, new Color (1f, .4f, 0f)) ;
// or Toast.Show ("Hello Devs", 4f, Color.blue);
```
<br>

## ■ Change position :
```c#
// Positions ( TopLeft, TopCenter, TopRight, MiddleLeft, MiddleCenter, MiddleRight, BottomLeft, BottomCenter, BottomRight ) :
Toast.Show ("Top-Center Toast", 3f, ToastPosition.TopCenter) ;
```
<br>

## ■ Change text styling :
```c#
Toast.Show ("Hello, <color=yellow>This is a yellow text</color>", 3f);
```
<img src="https://www.mediafire.com/convkey/336a/c3pmudunpkuhbvb7g.jpg" alt="Toast ui" height="80" />
for more supported style tags : <a href="https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/StyledText.html">Text supported styles</a>

<br><br>

## ■ Dismiss (hide) toast :
```c#
Toast.Dismiss();
```
<br>

## ■ Other Show(..) versions :
```c#
Toast.Show (string text);

Toast.Show (string text, float duration);

Toast.Show (string text, float duration, ToastPosition position);

Toast.Show (string text, ToastColor color);

Toast.Show (string text, ToastColor color, ToastPosition position);

Toast.Show (string text, Color color);

Toast.Show (string text, Color color, ToastPosition position);

Toast.Show (string text, float duration, ToastColor color);

Toast.Show (string text, float duration, ToastColor color, ToastPosition position);

Toast.Show (string text, float duration, Color color);

Toast.Show (string text, float duration, Color color, ToastPosition position);
```



<br><br>
<br><br>
## ❤️ Donate

<a href="https://paypal.me/hamzaherbou" title="https://paypal.me/hamzaherbou" target="_blank"><img align="left" height="50" src="https://www.mediafire.com/convkey/72dc/iz78ys7vtfsl957zg.jpg" alt="Paypal"></a>
