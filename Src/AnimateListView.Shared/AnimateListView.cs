using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace AnimateListView.Shared
{
    public class AnimationListView : ListView
    {
        // Refresh Control Color
        public static BindableProperty RefreshControlColorProperty = BindableProperty.Create(nameof(RefreshControlColor), typeof(Color), typeof(AnimationListView), defaultValue: Color.White);

        public Color RefreshControlColor
        {
            get
            {
                return (Color)GetValue(RefreshControlColorProperty);
            }
            set
            {
                SetValue(RefreshControlColorProperty, value);
            }
        }

        // custom header background color
        public static BindableProperty HeaderColorProperty = BindableProperty.Create(nameof(HeaderColor), typeof(Color), typeof(AnimationListView), defaultValue: Color.White);

        public Color HeaderColor
        {
            get
            {
                return (Color)GetValue(HeaderColorProperty);
            }
            set
            {
                SetValue(HeaderColorProperty, value);
            }
        }

        // custom header tint color
        public static BindableProperty HeaderTintColorProperty = BindableProperty.Create(nameof(HeaderTintColor), typeof(Color), typeof(AnimationListView), defaultValue: Color.White);

        public Color HeaderTintColor
        {
            get
            {
                return (Color)GetValue(HeaderTintColorProperty);
            }
            set
            {
                SetValue(HeaderTintColorProperty, value);
            }
        }

        // Enable Custom Refresh
        public static BindableProperty EnableRefreshProperty = BindableProperty.Create(nameof(EnableRefresh), typeof(bool), typeof(AnimationListView), defaultValue: false);

        public bool EnableRefresh
        {
            get
            {
                return (bool)GetValue(EnableRefreshProperty);
            }
            set
            {
                SetValue(EnableRefreshProperty, value);
            }
        }

        // Loadmore command
        public static BindableProperty LoadMoreCommandProperty = BindableProperty.Create(nameof(LoadMoreCommand), typeof(ICommand), typeof(AnimationListView), defaultValue: default(ICommand));

        public ICommand LoadMoreCommand
        {
            get
            {
                return (ICommand)GetValue(LoadMoreCommandProperty);
            }
            set
            {
                SetValue(LoadMoreCommandProperty, value);
            }
        }
    }
}
