using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.VisualStudio.Web.CodeGeneration.Utils;
using SimpleInjector;

namespace ProjetoModeloDDD.MVC
{
    public sealed class SimpleInjectorViewComponentActivator2: IViewComponentActivator
    {
        private readonly Container container;

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleInjectorViewComponentActivator"/> class.
        /// </summary>
        /// <param name="container">The container instance.</param>
        public SimpleInjectorViewComponentActivator(Container container)
        {
            Requires.NotNull(container, nameof(container));

            this.container = container;
        }

        /// <summary>Creates a view component.</summary>
        /// <param name="context">The <see cref="ViewComponentContext"/> for the executing <see cref="ViewComponent"/>.</param>
        /// <returns>A view component instance.</returns>
        public object Create(ViewComponentContext context) =>
            this.container.GetInstance(context.ViewComponentDescriptor.TypeInfo.AsType());

        /// <summary>Releases the view component.</summary>
        /// <param name="context">The <see cref="ViewComponentContext"/> associated with the viewComponent.</param>
        /// <param name="viewComponent">The view component to release.</param>
        public void Release(ViewComponentContext context, object viewComponent)
        {
            // No-op.
        }
    }
}
