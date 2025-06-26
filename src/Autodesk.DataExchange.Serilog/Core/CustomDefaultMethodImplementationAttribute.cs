#if FEATURE_DEFAULT_INTERFACE

namespace Autodesk.DataExchange.Serilog.Core;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Interface)]
sealed class CustomDefaultMethodImplementationAttribute : Attribute
{
}

#endif
