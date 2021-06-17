using System.Reflection;

namespace Mapster.Issues
{
    public class MappingRegistration : ICodeGenerationRegister
    {
        void ICodeGenerationRegister.Register(CodeGenerationConfig config)
        {
            config
                .AdaptTo("[name]Dto", MapType.Map | MapType.MapToTarget | MapType.Projection)
                .ForAllTypesInNamespace(Assembly.GetExecutingAssembly(), "Mapster.Issues.Domain");

        }
    }
}
