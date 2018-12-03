namespace DemoLibrary {
  public class CallingDemo {
    private void MakeDemoCalls () {
      AccessDemo demo = new AccessDemo ();

      // Comes from the same project or assembly
      demo.InternalDemo ();

      demo.PublicDemo ();

      demo.ProtectedInternalDemo ();

    }

  }
}
