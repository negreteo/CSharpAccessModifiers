namespace DemoLibrary {
  public class InheritFromAccessDemo : AccessDemo {
    private void Test () {

      // Protected inherited methods
      ProtectedDemo ();
      InternalDemo ();
      PrivateProtectedDemo ();
      ProtectedInternalDemo ();
    }

  }
}
