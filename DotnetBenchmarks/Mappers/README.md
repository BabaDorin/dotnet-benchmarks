## Performance benchmarks against the most popular .NET mapping libraries:
- [AutoMapper][1] 10.1.1
- [Mapster][2] 7.2.0 (auto-mapping & code generation)
- [AgileMapper][3] 1.8.0
- [TinyMapper][4] 3.0.3
- [ExpressMapper][5] 1.9.1
- Manual 😎🤟

[1]: <https://www.nuget.org/packages/automapper/>
[2]: <https://www.nuget.org/packages/Mapster/>
[3]: <https://www.nuget.org/packages/Mapster/>
[4]: <https://www.nuget.org/packages/Tinymapper/>
[5]: <https://www.nuget.org/packages/ExpressMapper.Core/>

---
*Runtime: .NET 5.0.10, CPU characteristics: Intel Core i5-8250U 1.60GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores.*

Four benchmarks have been performed upon the mapping techniques from above:
- Map a small entity with 6 properties (string, int, float, double, DateTime, List<Option>, Option) to a DTO having the same structure (Option is another entity having 2 properties of type string: Label and Value). The DTO is expected to be a **deep copy** of original entity aka Entity.Option != EntityDto.Option);
- Map 1 million of small entities;
- Map a large entity containing 200 properties (150 strings + 50 composite objects (with depth of 4 levels)) 
- Map 1 million of large entities

## Mapping small entities
Both Entity and EntityDto models have the following structure:
```
public string P1 { get; set; }
public int P2 { get; set; }
public double P3 { get; set; }
public DateTime P4 { get; set; }
public float P5 { get; set; }
public List<Option> ListProp { get; set; }
public Option ObjProp { get; set; }
```

Mapping Entity to EntityDto (deep copy) - Benchmark results:
|         Method |      Mean |    Error |    StdDev |    Median | Rank |  Gen 0 | Allocated |
|--------------- |----------:|---------:|----------:|----------:|-----:|-------:|----------:|
| MapsterCodeGen |  90.25 ns | 0.546 ns |  0.484 ns |  90.17 ns |    1 | 0.1119 |     352 B |
|         Manual | 122.84 ns | 2.136 ns |  1.894 ns | 122.48 ns |    2 | 0.1370 |     432 B |
|        Mapster | 132.66 ns | 2.404 ns |  4.334 ns | 131.50 ns |    3 | 0.1115 |     352 B |
|     AutoMapper | 291.92 ns | 5.847 ns |  5.743 ns | 292.24 ns |    4 | 0.1366 |     432 B |
|    AgileMapper | 294.25 ns | 5.176 ns |  4.842 ns | 294.87 ns |    4 | 0.1937 |     616 B |
|  ExpressMapper | 346.35 ns | 3.119 ns |  2.765 ns | 345.73 ns |    5 | 0.1924 |     608 B |
|     TinyMapper | 415.88 ns | 8.299 ns | 21.423 ns | 404.79 ns |    6 | 0.1476 |     472 B |

## Mapping 1 million of small entities

|         Method |      Mean |    Error |   StdDev | Rank |       Gen 0 | Allocated |
|--------------- |----------:|---------:|---------:|-----:|------------:|----------:|
| MapsterCodeGen |  95.77 ms | 0.571 ms | 0.477 ms |    1 | 112000.0000 |    336 MB |
|         Manual | 128.19 ms | 2.557 ms | 3.140 ms |    2 | 137000.0000 |    412 MB |
|        Mapster | 128.70 ms | 2.148 ms | 2.009 ms |    2 | 112000.0000 |    336 MB |
|    AgileMapper | 283.71 ms | 5.570 ms | 8.165 ms |    3 | 196000.0000 |    587 MB |
|     AutoMapper | 284.78 ms | 5.041 ms | 4.210 ms |    3 | 137000.0000 |    412 MB |
|  ExpressMapper | 347.60 ms | 6.927 ms | 6.804 ms |    4 | 193000.0000 |    580 MB |
|     TinyMapper | 396.22 ms | 2.476 ms | 1.933 ms |    5 | 150000.0000 |    450 MB |
	
## Mapping LARGE entities

These are the results of mapping an entity with 200 properties (strings and nested objects) to a DTO with the same specifications.
	
|         Method |      Mean |     Error |    StdDev |    Median | Rank |   Gen 0 | Allocated |
|--------------- |----------:|----------:|----------:|----------:|-----:|--------:|----------:|
| MapsterCodeGen |  4.478 us | 0.0895 us | 0.2092 us |  4.370 us |    1 |  3.0582 |      9 KB |
|     TinyMapper |  4.681 us | 0.0711 us | 0.0594 us |  4.674 us |    2 |  3.0591 |      9 KB |
|        Mapster |  4.812 us | 0.0909 us | 0.1773 us |  4.763 us |    2 |  3.0610 |      9 KB |
|         Manual |  9.828 us | 0.1207 us | 0.1008 us |  9.838 us |    3 |  2.9809 |      9 KB |
|  ExpressMapper | 30.060 us | 0.5701 us | 0.4760 us | 30.102 us |    4 |  4.9650 |     15 KB |
|    AgileMapper | 31.266 us | 0.5477 us | 0.4855 us | 31.114 us |    5 | 11.5132 |     35 KB |
|     AutoMapper | 64.534 us | 0.7431 us | 0.6205 us | 64.478 us |    6 | 12.1173 |     37 KB |
  
## Mapping 1 million of large entities

