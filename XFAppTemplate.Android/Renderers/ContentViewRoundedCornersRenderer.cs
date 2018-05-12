using Android.Graphics;
using Android.Util;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFAppTemplate.Controls;
using XFAppTemplate.Droid.Renderers;

[assembly: ExportRenderer(typeof(ContentViewRoundedCorners), typeof(ContentViewRoundedCornersRenderer))]
namespace XFAppTemplate.Droid.Renderers
{
    public class ContentViewRoundedCornersRenderer : VisualElementRenderer<ContentView>
    {
        private float _cornerRadius;

        public ContentViewRoundedCornersRenderer(Android.Content.Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<ContentView> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
                return;

            var element = (ContentViewRoundedCorners)Element;

            _cornerRadius = TypedValue.ApplyDimension(ComplexUnitType.Dip, element.CornerRadius, Context.Resources.DisplayMetrics);
        }

        public override void Draw(Canvas canvas)
        {
            RectF bounds = new RectF(0, 0, Width, Height);

            Path path = new Path();
            path.Reset();
            path.AddRoundRect(bounds, _cornerRadius, _cornerRadius, Path.Direction.Cw);

            path.Close();

            canvas.Save();
            canvas.ClipPath(path);
            base.Draw(canvas);
            canvas.Restore();
        }
    }
}