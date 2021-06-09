# Toast UI for your Game messages
A powerful,Customizable, and esay-to-use Toast UI for Unity

<img src="https://www.mediafire.com/convkey/6af4/br7apcoostvua8mzg.jpg" alt="Toast ui" height="150" />

### Video tutorial : https://youtu.be/405lXPINdx0
<br><br>
## ■ Supporting Platforms :
- All platforms (Standalone Builds, Android, iOS, WebGl, and more..)
<br><br>
## ■ How to use?  :
### 1- Import ```EasyUI_Toast``` package.
### 3- Add ```EasyUI.Toast``` namespace in your script :
```c#
using EasyUI.Toast ;
```
### 4- Now Simply write ```Toast.Show()```:
```c#
// Simple :
Toast.Show ("Hi") ;

// Duration & Color :
Toast.Show ("Hi", 3f, ToastColor.Green) ;

// Custom Color :
Toast.Show ("Hi", 4f, new Color (1f, .4f, 0f)) ;

// Position :
Toast.Show ("Top Toast", 3f, ToastPosition.Top) ;
```
⚠️ NOTE! : No need to add any prefab to the scene

## ■ Change text styling :
```c#
Toast.Show ("Hello, <color=yellow>This is a yellow text<color>", 3f);
```
<img src="https://www.mediafire.com/convkey/336a/c3pmudunpkuhbvb7g.jpg" alt="Toast ui" height="150" />
for more supported style tags : <a href="https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/StyledText.html">Text supported styles</a>

## ■ Dismiss toast :
```c#
Toast.Dismiss();
```

## ■ Other Show(..) versions :
```c#
public static void Show (string text) {...}

public static void Show (string text, float duration) {...}

public static void Show (string text, float duration, ToastPosition position) {...}

public static void Show (string text, ToastColor color) {...}

public static void Show (string text, ToastColor color, ToastPosition position) {...}

public static void Show (string text, Color color) {...}

public static void Show (string text, Color color, ToastPosition position) {...}

public static void Show (string text, float duration, ToastColor color) {...}

public static void Show (string text, float duration, ToastColor color, ToastPosition position) {...}

public static void Show (string text, float duration, Color color) {...}

public static void Show (string text, float duration, Color color, ToastPosition position) {...}
```



<br><br>
<br><br>
## ❤️ Donate

<a href="https://paypal.me/hamzaherbou" title="https://paypal.me/hamzaherbou" target="_blank"><img align="left" height="50" src="https://www.mediafire.com/convkey/72dc/iz78ys7vtfsl957zg.jpg" alt="Paypal"></a>

<a href="https://www.buymeacoffee.com/hamzaherbou" title="https://www.buymeacoffee.com/hamzaherbou" target="_blank"><img align="left" height="50" src="https://www.mediafire.com/convkey/66bc/dg3xdk96km1pt7gzg.jpg" alt="BuyMeACoffee"></a>

<a href="https://patreon.com/herbou" title="https://patreon.com/herbou" target="_blank"><img align="left" height="50" src="https://www.mediafire.com/convkey/57b1/0h171bqmdesoljczg.jpg" alt="Patreon"></a>
