using MvvmCross.Core.ViewModels;

namespace MvxXam.Starter.ViewModels
{
    /// <summary>
    /// Base viewmodel class
    /// </summary>
    /// <typeparam name="P"></typeparam>
    /// <typeparam name="R"></typeparam>
    public abstract class BaseViewModel<P, R> : MvxViewModel<P, R>
    {
        /// <summary>
        /// Parameter passed during navigation
        /// </summary>
        protected P parameter;

        /// <summary>
        /// Initialize view model
        /// </summary>
        /// <returns></returns>
        public override void Prepare(P parameter)
        {
            this.parameter = parameter;
        }
    }
}
