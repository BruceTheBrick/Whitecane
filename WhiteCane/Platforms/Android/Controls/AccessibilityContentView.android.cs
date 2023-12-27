#if ANDROID
using Android.Content;
using Android.Runtime;
using Android.Util;
using View = Android.Views.View;


namespace WhiteCane.Controls;

public partial class AccessibilityContentView : View
{
    public AccessibilityContentView(Context context) : base(context)
    {
    }

    public AccessibilityContentView(Context context, IAttributeSet attrs) : base(context, attrs)
    {
    }

    public AccessibilityContentView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
    {
    }

    public AccessibilityContentView(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
    {
    }
    
    protected AccessibilityContentView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
    {
    }
}
#endif