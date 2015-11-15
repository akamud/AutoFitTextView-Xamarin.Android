# AutoFitTextView-Xamarin.Android
![](https://raw.githubusercontent.com/akamud/AutoFitTextView-Xamarin.Android/master/art/Icon.png)  
Xamarin bindings for [android-autofittextview](https://github.com/grantland/android-autofittextview) by [@grantland](https://github.com/grantland)

A TextView that automatically resizes text to fit perfectly within its bounds.

## Installing
![](https://img.shields.io/nuget/v/AutoFitTextView-Xamarin.Android.svg?style=flat)  
[NuGet package](https://www.nuget.org/packages/AutoFitTextView-Xamarin.Android/) available:
```
PM> Install-Package AutoFitTextView-Xamarin.Android
```

## Using
You can use the defiend AutofitTextView widget:
```XML
<me.grantland.widget.AutofitTextView
    android:id="@+id/output_autofit"
    android:layout_width="match_parent"
    android:layout_height="wrap_content"
    android:text="@string/example"
    android:textSize="50sp"
    android:gravity="center"
    android:singleLine="true" />
```

You can also enable any component that has a TextView to act like a AutofitTextView using the `AutofitLayout`:
```XML
<me.grantland.widget.AutofitLayout
    android:layout_width="match_parent"
    android:layout_height="wrap_content">
    <Button
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        android:singleLine="true"
        android:text="This is a really long string that will be automatically resized to fit in a single line"/>
</me.grantland.widget.AutofitLayout>
```

If you need to set it programmatically:
```C#
AutofitHelper.Create(textview):
```

You can customize AutofitTextView attributes, just declare the `res-auto` namespace:
```XML
xmlns:autofit="http://schemas.android.com/apk/res-auto"
```

Then you can set these attributes:

Attribute | Description  
:----: | :-------:  
minTextSize | Sets the minimum size the text will have, even when resizing to fit   
precision | Amount of precision used to calculate the correct text size to fit within its bounds. Lower precision is more precise and takes more time  
sizeToFit | Defines whether to automatically resize text to fit to the view's bounds. If set to `false` the widget will act like a normal TextView

## License
[MIT License](https://github.com/akamud/AutoFitTextView-Xamarin/blob/master/LICENSE)
