using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SFSymbolsImageProvider
{
    [AcceptEmptyServiceProvider]
    [ContentProperty(nameof(Glyph))]
    public class SFSymbolsImageExtension : IMarkupExtension<ImageSource>
    {
        public string Glyph { get; set; }
        public Color Color { get; set; }

        [TypeConverter(typeof(FontSizeConverter))]
        public double Size { get; set; } = (double)FontImageSource.SizeProperty.DefaultValue;

        public ImageSource ProvideValue(IServiceProvider serviceProvider) =>
            new SFSymbolsImageSource
            {
                Glyph = Glyph,
                Color = Color,
                Size = Size
            };

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider) =>
            (this as IMarkupExtension<ImageSource>).ProvideValue(serviceProvider);
    }
}
