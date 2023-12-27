using System.Windows.Input;
using AndroidX.Core.View.Accessibility;
using Java.Interop;

namespace WhiteCane.Controls;

public class NativeAccessibilityAction :  IAccessibilityViewCommand
{
    private readonly ICommand _command;

    public NativeAccessibilityAction(ICommand command)
    {
        _command = command;
    }

    public bool Perform(Android.Views.View view, AccessibilityViewCommandCommandArguments arguments)
    {
        try
        {
            _command?.Execute(null);
        }
        catch (Exception e)
        {
            return false;
        }

        return true;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public IntPtr Handle { get; }
    public void SetJniIdentityHashCode(int value)
    {
        throw new NotImplementedException();
    }

    public void SetPeerReference(JniObjectReference reference)
    {
        throw new NotImplementedException();
    }

    public void SetJniManagedPeerState(JniManagedPeerStates value)
    {
        throw new NotImplementedException();
    }

    public void UnregisterFromRuntime()
    {
        throw new NotImplementedException();
    }

    public void DisposeUnlessReferenced()
    {
        throw new NotImplementedException();
    }

    public void Disposed()
    {
        throw new NotImplementedException();
    }

    public void Finalized()
    {
        throw new NotImplementedException();
    }

    public int JniIdentityHashCode { get; }
    public JniObjectReference PeerReference { get; }
    public JniPeerMembers JniPeerMembers { get; }
    public JniManagedPeerStates JniManagedPeerState { get; }
}