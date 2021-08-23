using System;
using Xamarin.Forms;

namespace SFSymbolsImageProvider
{
    public static class SFSymbolsImageExtensions
    {
        public static SFSymbolsImageSource FromName(string name, Color? color = null) =>
            new SFSymbolsImageSource
            {
                Glyph = name,
                Color = color ?? Color.Blue,
                Size = (double)FontImageSource.SizeProperty.DefaultValue
            };
    }
}
