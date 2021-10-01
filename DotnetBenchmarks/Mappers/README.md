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
*The following benchmarks have been run on .NET 5.0.10 Runtime with the folliwing CPU characteristics: Intel Core i5-8250U 1.60GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores.*

Three benchmarks have been performed upon the mapping techniques from above:
- Map a small entity containing 6 properties (string, int, float, double, DateTime, List<Option>, Option) to a DTO having the same structure (Option is another entity having 2 properties of type string: Label and Value). The DTO is expected to be a **deep copy** of original entity aka Entity.Option != EntityDto.Option).
- Map a large entity containing 1000 properties (the same properties as in the first case, but multiplied). The same rules apply here.
- Map a large number (1.000.000) of small entities (6 props). The same rules apply here. 

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
|         Method |        Mean |      Error |       StdDev |      Median | Rank |  Gen 0 | Allocated |
|--------------- |------------:|-----------:|-------------:|------------:|-----:|-------:|----------:|
| MapsterCodeGen |    90.06 ns |   1.265 ns |     1.184 ns |    89.54 ns |    1 | 0.1122 |     352 B |
|         Manual |   124.63 ns |   2.361 ns |     4.073 ns |   123.23 ns |    2 | 0.1376 |     432 B |
|        Mapster |   129.20 ns |   2.522 ns |     3.098 ns |   127.69 ns |    3 | 0.1121 |     352 B |
|     AutoMapper |   309.08 ns |   5.529 ns |     5.171 ns |   309.40 ns |    4 | 0.1373 |     432 B |
|  ExpressMapper |   348.53 ns |   1.041 ns |     0.922 ns |   348.84 ns |    5 | 0.1936 |     608 B |
|     TinyMapper |   407.31 ns |   7.945 ns |     7.432 ns |   403.21 ns |    6 | 0.1502 |     472 B |
|    AgileMapper | 6,689.13 ns | 924.696 ns | 2,608.122 ns | 5,400.00 ns |    7 |      - |     616 B |

![](https://i.imgur.com/as1t6Xg.png)


## Mapping LARGE entities
You're free to create your own definition of 'large' entity :) it might contain 50, 100, or 500 properties (horizontally expansion) or a lot of nested objects (vertically expansion). 
These are the results of mapping an entity with about 1k properties (int, double, float, string, DateTime, List, custom Type) to a DTO with the same specifications. *There is a separate branch for this benchmark.*
|         Method |      Mean |     Error |     StdDev |    Median | Rank |   Gen 0 | Allocated |
|--------------- |----------:|----------:|-----------:|----------:|-----:|--------:|----------:|
|    AgileMapper |  69.08 us |  1.061 us |   0.941 us |  69.02 us |    1 | 15.3809 |     47 KB |
|        Mapster |  87.70 us |  9.933 us |  28.499 us |  72.60 us |    1 |       - |     47 KB |
| MapsterCodeGen |  98.27 us |  7.729 us |  21.545 us |  92.25 us |    2 |       - |     47 KB |
|  ExpressMapper | 108.80 us |  0.330 us |   0.258 us | 108.86 us |    3 | 25.1465 |     77 KB |
|         Manual | 130.85 us | 21.646 us |  62.453 us |  98.50 us |    3 |       - |     58 KB |
|     TinyMapper | 206.14 us | 34.776 us | 101.442 us | 155.30 us |    4 |       - |     64 KB |
|     AutoMapper | 232.26 us | 17.171 us |  48.432 us | 213.45 us |    5 |       - |     58 KB |

![](https://i.imgur.com/dRbUDHr.png)

Surprisingly enough, AgileMapper (the least efficient from the previous benchmark) seems to be the most efficient when it comes to mapping large objects, even more efficient than Manual Mapping (you probably won't have to map objects with so many properties tho :) It is interesting to know that, in such cases, reflection might overtake manual mapping from the performance point of view.

Down below is an aproximation on how mappers' performance varies depending on the number of properties.
![](https://i.imgur.com/MCFYOjO.png)
  
# Mapping a large amount of small entities
Benchmarking rules for this case: Map 1 000 000 entities (entities' structures are specified in the first benchmark).
|         Method |      Mean |    Error |   StdDev | Rank |       Gen 0 | Allocated |
|--------------- |----------:|---------:|---------:|-----:|------------:|----------:|
| MapsterCodeGen |  90.35 ms | 0.555 ms | 0.492 ms |    1 | 112000.0000 |    336 MB |
|        Mapster | 126.43 ms | 0.723 ms | 0.603 ms |    2 | 112000.0000 |    336 MB |
|         Manual | 132.96 ms | 2.636 ms | 5.203 ms |    3 | 137000.0000 |    412 MB |
|    AgileMapper | 282.92 ms | 2.482 ms | 2.073 ms |    4 | 196000.0000 |    587 MB |
|     AutoMapper | 292.23 ms | 5.743 ms | 7.861 ms |    5 | 137000.0000 |    412 MB |
|  ExpressMapper | 353.75 ms | 1.272 ms | 1.128 ms |    6 | 193000.0000 |    580 MB |
|     TinyMapper | 409.35 ms | 7.554 ms | 6.308 ms |    7 | 150000.0000 |    450 MB |

  
![](https://i.imgur.com/CBIifPW.png)
  

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
  
> If you have any concerns regarding these benchmarks, feel free to create an issue.
