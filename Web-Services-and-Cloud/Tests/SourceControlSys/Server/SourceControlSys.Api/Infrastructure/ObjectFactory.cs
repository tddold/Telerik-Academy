namespace SourceControlSys.Api.Infrastructure
{
    using Ninject;
    public static class ObjectFactory
    {
        private static IKernel savedKernel;

        public static void Initilize(IKernel kernel)
        {
            savedKernel = kernel;
        }

        public static T Get<T>()
        {
            return savedKernel.Get<T>();
        }
    }
}