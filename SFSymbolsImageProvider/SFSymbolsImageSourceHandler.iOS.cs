using System.Threading;
using System.Threading.Tasks;
using Foundation;
using SFSymbolsImageProvider;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportImageSourceHandler(typeof(SFSymbolsImageSource), typeof(SFSymbolsImageSourceHandler))]
namespace SFSymbolsImageProvider
{
    public sealed class SFSymbolsImageSourceHandler : IImageSourceHandler
    {
        [Preserve(Conditional = true)]
        public SFSymbolsImageSourceHandler()
        {
        }

        public Task<UIImage> LoadImageAsync(
            ImageSource imagesource,
            CancellationToken cancelationToken = default,
            float scale = 1f)
        {
            var source = imagesource as SFSymbolsImageSource;
            var image = UIImage.GetSystemImage(source.Glyph)
                .ApplyTintColor(source.Color.ToUIColor(), UIImageRenderingMode.AlwaysOriginal);
            return Task.FromResult(image);
        }
    }
}
