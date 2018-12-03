using System;

namespace DemoLibrary {
  public class AccessDemo {

    private void Demo () {
      PrivateDemo ();
    }

    // Only accesible in the same class where it was declared, not project.
    private void PrivateDemo () { }

    // Accesible in the same class where it was declared,
    // and classes from the same project where the class is declared is inherited.
    private protected void PrivateProtectedDemo () { }

    // Used in inheritance (ClassName : InheritClassName)
    // Accesible in the class where it was created, as well where the class is inherited
    protected void ProtectedDemo () { }

    // Accesible in classes from the same project or assembly,
    // and where the class is inherited in outside projects
    protected internal void ProtectedInternalDemo () { }

    // Only accesible in the same project or assembly where it was declared
    // Accesible where the class is inherited (ClassName : InheritClassName) in the same project
    internal void InternalDemo () { }

    // Accesible everywhere
    public void PublicDemo () { }

  }
}
