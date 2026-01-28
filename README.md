# Bcan.Backend.SharedKernel
This is a simple shared kernel API to be consumed by various layers & different bounded contexts of `Clean Architecture` styled web projects. Highly influenced by `Steve Ardalis Smith`'s implementations of Clean Architecture. Check the references for details.

## Developer Environment
###  Requirements
- .NET 9.0

### Build
```bash
# Debug
dotnet build ./SharedKernel.sln -c Debug
# Release
dotnet build ./SharedKernel.sln -c Release
```

### Test
```bash
# Debug
dotnet test ./SharedKernel.sln -c Debug
# Release
dotnet test ./SharedKernel.sln -c Release
```
## References
- [https://www.pluralsight.com/courses/domain-driven-design-fundamentals](https://www.pluralsight.com/courses/domain-driven-design-fundamentals)
- [https://github.com/ardalis/CleanArchitecture](https://github.com/ardalis/CleanArchitecture)
