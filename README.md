# browserData2D

### Unity project with javascript handlers in the generated index.html file that will forward javascript events to the unity runtime.
- Color change can also be invoked by pressing r and g keys.
- The buttons will change a circle's color when clicked.
- The Javascript Click event calls a function that uses the unityInstance.SendMessage method to call a C# internal public function called 
JavascriptHook.

### Files
- JavscriptHook.cs contains the methods that change the color property whether called by the javscript messages or the internal keypress events handled by Unity, showing that a unified approach can be used to handle both browser and internal functions.

- A webGL template "custom" contains the necessary modifications to index.html to build a POC for bidirectional browser/Unity communication with Javscript in a browser. It is suggested that any changes intended for persistence in the index.html file in Public be saved in a copy of the template to prevent unintentionally over-writing it when publishing.

### Note
* Unity changes the default built-in template periodically: a comparison and re-sync with the custom template is recommended before any release software is published using it.*