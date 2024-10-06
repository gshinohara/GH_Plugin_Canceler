using System;

namespace GH_Plugin_Canceler
{
    /// <summary>
    /// The result of canceler.
    /// </summary>
    public enum ResultOfCanceler
    {
        /// <summary>
        /// The method of PriorityLoad() should return GH_LoadingInstruction.Abort.
        /// </summary>
        ShouldBeCanceled,
        /// <summary>
        /// The method of PriorityLoad() should not return anything.
        /// </summary>
        NoProblem,
    }

    public static class Implementer
    {
        public static ResultOfCanceler Canceler<TAssemblyPriority>(this TAssemblyPriority priority)
            where TAssemblyPriority : Grasshopper.Kernel.GH_AssemblyPriority
        {
            return new CancelSelector(typeof(TAssemblyPriority).Assembly).ShowModal(Rhino.UI.RhinoEtoApp.MainWindow);
        } 
    }
}
