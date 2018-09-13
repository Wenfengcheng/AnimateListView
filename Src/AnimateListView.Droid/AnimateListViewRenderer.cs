using Android.Content;
using Android.Support.V4.Widget;
using AnimateListView.Droid;
using AnimateListView.Shared;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AnimationListView), typeof(AnimateListViewRenderer))]
namespace AnimateListView.Droid
{
    public class AnimateListViewRenderer : ListViewRenderer
    {
        public AnimateListViewRenderer(Context context) : base(context)
        {

        }

        public static void Initialize()
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var list = Element as AnimationListView;
                try
                {
                    var x = Control.Parent as SwipeRefreshLayout;
                    x?.SetColorSchemeColors(list.HeaderTintColor.ToAndroid());
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }
        }
    }
}
