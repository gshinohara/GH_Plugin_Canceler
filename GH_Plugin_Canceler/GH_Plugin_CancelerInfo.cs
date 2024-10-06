using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace GH_Plugin_Canceler
{
    public class GH_Plugin_CancelerInfo : GH_AssemblyInfo
    {
        public override string Name => "GH_Plugin_Canceler";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("99da63f6-b923-4911-aa2f-6388f91d6ab2");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";

        //Return a string representing the version.  This returns the same version as the assembly.
        public override string AssemblyVersion => GetType().Assembly.GetName().Version.ToString();
    }
}