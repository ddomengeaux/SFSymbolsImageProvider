# SFImageProvider

![CI](https://github.com/ddomengeaux/SFSymbolsImageProvider/actions/workflows/ci.yml/badge.svg)

Provides a Xamarin.Forms ImageSource to load Apple's SF Symbols (<https://developer.apple.com/sf-symbols/>)

## Using

Can be used just like the FontImageSource <https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/text/fonts#display-font-icons>. Simply set Glyph to be the SF Symbols name.

```xml
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfsymbols="clr-namespace:SFSymbolsImageProvider;assembly=SFSymbolsImageProvider"
             x:Class="Test.MainPage">

    <StackLayout>
        <Button
                ImageSource="{sfsymbols:SFSymbolsImage Glyph='exclamationmark.shield', Color=Red, Size=25}"
                Text="Test"
                Padding="10" />
    </StackLayout>

</ContentPage>
```