|         Method |     Mean |    Error |   StdDev | Rank |         Gen 0 |     Gen 1 | Allocated |
|--------------- |---------:|---------:|---------:|-----:|--------------:|----------:|----------:|
| MapsterCodeGen |  4.282 s | 0.0243 s | 0.0203 s |    1 |  3065000.0000 |         - |      9 GB |
|        Mapster |  4.379 s | 0.0070 s | 0.0055 s |    2 |  3065000.0000 |         - |      9 GB |
|     TinyMapper |  4.532 s | 0.0136 s | 0.0114 s |    3 |  3065000.0000 |         - |      9 GB |
|         Manual |  9.889 s | 0.0501 s | 0.0444 s |    4 |  3065000.0000 |         - |      9 GB |
|  ExpressMapper | 30.527 s | 0.1528 s | 0.1429 s |    5 |  4991000.0000 | 3000.0000 |     15 GB |
|    AgileMapper | 34.159 s | 0.2031 s | 0.1801 s |    6 | 11527000.0000 | 3000.0000 |     34 GB |
|     AutoMapper | 63.510 s | 0.2733 s | 0.2557 s |    7 | 12160000.0000 | 6000.0000 |     36 GB |

# Details
## MapsterCodeGen
This approach is nothing more than manual mapping, except we're not writing the mapping logic by ourselves, instead we delegate this responsibility to Mapster library. It will generate the mapping code which will be stored in our codebase. The biggest drawback might be the fact that any change to our Entities will result into generating new mapping logic. Fortunately, this process can be automated (New mapping code will be generated (if needed) when building the solution). 
<details>
  <summary>How to map via MapsterCodeGen</summary>
  
  1. **Add this to your .csproj file**
  
  ```
<Target Name="Mapster">
	<Exec WorkingDirectory="$(ProjectDir)" Command="dotnet build" />
	<Exec WorkingDirectory="$(ProjectDir)" Command="dotnet tool restore" />
	<Exec WorkingDirectory="$(ProjectDir)" Command="dotnet mapster model -a &quot;$(TargetDir)$(ProjectName).dll&quot; -p" />
	<Exec WorkingDirectory="$(ProjectDir)" Command="dotnet mapster extension -a &quot;$(TargetDir)$(ProjectName).dll&quot; -p" />
	<Exec WorkingDirectory="$(ProjectDir)" Command="dotnet mapster mapper -a &quot;$(TargetDir)$(ProjectName).dll&quot; -p" />
  </Target>

<ItemGroup>
	<Generated Include="**\*.g.cs"/>
</ItemGroup>

<Target Name="CleanGenerated">
	<Delete Files="@(Generated)"/>
</Target>
  ```
 2. **Decorate the original entity (that you want to map to a DTO) with:**
 ```
 [AdaptTo(typeof(EntityDto)), GenerateMapper]
 public class Entity
{
...
}
 ```
 *If your entity contains properties of custom types (classes), then you have to decorate them too. Mapster should know the type to which to adapt an entity.*
 
 3. **Configure the mapper:**
```
TypeAdapterConfig config = new();
config.NewConfig<Entity, EntityDto>();
MapsterMapper.IMapper mapsterMapper = new MapsterMapper.Mapper(config);
```

4. **Generate the mapping code:**

Run the following commands in order to install Mapster.Tool and to generate the mapping code (I assume you've already installed the Mapster Nuget Package)
```
dotnet new tool-manifest 
dotnet tool install Mapster.Tool
dotnet msbuild -t:Mapster
```
The code should appear inside the Models folder.

5. **Map**

The generated code an extension method for Entity class, so it can be used like this:
```
// entity is of type 'Entity'
var dto = entity.AdaptToDto();
```
</details>

## Manual
Just manual mapping from Entity to EntityDto, nothing fancy.
```
var dto = new EntityDto
{
    P1 = entity.P1,
    P2 = entity.P2,
    P3 = entity.P3,
    P4 = entity.P4,
    P5 = entity.P5
};

if(entity.ListProp != null)
{
    dto.ListProp = new List<Option>();
    for(int i = 0;  i < entity.ListProp.Count; i++)
        dto.ListProp.Add(entity.ListProp[i].Clone()); // <= Clone() returns a new object with the same values
}

if(entity.ObjProp != null)
    dto.ObjProp = entity.ObjProp.Clone();
```

## Mapster
Unlike MapsterCodeGen, this method uses the default Adapt behavior provided by Mapster, and this is how you can use it:
```
// entity is of type 'Entity'
var dto = entity.Adapt<EntityDto>();
```
## AutoMapper
Here it goes our much loved one - AutoMapper. It has to be configured a little bit in order to create a deep copy of Entity.
```
MapperConfiguration config = new(cfg => {
    cfg.CreateMap<Entity, EntityDto>();
    cfg.CreateMap<Option, Option>();
}) ;

mapper = config.CreateMapper();
```

And this is how to use it
```
// entity is of type 'Entity'
var dto = mapper.Map<EntityDto>(entity);
```

## Express Mapper
Just register the 'From' type and 'To' type, and you're free to go:

```
Mapper.Register<Entity, EntityDto>();

// entity is of type 'Entity'
var dto = entity.Map<Entity, EntityDto>();
```

## TinyMapper
Same thing

```
TinyMapper.Bind<Entity, EntityDto>();

// entity is of type 'Entity'
var dto = TinyMapper.Map<EntityDto>(entity);
```

## AgileMapper
No configuration needed (for this specific case). As we like to say in Moldova - "Te-ai suit si ai plecat"

```
// entity is of type 'Entity'
var dto = Mapper.Map(entity).ToANew<EntityDto>();
```

# End note
Benchmarking tool: [BenchmarkDotNet][7]

[7]: <https://benchmarkdotnet.org/>
  
> If you have any concerns regarding these benchmarks, feel free to create an issue. Also, note that the results depend on model's nature and you might get different outcome for a more complex dto, which most probably will imply additional mapper configuration <= an aspect that has not been covered by these benchmarks.
