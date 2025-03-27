This file is a merged representation of a subset of the codebase, containing files not matching ignore patterns, combined into a single document by Repomix. The content has been processed where comments have been removed, empty lines have been removed, line numbers have been added, content has been formatted for parsing, security check has been disabled.

# File Summary

## Purpose
This file contains a packed representation of the entire repository's contents.
It is designed to be easily consumable by AI systems for analysis, code review,
or other automated processes.

## File Format
The content is organized as follows:
1. This summary section
2. Repository information
3. Directory structure
4. Multiple file entries, each consisting of:
  a. A header with the file path (## File: path/to/file)
  b. The full contents of the file in a code block

## Usage Guidelines
- This file should be treated as read-only. Any changes should be made to the
  original repository files, not this packed version.
- When processing this file, use the file path to distinguish
  between different files in the repository.
- Be aware that this file may contain sensitive information. Handle it with
  the same level of security as you would the original repository.

## Notes
- Some files may have been excluded based on .gitignore rules and Repomix's configuration
- Binary files are not included in this packed representation. Please refer to the Repository Structure section for a complete list of file paths, including binary files
- Files matching these patterns are excluded: src/Aeq.CoreMvc.EntityFrameworkCore/Migrations, .cursor/rules, README.md, NuGet.Config, common.props, .prettierrc
- Files matching patterns in .gitignore are excluded
- Files matching default ignore patterns are excluded
- Code comments have been removed from supported file types
- Empty lines have been removed from all files
- Line numbers have been added to the beginning of each line
- Content has been formatted for parsing in markdown style
- Security check has been disabled - content may contain sensitive information

## Additional Info

# Directory Structure
```
src/
  Aeq.CoreMvc.Application/
    Books/
      AuthorAppService.cs
      BookAppService.cs
    Properties/
      AssemblyInfo.cs
    Aeq.CoreMvc.Application.csproj
    CoreMvcApplicationAutoMapperProfile.cs
    CoreMvcApplicationModule.cs
    CoreMvcAppService.cs
  Aeq.CoreMvc.Application.Contracts/
    Books/
      Dtos/
        AuthorDto.cs
        AuthorGetListInput.cs
        BookDto.cs
        BookGetListInput.cs
        CreateUpdateAuthorDto.cs
        CreateUpdateBookDto.cs
      IAuthorAppService.cs
      IBookAppService.cs
    Permissions/
      CoreMvcPermissionDefinitionProvider.cs
      CoreMvcPermissions.cs
    Aeq.CoreMvc.Application.Contracts.csproj
    CoreMvcApplicationContractsModule.cs
    CoreMvcDtoExtensions.cs
  Aeq.CoreMvc.DbMigrator/
    Aeq.CoreMvc.DbMigrator.csproj
    appsettings.json
    appsettings.secrets.json
    CoreMvcDbMigratorModule.cs
    DbMigratorHostedService.cs
    Program.cs
  Aeq.CoreMvc.Domain/
    Books/
      Author.cs
      Book.cs
      IAuthorRepository.cs
      IBookRepository.cs
    Data/
      CoreMvcDbMigrationService.cs
      ICoreMvcDbSchemaMigrator.cs
      NullCoreMvcDbSchemaMigrator.cs
    OpenIddict/
      OpenIddictDataSeedContributor.cs
    Properties/
      AssemblyInfo.cs
    Settings/
      CoreMvcSettingDefinitionProvider.cs
      CoreMvcSettings.cs
    Aeq.CoreMvc.Domain.csproj
    CoreMvcConsts.cs
    CoreMvcDomainModule.cs
  Aeq.CoreMvc.Domain.Shared/
    Localization/
      CoreMvc/
        en-GB.json
        en.json
        vi.json
        zh-Hans.json
        zh-Hant.json
      CoreMvcResource.cs
    MultiTenancy/
      MultiTenancyConsts.cs
    Aeq.CoreMvc.Domain.Shared.csproj
    CoreMvcDomainErrorCodes.cs
    CoreMvcDomainSharedModule.cs
    CoreMvcGlobalFeatureConfigurator.cs
    CoreMvcModuleExtensionConfigurator.cs
  Aeq.CoreMvc.EntityFrameworkCore/
    Books/
      AuthorEfCoreQueryableExtensions.cs
      AuthorRepository.cs
      BookEfCoreQueryableExtensions.cs
      BookRepository.cs
    EntityFrameworkCore/
      CoreMvcDbContext.cs
      CoreMvcDbContextFactory.cs
      CoreMvcEfCoreEntityExtensionMappings.cs
      CoreMvcEntityFrameworkCoreModule.cs
      EntityFrameworkCoreCoreMvcDbSchemaMigrator.cs
    Properties/
      AssemblyInfo.cs
    Aeq.CoreMvc.EntityFrameworkCore.csproj
  Aeq.CoreMvc.HttpApi/
    Controllers/
      CoreMvcController.cs
    Models/
      Test/
        TestModel.cs
    Aeq.CoreMvc.HttpApi.csproj
    CoreMvcHttpApiModule.cs
  Aeq.CoreMvc.HttpApi.Client/
    Aeq.CoreMvc.HttpApi.Client.csproj
    CoreMvcHttpApiClientModule.cs
  Aeq.CoreMvc.Web/
    Components/
      _ViewImports.cshtml
    Menus/
      CoreMvcMenuContributor.cs
      CoreMvcMenus.cs
    Pages/
      Books/
        Author/
          ViewModels/
            CreateEditAuthorViewModel.cs
          CreateModal.cshtml
          CreateModal.cshtml.cs
          EditModal.cshtml
          EditModal.cshtml.cs
          Index.cshtml
          Index.cshtml.cs
          index.js
        Book/
          ViewModels/
            CreateEditBookViewModel.cs
          CreateModal.cshtml
          CreateModal.cshtml.cs
          EditModal.cshtml
          EditModal.cshtml.cs
          Index.cshtml
          Index.cshtml.cs
          index.js
      _ViewImports.cshtml
      CoreMvcPageModel.cs
      Index.cshtml
      Index.cshtml.cs
      Index.css
      Index.js
    Properties/
      AssemblyInfo.cs
      launchSettings.json
    Views/
      _ViewImports.cshtml
    wwwroot/
      images/
        getting-started/
          discord.svg
          instagram.svg
          stack-overflow.svg
          x-white.svg
          youtube.svg
      global-styles.css
    abp.resourcemapping.js
    Aeq.CoreMvc.Web.csproj
    appsettings.Development.json
    appsettings.json
    appsettings.secrets.json
    CoreMvcBrandingProvider.cs
    CoreMvcWebAutoMapperProfile.cs
    CoreMvcWebModule.cs
    package.json
    Program.cs
    web.config
test/
  Aeq.CoreMvc.Application.Tests/
    Books/
      BookAppServiceTests.cs
    Samples/
      SampleAppServiceTests.cs
    Aeq.CoreMvc.Application.Tests.csproj
    CoreMvcApplicationTestBase.cs
    CoreMvcApplicationTestModule.cs
  Aeq.CoreMvc.Domain.Tests/
    Books/
      BookDomainTests.cs
    Samples/
      SampleDomainTests.cs
    Aeq.CoreMvc.Domain.Tests.csproj
    CoreMvcDomainTestBase.cs
    CoreMvcDomainTestModule.cs
  Aeq.CoreMvc.EntityFrameworkCore.Tests/
    EntityFrameworkCore/
      Applications/
        EfCoreSampleAppServiceTests.cs
      Books/
        BookRepositoryTests.cs
      Domains/
        EfCoreSampleDomainTests.cs
      Samples/
        SampleRepositoryTests.cs
      CoreMvcEntityFrameworkCoreCollection.cs
      CoreMvcEntityFrameworkCoreCollectionFixtureBase.cs
      CoreMvcEntityFrameworkCoreFixture.cs
      CoreMvcEntityFrameworkCoreTestBase.cs
      CoreMvcEntityFrameworkCoreTestModule.cs
    Aeq.CoreMvc.EntityFrameworkCore.Tests.csproj
  Aeq.CoreMvc.HttpApi.Client.ConsoleTestApp/
    Aeq.CoreMvc.HttpApi.Client.ConsoleTestApp.csproj
    appsettings.json
    appsettings.secrets.json
    ClientDemoService.cs
    ConsoleTestAppHostedService.cs
    CoreMvcConsoleApiClientModule.cs
    Program.cs
  Aeq.CoreMvc.TestBase/
    Security/
      FakeCurrentPrincipalAccessor.cs
    Aeq.CoreMvc.TestBase.csproj
    CoreMvcTestBase.cs
    CoreMvcTestBaseModule.cs
    CoreMvcTestConsts.cs
    CoreMvcTestDataSeedContributor.cs
  Aeq.CoreMvc.Web.Tests/
    Pages/
      Books/
        IndexTests.cs
      Index_Tests.cs
    Aeq.CoreMvc.Web.Tests.csproj
    CoreMvcWebTestBase.cs
    CoreMvcWebTestModule.cs
    Program.cs
    xunit.runner.json
.gitattributes
.gitignore
Aeq.CoreMvc.sln
Aeq.CoreMvc.sln.DotSettings
```

# Files

## File: src/Aeq.CoreMvc.Application/Books/AuthorAppService.cs
```csharp
 1: using System;
 2: using System.Linq;
 3: using System.Threading.Tasks;
 4: using Aeq.CoreMvc.Permissions;
 5: using Aeq.CoreMvc.Books.Dtos;
 6: using Volo.Abp.Application.Services;
 7: namespace Aeq.CoreMvc.Books;
 8: public class AuthorAppService : CrudAppService<Author, AuthorDto, Guid, AuthorGetListInput, CreateUpdateAuthorDto, CreateUpdateAuthorDto>,
 9:     IAuthorAppService
10: {
11:     protected override string GetPolicyName { get; set; } = CoreMvcPermissions.Author.Default;
12:     protected override string GetListPolicyName { get; set; } = CoreMvcPermissions.Author.Default;
13:     protected override string CreatePolicyName { get; set; } = CoreMvcPermissions.Author.Create;
14:     protected override string UpdatePolicyName { get; set; } = CoreMvcPermissions.Author.Update;
15:     protected override string DeletePolicyName { get; set; } = CoreMvcPermissions.Author.Delete;
16:     private readonly IAuthorRepository _repository;
17:     public AuthorAppService(IAuthorRepository repository) : base(repository)
18:     {
19:         _repository = repository;
20:     }
21:     protected override async Task<IQueryable<Author>> CreateFilteredQueryAsync(AuthorGetListInput input)
22:     {
23:         return (await base.CreateFilteredQueryAsync(input))
24:             .WhereIf(!input.Name.IsNullOrWhiteSpace(), x => x.Name.Contains(input.Name))
25:             .WhereIf(!input.PhoneNumber.IsNullOrWhiteSpace(), x => x.PhoneNumber.Contains(input.PhoneNumber))
26:             .WhereIf(!input.Email.IsNullOrWhiteSpace(), x => x.Email.Contains(input.Email))
27:             ;
28:     }
29: }
```

## File: src/Aeq.CoreMvc.Application/Books/BookAppService.cs
```csharp
 1: using System;
 2: using System.Linq;
 3: using System.Threading.Tasks;
 4: using Aeq.CoreMvc.Permissions;
 5: using Aeq.CoreMvc.Books.Dtos;
 6: using Volo.Abp.Application.Services;
 7: namespace Aeq.CoreMvc.Books;
 8: public class BookAppService : CrudAppService<Book, BookDto, Guid, BookGetListInput, CreateUpdateBookDto, CreateUpdateBookDto>,
 9:     IBookAppService
10: {
11:     protected override string GetPolicyName { get; set; } = CoreMvcPermissions.Book.Default;
12:     protected override string GetListPolicyName { get; set; } = CoreMvcPermissions.Book.Default;
13:     protected override string CreatePolicyName { get; set; } = CoreMvcPermissions.Book.Create;
14:     protected override string UpdatePolicyName { get; set; } = CoreMvcPermissions.Book.Update;
15:     protected override string DeletePolicyName { get; set; } = CoreMvcPermissions.Book.Delete;
16:     private readonly IBookRepository _repository;
17:     public BookAppService(IBookRepository repository) : base(repository)
18:     {
19:         _repository = repository;
20:     }
21:     protected override async Task<IQueryable<Book>> CreateFilteredQueryAsync(BookGetListInput input)
22:     {
23:         return (await base.CreateFilteredQueryAsync(input))
24:             .WhereIf(!input.Name.IsNullOrWhiteSpace(), x => x.Name.Contains(input.Name))
25:             .WhereIf(!input.Type.IsNullOrWhiteSpace(), x => x.Type.Contains(input.Type))
26:             .WhereIf(!input.Description.IsNullOrWhiteSpace(), x => x.Description.Contains(input.Description))
27:             .WhereIf(input.PublishDate != null, x => x.PublishDate == input.PublishDate)
28:             ;
29:     }
30: }
```

## File: src/Aeq.CoreMvc.Application/Properties/AssemblyInfo.cs
```csharp
1: using System.Runtime.CompilerServices;
2: [assembly:InternalsVisibleToAttribute("Aeq.CoreMvc.Application.Tests")]
```

## File: src/Aeq.CoreMvc.Application/Aeq.CoreMvc.Application.csproj
```
 1: <Project Sdk="Microsoft.NET.Sdk">
 2: 
 3:   <Import Project="..\..\common.props" />
 4: 
 5:   <PropertyGroup>
 6:     <TargetFramework>net9.0</TargetFramework>
 7:     <Nullable>enable</Nullable>
 8:     <RootNamespace>Aeq.CoreMvc</RootNamespace>
 9:   </PropertyGroup>
10: 
11:   <ItemGroup>
12:     <ProjectReference Include="..\Aeq.CoreMvc.Domain\Aeq.CoreMvc.Domain.csproj" />
13:     <ProjectReference Include="..\Aeq.CoreMvc.Application.Contracts\Aeq.CoreMvc.Application.Contracts.csproj" />
14:   </ItemGroup>
15: 
16:   <ItemGroup>
17:     <PackageReference Include="Volo.Abp.Account.Application" Version="9.0.8" />
18:     <PackageReference Include="Volo.Abp.Identity.Application" Version="9.0.8" />
19:     <PackageReference Include="Volo.Abp.PermissionManagement.Application" Version="9.0.8" />
20:     <PackageReference Include="Volo.Abp.TenantManagement.Application" Version="9.0.8" />
21:     <PackageReference Include="Volo.Abp.FeatureManagement.Application" Version="9.0.8" />
22:     <PackageReference Include="Volo.Abp.SettingManagement.Application" Version="9.0.8" />
23:   </ItemGroup>
24: 
25: </Project>
```

## File: src/Aeq.CoreMvc.Application/CoreMvcApplicationAutoMapperProfile.cs
```csharp
 1: using Aeq.CoreMvc.Books;
 2: using Aeq.CoreMvc.Books.Dtos;
 3: using AutoMapper;
 4: namespace Aeq.CoreMvc;
 5: public class CoreMvcApplicationAutoMapperProfile : Profile
 6: {
 7:     public CoreMvcApplicationAutoMapperProfile()
 8:     {
 9:         CreateMap<Book, BookDto>();
10:         CreateMap<CreateUpdateBookDto, Book>(MemberList.Source);
11:         CreateMap<Author, AuthorDto>();
12:         CreateMap<CreateUpdateAuthorDto, Author>(MemberList.Source);
13:     }
14: }
```

## File: src/Aeq.CoreMvc.Application/CoreMvcApplicationModule.cs
```csharp
 1: using Volo.Abp.Account;
 2: using Volo.Abp.AutoMapper;
 3: using Volo.Abp.FeatureManagement;
 4: using Volo.Abp.Identity;
 5: using Volo.Abp.Modularity;
 6: using Volo.Abp.PermissionManagement;
 7: using Volo.Abp.SettingManagement;
 8: using Volo.Abp.TenantManagement;
 9: namespace Aeq.CoreMvc;
10: [DependsOn(
11:     typeof(CoreMvcDomainModule),
12:     typeof(AbpAccountApplicationModule),
13:     typeof(CoreMvcApplicationContractsModule),
14:     typeof(AbpIdentityApplicationModule),
15:     typeof(AbpPermissionManagementApplicationModule),
16:     typeof(AbpTenantManagementApplicationModule),
17:     typeof(AbpFeatureManagementApplicationModule),
18:     typeof(AbpSettingManagementApplicationModule)
19:     )]
20: public class CoreMvcApplicationModule : AbpModule
21: {
22:     public override void ConfigureServices(ServiceConfigurationContext context)
23:     {
24:         Configure<AbpAutoMapperOptions>(options =>
25:         {
26:             options.AddMaps<CoreMvcApplicationModule>();
27:         });
28:     }
29: }
```

## File: src/Aeq.CoreMvc.Application/CoreMvcAppService.cs
```csharp
 1: using System;
 2: using System.Collections.Generic;
 3: using System.Text;
 4: using Aeq.CoreMvc.Localization;
 5: using Volo.Abp.Application.Services;
 6: namespace Aeq.CoreMvc;
 7: public abstract class CoreMvcAppService : ApplicationService
 8: {
 9:     protected CoreMvcAppService()
10:     {
11:         LocalizationResource = typeof(CoreMvcResource);
12:     }
13: }
```

## File: src/Aeq.CoreMvc.Application.Contracts/Books/Dtos/AuthorDto.cs
```csharp
 1: using System;
 2: using Volo.Abp.Application.Dtos;
 3: namespace Aeq.CoreMvc.Books.Dtos;
 4: [Serializable]
 5: public class AuthorDto : FullAuditedEntityDto<Guid>
 6: {
 7:     public string Name { get; set; }
 8:     public string PhoneNumber { get; set; }
 9:     public string Email { get; set; }
10: }
```

## File: src/Aeq.CoreMvc.Application.Contracts/Books/Dtos/AuthorGetListInput.cs
```csharp
 1: using System;
 2: using System.ComponentModel;
 3: using Volo.Abp.Application.Dtos;
 4: namespace Aeq.CoreMvc.Books.Dtos;
 5: [Serializable]
 6: public class AuthorGetListInput : PagedAndSortedResultRequestDto
 7: {
 8:     public string? Name { get; set; }
 9:     public string? PhoneNumber { get; set; }
10:     public string? Email { get; set; }
11: }
```

## File: src/Aeq.CoreMvc.Application.Contracts/Books/Dtos/BookDto.cs
```csharp
 1: using System;
 2: using Volo.Abp.Application.Dtos;
 3: namespace Aeq.CoreMvc.Books.Dtos;
 4: [Serializable]
 5: public class BookDto : FullAuditedEntityDto<Guid>
 6: {
 7:     public string Name { get; set; }
 8:     public string Type { get; set; }
 9:     public string Description { get; set; }
10:     public DateTime PublishDate { get; set; }
11: }
```

## File: src/Aeq.CoreMvc.Application.Contracts/Books/Dtos/BookGetListInput.cs
```csharp
 1: using System;
 2: using System.ComponentModel;
 3: using Volo.Abp.Application.Dtos;
 4: namespace Aeq.CoreMvc.Books.Dtos;
 5: [Serializable]
 6: public class BookGetListInput : PagedAndSortedResultRequestDto
 7: {
 8:     public string? Name { get; set; }
 9:     public string? Type { get; set; }
10:     public string? Description { get; set; }
11:     public DateTime? PublishDate { get; set; }
12: }
```

## File: src/Aeq.CoreMvc.Application.Contracts/Books/Dtos/CreateUpdateAuthorDto.cs
```csharp
1: using System;
2: namespace Aeq.CoreMvc.Books.Dtos;
3: [Serializable]
4: public class CreateUpdateAuthorDto
5: {
6:     public string Name { get; set; }
7:     public string PhoneNumber { get; set; }
8:     public string Email { get; set; }
9: }
```

## File: src/Aeq.CoreMvc.Application.Contracts/Books/Dtos/CreateUpdateBookDto.cs
```csharp
 1: using System;
 2: namespace Aeq.CoreMvc.Books.Dtos;
 3: [Serializable]
 4: public class CreateUpdateBookDto
 5: {
 6:     public string Name { get; set; }
 7:     public string Type { get; set; }
 8:     public string Description { get; set; }
 9:     public DateTime PublishDate { get; set; }
10: }
```

## File: src/Aeq.CoreMvc.Application.Contracts/Books/IAuthorAppService.cs
```csharp
 1: using System;
 2: using Aeq.CoreMvc.Books.Dtos;
 3: using Volo.Abp.Application.Services;
 4: namespace Aeq.CoreMvc.Books;
 5: public interface IAuthorAppService :
 6:     ICrudAppService<
 7:         AuthorDto,
 8:         Guid,
 9:         AuthorGetListInput,
10:         CreateUpdateAuthorDto,
11:         CreateUpdateAuthorDto>
12: {
13: }
```

## File: src/Aeq.CoreMvc.Application.Contracts/Books/IBookAppService.cs
```csharp
 1: using System;
 2: using Aeq.CoreMvc.Books.Dtos;
 3: using Volo.Abp.Application.Services;
 4: namespace Aeq.CoreMvc.Books;
 5: public interface IBookAppService :
 6:     ICrudAppService<
 7:         BookDto,
 8:         Guid,
 9:         BookGetListInput,
10:         CreateUpdateBookDto,
11:         CreateUpdateBookDto>
12: {
13: }
```

## File: src/Aeq.CoreMvc.Application.Contracts/Permissions/CoreMvcPermissionDefinitionProvider.cs
```csharp
 1: using Aeq.CoreMvc.Localization;
 2: using Volo.Abp.Authorization.Permissions;
 3: using Volo.Abp.Localization;
 4: namespace Aeq.CoreMvc.Permissions;
 5: public class CoreMvcPermissionDefinitionProvider : PermissionDefinitionProvider
 6: {
 7:     public override void Define(IPermissionDefinitionContext context)
 8:     {
 9:         var myGroup = context.AddGroup(CoreMvcPermissions.GroupName);
10:         var bookPermission = myGroup.AddPermission(CoreMvcPermissions.Book.Default, L("Permission:Book"));
11:         bookPermission.AddChild(CoreMvcPermissions.Book.Create, L("Permission:Create"));
12:         bookPermission.AddChild(CoreMvcPermissions.Book.Update, L("Permission:Update"));
13:         bookPermission.AddChild(CoreMvcPermissions.Book.Delete, L("Permission:Delete"));
14:         var authorPermission = myGroup.AddPermission(CoreMvcPermissions.Author.Default, L("Permission:Author"));
15:         authorPermission.AddChild(CoreMvcPermissions.Author.Create, L("Permission:Create"));
16:         authorPermission.AddChild(CoreMvcPermissions.Author.Update, L("Permission:Update"));
17:         authorPermission.AddChild(CoreMvcPermissions.Author.Delete, L("Permission:Delete"));
18:     }
19:     private static LocalizableString L(string name)
20:     {
21:         return LocalizableString.Create<CoreMvcResource>(name);
22:     }
23: }
```

## File: src/Aeq.CoreMvc.Application.Contracts/Permissions/CoreMvcPermissions.cs
```csharp
 1: namespace Aeq.CoreMvc.Permissions;
 2: public static class CoreMvcPermissions
 3: {
 4:     public const string GroupName = "CoreMvc";
 5:     public class Book
 6:     {
 7:         public const string Default = GroupName + ".Book";
 8:         public const string Update = Default + ".Update";
 9:         public const string Create = Default + ".Create";
10:         public const string Delete = Default + ".Delete";
11:     }
12:     public class Author
13:     {
14:         public const string Default = GroupName + ".Author";
15:         public const string Update = Default + ".Update";
16:         public const string Create = Default + ".Create";
17:         public const string Delete = Default + ".Delete";
18:     }
19: }
```

## File: src/Aeq.CoreMvc.Application.Contracts/Aeq.CoreMvc.Application.Contracts.csproj
```
 1: <Project Sdk="Microsoft.NET.Sdk">
 2: 
 3:   <Import Project="..\..\common.props" />
 4: 
 5:   <PropertyGroup>
 6:     <TargetFramework>net9.0</TargetFramework>
 7:     <Nullable>enable</Nullable>
 8:     <RootNamespace>Aeq.CoreMvc</RootNamespace>
 9:   </PropertyGroup>
10: 
11:   <ItemGroup>
12:     <ProjectReference Include="..\Aeq.CoreMvc.Domain.Shared\Aeq.CoreMvc.Domain.Shared.csproj" />
13:   </ItemGroup>
14: 
15:   <ItemGroup>
16:     <PackageReference Include="Volo.Abp.ObjectExtending" Version="9.0.8" />
17:     <PackageReference Include="Volo.Abp.Account.Application.Contracts" Version="9.0.8" />
18:     <PackageReference Include="Volo.Abp.Identity.Application.Contracts" Version="9.0.8" />
19:     <PackageReference Include="Volo.Abp.PermissionManagement.Application.Contracts" Version="9.0.8" />
20:     <PackageReference Include="Volo.Abp.TenantManagement.Application.Contracts" Version="9.0.8" />
21:     <PackageReference Include="Volo.Abp.FeatureManagement.Application.Contracts" Version="9.0.8" />
22:     <PackageReference Include="Volo.Abp.SettingManagement.Application.Contracts" Version="9.0.8" />
23:   </ItemGroup>
24: 
25: </Project>
```

## File: src/Aeq.CoreMvc.Application.Contracts/CoreMvcApplicationContractsModule.cs
```csharp
 1: using Volo.Abp.Account;
 2: using Volo.Abp.FeatureManagement;
 3: using Volo.Abp.Identity;
 4: using Volo.Abp.Modularity;
 5: using Volo.Abp.ObjectExtending;
 6: using Volo.Abp.PermissionManagement;
 7: using Volo.Abp.SettingManagement;
 8: using Volo.Abp.TenantManagement;
 9: namespace Aeq.CoreMvc;
10: [DependsOn(
11:     typeof(CoreMvcDomainSharedModule),
12:     typeof(AbpAccountApplicationContractsModule),
13:     typeof(AbpFeatureManagementApplicationContractsModule),
14:     typeof(AbpIdentityApplicationContractsModule),
15:     typeof(AbpPermissionManagementApplicationContractsModule),
16:     typeof(AbpSettingManagementApplicationContractsModule),
17:     typeof(AbpTenantManagementApplicationContractsModule),
18:     typeof(AbpObjectExtendingModule)
19: )]
20: public class CoreMvcApplicationContractsModule : AbpModule
21: {
22:     public override void PreConfigureServices(ServiceConfigurationContext context)
23:     {
24:         CoreMvcDtoExtensions.Configure();
25:     }
26: }
```

## File: src/Aeq.CoreMvc.Application.Contracts/CoreMvcDtoExtensions.cs
```csharp
 1: using Volo.Abp.Identity;
 2: using Volo.Abp.ObjectExtending;
 3: using Volo.Abp.Threading;
 4: namespace Aeq.CoreMvc;
 5: public static class CoreMvcDtoExtensions
 6: {
 7:     private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();
 8:     public static void Configure()
 9:     {
10:         OneTimeRunner.Run(() =>
11:         {
12:         });
13:     }
14: }
```

## File: src/Aeq.CoreMvc.DbMigrator/Aeq.CoreMvc.DbMigrator.csproj
```
 1: <Project Sdk="Microsoft.NET.Sdk">
 2: 
 3:   <Import Project="..\..\common.props" />
 4: 
 5:   <PropertyGroup>
 6:     <OutputType>Exe</OutputType>
 7:     <TargetFramework>net9.0</TargetFramework>
 8:     <Nullable>enable</Nullable>
 9:   </PropertyGroup>
10: 
11:   <ItemGroup>
12:     <None Remove="appsettings.json" />
13:     <Content Include="appsettings.json">
14:       <CopyToPublishDirectory>PreserveNewest</CopyToPublishDirectory>
15:       <CopyToOutputDirectory>Always</CopyToOutputDirectory>
16:     </Content>
17:     <None Remove="appsettings.secrets.json" />
18:     <Content Include="appsettings.secrets.json">
19:       <CopyToPublishDirectory>PreserveNewest</CopyToPublishDirectory>
20:       <CopyToOutputDirectory>Always</CopyToOutputDirectory>
21:     </Content>
22:   </ItemGroup>
23: 
24:   <ItemGroup>    
25:     <PackageReference Include="Serilog.Extensions.Logging" Version="8.0.0" />
26:     <PackageReference Include="Serilog.Sinks.Async" Version="2.0.0" />
27:     <PackageReference Include="Serilog.Sinks.File" Version="6.0.0" />
28:     <PackageReference Include="Serilog.Sinks.Console" Version="6.0.0" />
29:     <PackageReference Include="Microsoft.Extensions.Hosting" Version="9.0.0" />
30:   </ItemGroup>
31: 
32:   <ItemGroup>
33:     <PackageReference Include="Volo.Abp.Autofac" Version="9.0.8" />
34:     <ProjectReference Include="..\Aeq.CoreMvc.Application.Contracts\Aeq.CoreMvc.Application.Contracts.csproj" />
35:     <ProjectReference Include="..\Aeq.CoreMvc.EntityFrameworkCore\Aeq.CoreMvc.EntityFrameworkCore.csproj" />
36:   </ItemGroup>
37: 
38:   <ItemGroup>
39:     <Compile Remove="Logs\**" />
40:     <Content Remove="Logs\**" />
41:     <EmbeddedResource Remove="Logs\**" />
42:     <None Remove="Logs\**" />
43:   </ItemGroup>
44: 
45: </Project>
```

## File: src/Aeq.CoreMvc.DbMigrator/appsettings.json
```json
 1: {
 2:   "ConnectionStrings": {
 3:     "Default": "Server=localhost;Port=3306;Database=CoreMvc;Uid=root;Pwd=123456a@;"
 4:   },
 5:   "OpenIddict": {
 6:     "Applications": {
 7:       "CoreMvc_Web": {
 8:         "ClientId": "CoreMvc_Web",
 9:         "ClientSecret": "1q2w3e*",
10:         "RootUrl": "https://localhost:44313"
11:       },
12:       "CoreMvc_Swagger": {
13:         "ClientId": "CoreMvc_Swagger",
14:         "RootUrl": "https://localhost:44370"
15:       }
16:     }
17:   }
18: }
```

## File: src/Aeq.CoreMvc.DbMigrator/appsettings.secrets.json
```json
1: {
2: }
```

## File: src/Aeq.CoreMvc.DbMigrator/CoreMvcDbMigratorModule.cs
```csharp
 1: using Aeq.CoreMvc.EntityFrameworkCore;
 2: using Volo.Abp.Autofac;
 3: using Volo.Abp.Modularity;
 4: namespace Aeq.CoreMvc.DbMigrator;
 5: [DependsOn(
 6:     typeof(AbpAutofacModule),
 7:     typeof(CoreMvcEntityFrameworkCoreModule),
 8:     typeof(CoreMvcApplicationContractsModule)
 9:     )]
10: public class CoreMvcDbMigratorModule : AbpModule
11: {
12: }
```

## File: src/Aeq.CoreMvc.DbMigrator/DbMigratorHostedService.cs
```csharp
 1: using System.Threading;
 2: using System.Threading.Tasks;
 3: using Microsoft.Extensions.Configuration;
 4: using Microsoft.Extensions.DependencyInjection;
 5: using Microsoft.Extensions.Hosting;
 6: using Aeq.CoreMvc.Data;
 7: using Serilog;
 8: using Volo.Abp;
 9: using Volo.Abp.Data;
10: namespace Aeq.CoreMvc.DbMigrator;
11: public class DbMigratorHostedService : IHostedService
12: {
13:     private readonly IHostApplicationLifetime _hostApplicationLifetime;
14:     private readonly IConfiguration _configuration;
15:     public DbMigratorHostedService(IHostApplicationLifetime hostApplicationLifetime, IConfiguration configuration)
16:     {
17:         _hostApplicationLifetime = hostApplicationLifetime;
18:         _configuration = configuration;
19:     }
20:     public async Task StartAsync(CancellationToken cancellationToken)
21:     {
22:         using (var application = await AbpApplicationFactory.CreateAsync<CoreMvcDbMigratorModule>(options =>
23:         {
24:            options.Services.ReplaceConfiguration(_configuration);
25:            options.UseAutofac();
26:            options.Services.AddLogging(c => c.AddSerilog());
27:            options.AddDataMigrationEnvironment();
28:         }))
29:         {
30:             await application.InitializeAsync();
31:             await application
32:                 .ServiceProvider
33:                 .GetRequiredService<CoreMvcDbMigrationService>()
34:                 .MigrateAsync();
35:             await application.ShutdownAsync();
36:             _hostApplicationLifetime.StopApplication();
37:         }
38:     }
39:     public Task StopAsync(CancellationToken cancellationToken)
40:     {
41:         return Task.CompletedTask;
42:     }
43: }
```

## File: src/Aeq.CoreMvc.DbMigrator/Program.cs
```csharp
 1: using System.IO;
 2: using System.Threading.Tasks;
 3: using Microsoft.Extensions.Configuration;
 4: using Microsoft.Extensions.DependencyInjection;
 5: using Microsoft.Extensions.Hosting;
 6: using Microsoft.Extensions.Logging;
 7: using Serilog;
 8: using Serilog.Events;
 9: namespace Aeq.CoreMvc.DbMigrator;
10: class Program
11: {
12:     static async Task Main(string[] args)
13:     {
14:         Log.Logger = new LoggerConfiguration()
15:             .MinimumLevel.Information()
16:             .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
17:             .MinimumLevel.Override("Volo.Abp", LogEventLevel.Warning)
18: #if DEBUG
19:                 .MinimumLevel.Override("Aeq.CoreMvc", LogEventLevel.Debug)
20: #else
21:                 .MinimumLevel.Override("Aeq.CoreMvc", LogEventLevel.Information)
22: #endif
23:                 .Enrich.FromLogContext()
24:             .WriteTo.Async(c => c.File("Logs/logs.txt"))
25:             .WriteTo.Async(c => c.Console())
26:             .CreateLogger();
27:         await CreateHostBuilder(args).RunConsoleAsync();
28:     }
29:     public static IHostBuilder CreateHostBuilder(string[] args) =>
30:         Host.CreateDefaultBuilder(args)
31:             .AddAppSettingsSecretsJson()
32:             .ConfigureLogging((context, logging) => logging.ClearProviders())
33:             .ConfigureServices((hostContext, services) =>
34:             {
35:                 services.AddHostedService<DbMigratorHostedService>();
36:             });
37: }
```

## File: src/Aeq.CoreMvc.Domain/Books/Author.cs
```csharp
 1: using System;
 2: using Volo.Abp.Domain.Entities.Auditing;
 3: namespace Aeq.CoreMvc.Books
 4: {
 5:     public class Author : FullAuditedAggregateRoot<Guid>
 6:     {
 7:         public string Name { get; set; }
 8:         public string PhoneNumber { get; set; }
 9:         public string Email { get; set; }
10:     protected Author()
11:     {
12:     }
13:     public Author(
14:         Guid id,
15:         string name,
16:         string phoneNumber,
17:         string email
18:     ) : base(id)
19:     {
20:         Name = name;
21:         PhoneNumber = phoneNumber;
22:         Email = email;
23:     }
24:     }
25: }
```

## File: src/Aeq.CoreMvc.Domain/Books/Book.cs
```csharp
 1: using System;
 2: using Volo.Abp.Domain.Entities.Auditing;
 3: namespace Aeq.CoreMvc.Books
 4: {
 5:     public class Book : FullAuditedAggregateRoot<Guid>
 6:     {
 7:         public string Name { get; set; }
 8:         public string Type { get; set; }
 9:         public string Description { get; set; }
10:         public DateTime PublishDate { get; set; }
11:     protected Book()
12:     {
13:     }
14:     public Book(
15:         Guid id,
16:         string name,
17:         string type,
18:         string description,
19:         DateTime publishDate
20:     ) : base(id)
21:     {
22:         Name = name;
23:         Type = type;
24:         Description = description;
25:         PublishDate = publishDate;
26:     }
27:     }
28: }
```

## File: src/Aeq.CoreMvc.Domain/Books/IAuthorRepository.cs
```csharp
1: using System;
2: using Volo.Abp.Domain.Repositories;
3: namespace Aeq.CoreMvc.Books;
4: public interface IAuthorRepository : IRepository<Author, Guid>
5: {
6: }
```

## File: src/Aeq.CoreMvc.Domain/Books/IBookRepository.cs
```csharp
1: using System;
2: using Volo.Abp.Domain.Repositories;
3: namespace Aeq.CoreMvc.Books;
4: public interface IBookRepository : IRepository<Book, Guid>
5: {
6: }
```

## File: src/Aeq.CoreMvc.Domain/Data/CoreMvcDbMigrationService.cs
```csharp
  1: using System;
  2: using System.Collections.Generic;
  3: using System.Diagnostics;
  4: using System.IO;
  5: using System.Linq;
  6: using System.Runtime.InteropServices;
  7: using System.Threading.Tasks;
  8: using Microsoft.Extensions.Logging;
  9: using Microsoft.Extensions.Logging.Abstractions;
 10: using Volo.Abp.Data;
 11: using Volo.Abp.DependencyInjection;
 12: using Volo.Abp.Identity;
 13: using Volo.Abp.MultiTenancy;
 14: using Volo.Abp.TenantManagement;
 15: namespace Aeq.CoreMvc.Data;
 16: public class CoreMvcDbMigrationService : ITransientDependency
 17: {
 18:     public ILogger<CoreMvcDbMigrationService> Logger { get; set; }
 19:     private readonly IDataSeeder _dataSeeder;
 20:     private readonly IEnumerable<ICoreMvcDbSchemaMigrator> _dbSchemaMigrators;
 21:     private readonly ITenantRepository _tenantRepository;
 22:     private readonly ICurrentTenant _currentTenant;
 23:     public CoreMvcDbMigrationService(
 24:         IDataSeeder dataSeeder,
 25:         IEnumerable<ICoreMvcDbSchemaMigrator> dbSchemaMigrators,
 26:         ITenantRepository tenantRepository,
 27:         ICurrentTenant currentTenant)
 28:     {
 29:         _dataSeeder = dataSeeder;
 30:         _dbSchemaMigrators = dbSchemaMigrators;
 31:         _tenantRepository = tenantRepository;
 32:         _currentTenant = currentTenant;
 33:         Logger = NullLogger<CoreMvcDbMigrationService>.Instance;
 34:     }
 35:     public async Task MigrateAsync()
 36:     {
 37:         var initialMigrationAdded = AddInitialMigrationIfNotExist();
 38:         if (initialMigrationAdded)
 39:         {
 40:             return;
 41:         }
 42:         Logger.LogInformation("Started database migrations...");
 43:         await MigrateDatabaseSchemaAsync();
 44:         await SeedDataAsync();
 45:         Logger.LogInformation($"Successfully completed host database migrations.");
 46:         var tenants = await _tenantRepository.GetListAsync(includeDetails: true);
 47:         var migratedDatabaseSchemas = new HashSet<string>();
 48:         foreach (var tenant in tenants)
 49:         {
 50:             using (_currentTenant.Change(tenant.Id))
 51:             {
 52:                 if (tenant.ConnectionStrings.Any())
 53:                 {
 54:                     var tenantConnectionStrings = tenant.ConnectionStrings
 55:                         .Select(x => x.Value)
 56:                         .ToList();
 57:                     if (!migratedDatabaseSchemas.IsSupersetOf(tenantConnectionStrings))
 58:                     {
 59:                         await MigrateDatabaseSchemaAsync(tenant);
 60:                         migratedDatabaseSchemas.AddIfNotContains(tenantConnectionStrings);
 61:                     }
 62:                 }
 63:                 await SeedDataAsync(tenant);
 64:             }
 65:             Logger.LogInformation($"Successfully completed {tenant.Name} tenant database migrations.");
 66:         }
 67:         Logger.LogInformation("Successfully completed all database migrations.");
 68:         Logger.LogInformation("You can safely end this process...");
 69:     }
 70:     private async Task MigrateDatabaseSchemaAsync(Tenant? tenant = null)
 71:     {
 72:         Logger.LogInformation(
 73:             $"Migrating schema for {(tenant == null ? "host" : tenant.Name + " tenant")} database...");
 74:         foreach (var migrator in _dbSchemaMigrators)
 75:         {
 76:             await migrator.MigrateAsync();
 77:         }
 78:     }
 79:     private async Task SeedDataAsync(Tenant? tenant = null)
 80:     {
 81:         Logger.LogInformation($"Executing {(tenant == null ? "host" : tenant.Name + " tenant")} database seed...");
 82:         await _dataSeeder.SeedAsync(new DataSeedContext(tenant?.Id)
 83:             .WithProperty(IdentityDataSeedContributor.AdminEmailPropertyName, IdentityDataSeedContributor.AdminEmailDefaultValue)
 84:             .WithProperty(IdentityDataSeedContributor.AdminPasswordPropertyName, IdentityDataSeedContributor.AdminPasswordDefaultValue)
 85:         );
 86:     }
 87:     private bool AddInitialMigrationIfNotExist()
 88:     {
 89:         try
 90:         {
 91:             if (!DbMigrationsProjectExists())
 92:             {
 93:                 return false;
 94:             }
 95:         }
 96:         catch (Exception)
 97:         {
 98:             return false;
 99:         }
100:         try
101:         {
102:             if (!MigrationsFolderExists())
103:             {
104:                 AddInitialMigration();
105:                 return true;
106:             }
107:             else
108:             {
109:                 return false;
110:             }
111:         }
112:         catch (Exception e)
113:         {
114:             Logger.LogWarning("Couldn't determinate if any migrations exist : " + e.Message);
115:             return false;
116:         }
117:     }
118:     private bool DbMigrationsProjectExists()
119:     {
120:         var dbMigrationsProjectFolder = GetEntityFrameworkCoreProjectFolderPath();
121:         return dbMigrationsProjectFolder != null;
122:     }
123:     private bool MigrationsFolderExists()
124:     {
125:         var dbMigrationsProjectFolder = GetEntityFrameworkCoreProjectFolderPath();
126:         return dbMigrationsProjectFolder != null && Directory.Exists(Path.Combine(dbMigrationsProjectFolder, "Migrations"));
127:     }
128:     private void AddInitialMigration()
129:     {
130:         Logger.LogInformation("Creating initial migration...");
131:         string argumentPrefix;
132:         string fileName;
133:         if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX) || RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
134:         {
135:             argumentPrefix = "-c";
136:             fileName = "/bin/bash";
137:         }
138:         else
139:         {
140:             argumentPrefix = "/C";
141:             fileName = "cmd.exe";
142:         }
143:         var procStartInfo = new ProcessStartInfo(fileName,
144:             $"{argumentPrefix} \"abp create-migration-and-run-migrator \"{GetEntityFrameworkCoreProjectFolderPath()}\"\""
145:         );
146:         try
147:         {
148:             Process.Start(procStartInfo);
149:         }
150:         catch (Exception)
151:         {
152:             throw new Exception("Couldn't run ABP CLI...");
153:         }
154:     }
155:     private string? GetEntityFrameworkCoreProjectFolderPath()
156:     {
157:         var slnDirectoryPath = GetSolutionDirectoryPath();
158:         if (slnDirectoryPath == null)
159:         {
160:             throw new Exception("Solution folder not found!");
161:         }
162:         var srcDirectoryPath = Path.Combine(slnDirectoryPath, "src");
163:         return Directory.GetDirectories(srcDirectoryPath)
164:             .FirstOrDefault(d => d.EndsWith(".EntityFrameworkCore"));
165:     }
166:     private string? GetSolutionDirectoryPath()
167:     {
168:         var currentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());
169:         while (currentDirectory != null && Directory.GetParent(currentDirectory.FullName) != null)
170:         {
171:             currentDirectory = Directory.GetParent(currentDirectory.FullName);
172:             if (currentDirectory != null && Directory.GetFiles(currentDirectory.FullName).FirstOrDefault(f => f.EndsWith(".sln")) != null)
173:             {
174:                 return currentDirectory.FullName;
175:             }
176:         }
177:         return null;
178:     }
179: }
```

## File: src/Aeq.CoreMvc.Domain/Data/ICoreMvcDbSchemaMigrator.cs
```csharp
1: using System.Threading.Tasks;
2: namespace Aeq.CoreMvc.Data;
3: public interface ICoreMvcDbSchemaMigrator
4: {
5:     Task MigrateAsync();
6: }
```

## File: src/Aeq.CoreMvc.Domain/Data/NullCoreMvcDbSchemaMigrator.cs
```csharp
 1: using System.Threading.Tasks;
 2: using Volo.Abp.DependencyInjection;
 3: namespace Aeq.CoreMvc.Data;
 4: public class NullCoreMvcDbSchemaMigrator : ICoreMvcDbSchemaMigrator, ITransientDependency
 5: {
 6:     public Task MigrateAsync()
 7:     {
 8:         return Task.CompletedTask;
 9:     }
10: }
```

## File: src/Aeq.CoreMvc.Domain/OpenIddict/OpenIddictDataSeedContributor.cs
```csharp
  1: using System;
  2: using System.Collections.Generic;
  3: using System.Linq;
  4: using System.Text.Json;
  5: using System.Threading.Tasks;
  6: using JetBrains.Annotations;
  7: using Microsoft.Extensions.Configuration;
  8: using Microsoft.Extensions.Localization;
  9: using OpenIddict.Abstractions;
 10: using Volo.Abp;
 11: using Volo.Abp.Authorization.Permissions;
 12: using Volo.Abp.Data;
 13: using Volo.Abp.DependencyInjection;
 14: using Volo.Abp.OpenIddict.Applications;
 15: using Volo.Abp.OpenIddict.Scopes;
 16: using Volo.Abp.PermissionManagement;
 17: using Volo.Abp.Uow;
 18: namespace Aeq.CoreMvc.OpenIddict;
 19: public class OpenIddictDataSeedContributor : IDataSeedContributor, ITransientDependency
 20: {
 21:     private readonly IConfiguration _configuration;
 22:     private readonly IOpenIddictApplicationRepository _openIddictApplicationRepository;
 23:     private readonly IAbpApplicationManager _applicationManager;
 24:     private readonly IOpenIddictScopeRepository _openIddictScopeRepository;
 25:     private readonly IOpenIddictScopeManager _scopeManager;
 26:     private readonly IPermissionDataSeeder _permissionDataSeeder;
 27:     private readonly IStringLocalizer<OpenIddictResponse> L;
 28:     public OpenIddictDataSeedContributor(
 29:         IConfiguration configuration,
 30:         IOpenIddictApplicationRepository openIddictApplicationRepository,
 31:         IAbpApplicationManager applicationManager,
 32:         IOpenIddictScopeRepository openIddictScopeRepository,
 33:         IOpenIddictScopeManager scopeManager,
 34:         IPermissionDataSeeder permissionDataSeeder,
 35:         IStringLocalizer<OpenIddictResponse> l )
 36:     {
 37:         _configuration = configuration;
 38:         _openIddictApplicationRepository = openIddictApplicationRepository;
 39:         _applicationManager = applicationManager;
 40:         _openIddictScopeRepository = openIddictScopeRepository;
 41:         _scopeManager = scopeManager;
 42:         _permissionDataSeeder = permissionDataSeeder;
 43:         L = l;
 44:     }
 45:     [UnitOfWork]
 46:     public virtual async Task SeedAsync(DataSeedContext context)
 47:     {
 48:         await CreateScopesAsync();
 49:         await CreateApplicationsAsync();
 50:     }
 51:     private async Task CreateScopesAsync()
 52:     {
 53:         if (await _openIddictScopeRepository.FindByNameAsync("CoreMvc") == null)
 54:         {
 55:             await _scopeManager.CreateAsync(new OpenIddictScopeDescriptor {
 56:                 Name = "CoreMvc", DisplayName = "CoreMvc API", Resources = { "CoreMvc" }
 57:             });
 58:         }
 59:     }
 60:     private async Task CreateApplicationsAsync()
 61:     {
 62:         var commonScopes = new List<string> {
 63:             OpenIddictConstants.Permissions.Scopes.Address,
 64:             OpenIddictConstants.Permissions.Scopes.Email,
 65:             OpenIddictConstants.Permissions.Scopes.Phone,
 66:             OpenIddictConstants.Permissions.Scopes.Profile,
 67:             OpenIddictConstants.Permissions.Scopes.Roles,
 68:             "CoreMvc"
 69:         };
 70:         var configurationSection = _configuration.GetSection("OpenIddict:Applications");
 71:         var webClientId = configurationSection["CoreMvc_Web:ClientId"];
 72:         if (!webClientId.IsNullOrWhiteSpace())
 73:         {
 74:             var webClientRootUrl = configurationSection["CoreMvc_Web:RootUrl"]!.EnsureEndsWith('/');
 75:             await CreateApplicationAsync(
 76:                 name: webClientId!,
 77:                 type: OpenIddictConstants.ClientTypes.Confidential,
 78:                 consentType: OpenIddictConstants.ConsentTypes.Implicit,
 79:                 displayName: "Web Application",
 80:                 secret: configurationSection["CoreMvc_Web:ClientSecret"] ?? "1q2w3e*",
 81:                 grantTypes: new List<string>
 82:                 {
 83:                     OpenIddictConstants.GrantTypes.AuthorizationCode, OpenIddictConstants.GrantTypes.Implicit
 84:                 },
 85:                 scopes: commonScopes,
 86:                 redirectUri: $"{webClientRootUrl}signin-oidc",
 87:                 clientUri: webClientRootUrl,
 88:                 postLogoutRedirectUri: $"{webClientRootUrl}signout-callback-oidc"
 89:             );
 90:         }
 91:         var swaggerClientId = configurationSection["CoreMvc_Swagger:ClientId"];
 92:         if (!swaggerClientId.IsNullOrWhiteSpace())
 93:         {
 94:             var swaggerRootUrl = configurationSection["CoreMvc_Swagger:RootUrl"]?.TrimEnd('/');
 95:             await CreateApplicationAsync(
 96:                 name: swaggerClientId!,
 97:                 type: OpenIddictConstants.ClientTypes.Public,
 98:                 consentType: OpenIddictConstants.ConsentTypes.Implicit,
 99:                 displayName: "Swagger Application",
100:                 secret: null,
101:                 grantTypes: new List<string> { OpenIddictConstants.GrantTypes.AuthorizationCode, },
102:                 scopes: commonScopes,
103:                 redirectUri: $"{swaggerRootUrl}/swagger/oauth2-redirect.html",
104:                 clientUri: swaggerRootUrl
105:             );
106:         }
107:     }
108:     private async Task CreateApplicationAsync(
109:         [NotNull] string name,
110:         [NotNull] string type,
111:         [NotNull] string consentType,
112:         string displayName,
113:         string? secret,
114:         List<string> grantTypes,
115:         List<string> scopes,
116:         string? clientUri = null,
117:         string? redirectUri = null,
118:         string? postLogoutRedirectUri = null,
119:         List<string>? permissions = null)
120:     {
121:         if (!string.IsNullOrEmpty(secret) && string.Equals(type, OpenIddictConstants.ClientTypes.Public,
122:                 StringComparison.OrdinalIgnoreCase))
123:         {
124:             throw new BusinessException(L["NoClientSecretCanBeSetForPublicApplications"]);
125:         }
126:         if (string.IsNullOrEmpty(secret) && string.Equals(type, OpenIddictConstants.ClientTypes.Confidential,
127:                 StringComparison.OrdinalIgnoreCase))
128:         {
129:             throw new BusinessException(L["TheClientSecretIsRequiredForConfidentialApplications"]);
130:         }
131:         var client = await _openIddictApplicationRepository.FindByClientIdAsync(name);
132:         var application = new AbpApplicationDescriptor {
133:             ClientId = name,
134:             ClientType = type,
135:             ClientSecret = secret,
136:             ConsentType = consentType,
137:             DisplayName = displayName,
138:             ClientUri = clientUri,
139:         };
140:         Check.NotNullOrEmpty(grantTypes, nameof(grantTypes));
141:         Check.NotNullOrEmpty(scopes, nameof(scopes));
142:         if (new[] { OpenIddictConstants.GrantTypes.AuthorizationCode, OpenIddictConstants.GrantTypes.Implicit }.All(
143:                 grantTypes.Contains))
144:         {
145:             application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.CodeIdToken);
146:             if (string.Equals(type, OpenIddictConstants.ClientTypes.Public, StringComparison.OrdinalIgnoreCase))
147:             {
148:                 application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.CodeIdTokenToken);
149:                 application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.CodeToken);
150:             }
151:         }
152:         if (!redirectUri.IsNullOrWhiteSpace() || !postLogoutRedirectUri.IsNullOrWhiteSpace())
153:         {
154:             application.Permissions.Add(OpenIddictConstants.Permissions.Endpoints.Logout);
155:         }
156:         var buildInGrantTypes = new[] {
157:             OpenIddictConstants.GrantTypes.Implicit, OpenIddictConstants.GrantTypes.Password,
158:             OpenIddictConstants.GrantTypes.AuthorizationCode, OpenIddictConstants.GrantTypes.ClientCredentials,
159:             OpenIddictConstants.GrantTypes.DeviceCode, OpenIddictConstants.GrantTypes.RefreshToken
160:         };
161:         foreach (var grantType in grantTypes)
162:         {
163:             if (grantType == OpenIddictConstants.GrantTypes.AuthorizationCode)
164:             {
165:                 application.Permissions.Add(OpenIddictConstants.Permissions.GrantTypes.AuthorizationCode);
166:                 application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.Code);
167:             }
168:             if (grantType == OpenIddictConstants.GrantTypes.AuthorizationCode ||
169:                 grantType == OpenIddictConstants.GrantTypes.Implicit)
170:             {
171:                 application.Permissions.Add(OpenIddictConstants.Permissions.Endpoints.Authorization);
172:             }
173:             if (grantType == OpenIddictConstants.GrantTypes.AuthorizationCode ||
174:                 grantType == OpenIddictConstants.GrantTypes.ClientCredentials ||
175:                 grantType == OpenIddictConstants.GrantTypes.Password ||
176:                 grantType == OpenIddictConstants.GrantTypes.RefreshToken ||
177:                 grantType == OpenIddictConstants.GrantTypes.DeviceCode)
178:             {
179:                 application.Permissions.Add(OpenIddictConstants.Permissions.Endpoints.Token);
180:                 application.Permissions.Add(OpenIddictConstants.Permissions.Endpoints.Revocation);
181:                 application.Permissions.Add(OpenIddictConstants.Permissions.Endpoints.Introspection);
182:             }
183:             if (grantType == OpenIddictConstants.GrantTypes.ClientCredentials)
184:             {
185:                 application.Permissions.Add(OpenIddictConstants.Permissions.GrantTypes.ClientCredentials);
186:             }
187:             if (grantType == OpenIddictConstants.GrantTypes.Implicit)
188:             {
189:                 application.Permissions.Add(OpenIddictConstants.Permissions.GrantTypes.Implicit);
190:             }
191:             if (grantType == OpenIddictConstants.GrantTypes.Password)
192:             {
193:                 application.Permissions.Add(OpenIddictConstants.Permissions.GrantTypes.Password);
194:             }
195:             if (grantType == OpenIddictConstants.GrantTypes.RefreshToken)
196:             {
197:                 application.Permissions.Add(OpenIddictConstants.Permissions.GrantTypes.RefreshToken);
198:             }
199:             if (grantType == OpenIddictConstants.GrantTypes.DeviceCode)
200:             {
201:                 application.Permissions.Add(OpenIddictConstants.Permissions.GrantTypes.DeviceCode);
202:                 application.Permissions.Add(OpenIddictConstants.Permissions.Endpoints.Device);
203:             }
204:             if (grantType == OpenIddictConstants.GrantTypes.Implicit)
205:             {
206:                 application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.IdToken);
207:                 if (string.Equals(type, OpenIddictConstants.ClientTypes.Public, StringComparison.OrdinalIgnoreCase))
208:                 {
209:                     application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.IdTokenToken);
210:                     application.Permissions.Add(OpenIddictConstants.Permissions.ResponseTypes.Token);
211:                 }
212:             }
213:             if (!buildInGrantTypes.Contains(grantType))
214:             {
215:                 application.Permissions.Add(OpenIddictConstants.Permissions.Prefixes.GrantType + grantType);
216:             }
217:         }
218:         var buildInScopes = new[] {
219:             OpenIddictConstants.Permissions.Scopes.Address, OpenIddictConstants.Permissions.Scopes.Email,
220:             OpenIddictConstants.Permissions.Scopes.Phone, OpenIddictConstants.Permissions.Scopes.Profile,
221:             OpenIddictConstants.Permissions.Scopes.Roles
222:         };
223:         foreach (var scope in scopes)
224:         {
225:             if (buildInScopes.Contains(scope))
226:             {
227:                 application.Permissions.Add(scope);
228:             }
229:             else
230:             {
231:                 application.Permissions.Add(OpenIddictConstants.Permissions.Prefixes.Scope + scope);
232:             }
233:         }
234:         if (redirectUri != null)
235:         {
236:             if (!redirectUri.IsNullOrEmpty())
237:             {
238:                 if (!Uri.TryCreate(redirectUri, UriKind.Absolute, out var uri) || !uri.IsWellFormedOriginalString())
239:                 {
240:                     throw new BusinessException(L["InvalidRedirectUri", redirectUri]);
241:                 }
242:                 if (application.RedirectUris.All(x => x != uri))
243:                 {
244:                     application.RedirectUris.Add(uri);
245:                 }
246:             }
247:         }
248:         if (postLogoutRedirectUri != null)
249:         {
250:             if (!postLogoutRedirectUri.IsNullOrEmpty())
251:             {
252:                 if (!Uri.TryCreate(postLogoutRedirectUri, UriKind.Absolute, out var uri) ||
253:                     !uri.IsWellFormedOriginalString())
254:                 {
255:                     throw new BusinessException(L["InvalidPostLogoutRedirectUri", postLogoutRedirectUri]);
256:                 }
257:                 if (application.PostLogoutRedirectUris.All(x => x != uri))
258:                 {
259:                     application.PostLogoutRedirectUris.Add(uri);
260:                 }
261:             }
262:         }
263:         if (permissions != null)
264:         {
265:             await _permissionDataSeeder.SeedAsync(
266:                 ClientPermissionValueProvider.ProviderName,
267:                 name,
268:                 permissions,
269:                 null
270:             );
271:         }
272:         if (client == null)
273:         {
274:             await _applicationManager.CreateAsync(application);
275:             return;
276:         }
277:         if (!HasSameRedirectUris(client, application))
278:         {
279:             client.RedirectUris = JsonSerializer.Serialize(application.RedirectUris.Select(q => q.ToString().TrimEnd('/')));
280:             client.PostLogoutRedirectUris = JsonSerializer.Serialize(application.PostLogoutRedirectUris.Select(q => q.ToString().TrimEnd('/')));
281:             await _applicationManager.UpdateAsync(client.ToModel());
282:         }
283:         if (!HasSameScopes(client, application))
284:         {
285:             client.Permissions = JsonSerializer.Serialize(application.Permissions.Select(q => q.ToString()));
286:             await _applicationManager.UpdateAsync(client.ToModel());
287:         }
288:     }
289:     private bool HasSameRedirectUris(OpenIddictApplication existingClient, AbpApplicationDescriptor application)
290:     {
291:         return existingClient.RedirectUris == JsonSerializer.Serialize(application.RedirectUris.Select(q => q.ToString().TrimEnd('/')));
292:     }
293:     private bool HasSameScopes(OpenIddictApplication existingClient, AbpApplicationDescriptor application)
294:     {
295:         return existingClient.Permissions == JsonSerializer.Serialize(application.Permissions.Select(q => q.ToString().TrimEnd('/')));
296:     }
297: }
```

## File: src/Aeq.CoreMvc.Domain/Properties/AssemblyInfo.cs
```csharp
1: using System.Runtime.CompilerServices;
2: [assembly:InternalsVisibleToAttribute("Aeq.CoreMvc.Domain.Tests")]
3: [assembly:InternalsVisibleToAttribute("Aeq.CoreMvc.TestBase")]
```

## File: src/Aeq.CoreMvc.Domain/Settings/CoreMvcSettingDefinitionProvider.cs
```csharp
1: using Volo.Abp.Settings;
2: namespace Aeq.CoreMvc.Settings;
3: public class CoreMvcSettingDefinitionProvider : SettingDefinitionProvider
4: {
5:     public override void Define(ISettingDefinitionContext context)
6:     {
7:     }
8: }
```

## File: src/Aeq.CoreMvc.Domain/Settings/CoreMvcSettings.cs
```csharp
1: namespace Aeq.CoreMvc.Settings;
2: public static class CoreMvcSettings
3: {
4:     private const string Prefix = "CoreMvc";
5: }
```

## File: src/Aeq.CoreMvc.Domain/Aeq.CoreMvc.Domain.csproj
```
 1: <Project Sdk="Microsoft.NET.Sdk">
 2: 
 3:   <Import Project="..\..\common.props" />
 4: 
 5:   <PropertyGroup>
 6:     <TargetFramework>net9.0</TargetFramework>
 7:     <Nullable>enable</Nullable>
 8:     <RootNamespace>Aeq.CoreMvc</RootNamespace>
 9:   </PropertyGroup>
10: 
11:   <ItemGroup>
12:     <ProjectReference Include="..\Aeq.CoreMvc.Domain.Shared\Aeq.CoreMvc.Domain.Shared.csproj" />
13:   </ItemGroup>
14: 
15:   <ItemGroup>
16:     <PackageReference Include="Volo.Abp.Emailing" Version="9.0.8" />
17:     <PackageReference Include="Volo.Abp.Identity.Domain" Version="9.0.8" />
18:     <PackageReference Include="Volo.Abp.PermissionManagement.Domain.Identity" Version="9.0.8" />
19:     <PackageReference Include="Volo.Abp.BackgroundJobs.Domain" Version="9.0.8" />
20:     <PackageReference Include="Volo.Abp.AuditLogging.Domain" Version="9.0.8" />
21:     <PackageReference Include="Volo.Abp.TenantManagement.Domain" Version="9.0.8" />
22:     <PackageReference Include="Volo.Abp.FeatureManagement.Domain" Version="9.0.8" />
23:     <PackageReference Include="Volo.Abp.SettingManagement.Domain" Version="9.0.8" />
24:     <PackageReference Include="Volo.Abp.OpenIddict.Domain" Version="9.0.8" />
25:     <PackageReference Include="Volo.Abp.PermissionManagement.Domain.OpenIddict" Version="9.0.8" />
26:   </ItemGroup>
27: 
28: </Project>
```

## File: src/Aeq.CoreMvc.Domain/CoreMvcConsts.cs
```csharp
1: namespace Aeq.CoreMvc;
2: public static class CoreMvcConsts
3: {
4:     public const string DbTablePrefix = "App";
5:     public const string DbSchema = null;
6: }
```

## File: src/Aeq.CoreMvc.Domain/CoreMvcDomainModule.cs
```csharp
 1: using Microsoft.Extensions.DependencyInjection;
 2: using Microsoft.Extensions.DependencyInjection.Extensions;
 3: using Aeq.CoreMvc.MultiTenancy;
 4: using Volo.Abp.AuditLogging;
 5: using Volo.Abp.BackgroundJobs;
 6: using Volo.Abp.Emailing;
 7: using Volo.Abp.FeatureManagement;
 8: using Volo.Abp.Identity;
 9: using Volo.Abp.Localization;
10: using Volo.Abp.Modularity;
11: using Volo.Abp.MultiTenancy;
12: using Volo.Abp.OpenIddict;
13: using Volo.Abp.PermissionManagement.Identity;
14: using Volo.Abp.PermissionManagement.OpenIddict;
15: using Volo.Abp.SettingManagement;
16: using Volo.Abp.TenantManagement;
17: namespace Aeq.CoreMvc;
18: [DependsOn(
19:     typeof(CoreMvcDomainSharedModule),
20:     typeof(AbpAuditLoggingDomainModule),
21:     typeof(AbpBackgroundJobsDomainModule),
22:     typeof(AbpFeatureManagementDomainModule),
23:     typeof(AbpIdentityDomainModule),
24:     typeof(AbpOpenIddictDomainModule),
25:     typeof(AbpPermissionManagementDomainOpenIddictModule),
26:     typeof(AbpPermissionManagementDomainIdentityModule),
27:     typeof(AbpSettingManagementDomainModule),
28:     typeof(AbpTenantManagementDomainModule),
29:     typeof(AbpEmailingModule)
30: )]
31: public class CoreMvcDomainModule : AbpModule
32: {
33:     public override void ConfigureServices(ServiceConfigurationContext context)
34:     {
35:         Configure<AbpLocalizationOptions>(options =>
36:         {
37:             options.Languages.Add(new LanguageInfo("ar", "ar", "العربية"));
38:             options.Languages.Add(new LanguageInfo("cs", "cs", "Čeština"));
39:             options.Languages.Add(new LanguageInfo("en", "en", "English"));
40:             options.Languages.Add(new LanguageInfo("en-GB", "en-GB", "English (UK)"));
41:             options.Languages.Add(new LanguageInfo("hu", "hu", "Magyar"));
42:             options.Languages.Add(new LanguageInfo("hr", "hr", "Croatian"));
43:             options.Languages.Add(new LanguageInfo("fi", "fi", "Finnish"));
44:             options.Languages.Add(new LanguageInfo("fr", "fr", "Français"));
45:             options.Languages.Add(new LanguageInfo("hi", "hi", "Hindi"));
46:             options.Languages.Add(new LanguageInfo("it", "it", "Italiano"));
47:             options.Languages.Add(new LanguageInfo("pt-BR", "pt-BR", "Português"));
48:             options.Languages.Add(new LanguageInfo("ru", "ru", "Русский"));
49:             options.Languages.Add(new LanguageInfo("sk", "sk", "Slovak"));
50:             options.Languages.Add(new LanguageInfo("tr", "tr", "Türkçe"));
51:             options.Languages.Add(new LanguageInfo("zh-Hans", "zh-Hans", "简体中文"));
52:             options.Languages.Add(new LanguageInfo("zh-Hant", "zh-Hant", "繁體中文"));
53:             options.Languages.Add(new LanguageInfo("de-DE", "de-DE", "Deutsch"));
54:             options.Languages.Add(new LanguageInfo("es", "es", "Español"));
55:         });
56:         Configure<AbpMultiTenancyOptions>(options =>
57:         {
58:             options.IsEnabled = MultiTenancyConsts.IsEnabled;
59:         });
60: #if DEBUG
61:         context.Services.Replace(ServiceDescriptor.Singleton<IEmailSender, NullEmailSender>());
62: #endif
63:     }
64: }
```

## File: src/Aeq.CoreMvc.Domain.Shared/Localization/CoreMvc/en-GB.json
```json
 1: {
 2:   "culture": "en-GB",
 3:   "texts": {
 4:     "AppName": "CoreMvc",
 5:     "Menu:Home": "Home",
 6:     "Welcome": "Welcome",
 7:     "LongWelcomeMessage": "Welcome to the application. This is a startup project based on the ABP framework. For more information, visit abp.io.",
 8:     "Permission:Book": "Book",
 9:     "Permission:Create": "Create",
10:     "Permission:Update": "Update",
11:     "Permission:Delete": "Delete",
12:     "Menu:Book": "MenuBook",
13:     "Book": "Book",
14:     "BookName": "BookName",
15:     "BookType": "BookType",
16:     "BookDescription": "BookDescription",
17:     "BookPublishDate": "BookPublishDate",
18:     "CreateBook": "CreateBook",
19:     "EditBook": "EditBook",
20:     "BookDeletionConfirmationMessage": "Are you sure to delete the book {0}?",
21:     "SuccessfullyDeleted": "Successfully deleted",
22:     "TableFilter": "TableFilter",
23:     "Permission:Author": "Author",
24:     "Menu:Author": "MenuAuthor",
25:     "Author": "Author",
26:     "AuthorName": "AuthorName",
27:     "AuthorPhoneNumber": "AuthorPhoneNumber",
28:     "AuthorEmail": "AuthorEmail",
29:     "CreateAuthor": "CreateAuthor",
30:     "EditAuthor": "EditAuthor",
31:     "AuthorDeletionConfirmationMessage": "Are you sure to delete the author {0}?"
32:   }
33: }
```

## File: src/Aeq.CoreMvc.Domain.Shared/Localization/CoreMvc/en.json
```json
 1: {
 2:   "culture": "en",
 3:   "texts": {
 4:     "AppName": "CoreMvc",
 5:     "Menu:Home": "Home",
 6:     "Welcome": "Welcome",
 7:     "LongWelcomeMessage": "Welcome to the application. This is a startup project based on the ABP framework. For more information, visit abp.io.",
 8:     "Permission:Book": "Book",
 9:     "Permission:Create": "Create",
10:     "Permission:Update": "Update",
11:     "Permission:Delete": "Delete",
12:     "Menu:Book": "MenuBook",
13:     "Book": "Book",
14:     "BookName": "BookName",
15:     "BookType": "BookType",
16:     "BookDescription": "BookDescription",
17:     "BookPublishDate": "BookPublishDate",
18:     "CreateBook": "CreateBook",
19:     "EditBook": "EditBook",
20:     "BookDeletionConfirmationMessage": "Are you sure to delete the book {0}?",
21:     "SuccessfullyDeleted": "Successfully deleted",
22:     "TableFilter": "TableFilter",
23:     "Permission:Author": "Author",
24:     "Menu:Author": "MenuAuthor",
25:     "Author": "Author",
26:     "AuthorName": "AuthorName",
27:     "AuthorPhoneNumber": "AuthorPhoneNumber",
28:     "AuthorEmail": "AuthorEmail",
29:     "CreateAuthor": "CreateAuthor",
30:     "EditAuthor": "EditAuthor",
31:     "AuthorDeletionConfirmationMessage": "Are you sure to delete the author {0}?"
32:   }
33: }
```

## File: src/Aeq.CoreMvc.Domain.Shared/Localization/CoreMvc/vi.json
```json
 1: {
 2:   "culture": "vi",
 3:   "texts": {
 4:     "AppName": "CoreMvc",
 5:     "Menu:Home": "Trang chủ",
 6:     "Welcome": "Chào mừng bạn",
 7:     "LongWelcomeMessage": "Chào mừng bạn đến ứng dụng. Đây là một dự án khởi nghiệp dựa trên khung ABP. Để biết thêm thông tin, hãy truy cập abp.io.",
 8:     "Permission:Book": "Book",
 9:     "Permission:Create": "Create",
10:     "Permission:Update": "Update",
11:     "Permission:Delete": "Delete",
12:     "Menu:Book": "MenuBook",
13:     "Book": "Book",
14:     "BookName": "BookName",
15:     "BookType": "BookType",
16:     "BookDescription": "BookDescription",
17:     "BookPublishDate": "BookPublishDate",
18:     "CreateBook": "CreateBook",
19:     "EditBook": "EditBook",
20:     "BookDeletionConfirmationMessage": "Are you sure to delete the book {0}?",
21:     "SuccessfullyDeleted": "Successfully deleted",
22:     "TableFilter": "TableFilter",
23:     "Permission:Author": "Author",
24:     "Menu:Author": "MenuAuthor",
25:     "Author": "Author",
26:     "AuthorName": "AuthorName",
27:     "AuthorPhoneNumber": "AuthorPhoneNumber",
28:     "AuthorEmail": "AuthorEmail",
29:     "CreateAuthor": "CreateAuthor",
30:     "EditAuthor": "EditAuthor",
31:     "AuthorDeletionConfirmationMessage": "Are you sure to delete the author {0}?"
32:   }
33: }
```

## File: src/Aeq.CoreMvc.Domain.Shared/Localization/CoreMvc/zh-Hans.json
```json
 1: {
 2:   "culture": "zh-Hans",
 3:   "texts": {
 4:     "AppName": "CoreMvc",
 5:     "Menu:Home": "首页",
 6:     "Welcome": "欢迎",
 7:     "LongWelcomeMessage": "欢迎使用本应用程序。这是一个基于 ABP 框架的启动项目。更多信息，请访问 abp.io。",
 8:     "Permission:Book": "Book",
 9:     "Permission:Create": "Create",
10:     "Permission:Update": "Update",
11:     "Permission:Delete": "Delete",
12:     "Menu:Book": "MenuBook",
13:     "Book": "Book",
14:     "BookName": "BookName",
15:     "BookType": "BookType",
16:     "BookDescription": "BookDescription",
17:     "BookPublishDate": "BookPublishDate",
18:     "CreateBook": "CreateBook",
19:     "EditBook": "EditBook",
20:     "BookDeletionConfirmationMessage": "Are you sure to delete the book {0}?",
21:     "SuccessfullyDeleted": "Successfully deleted",
22:     "TableFilter": "TableFilter",
23:     "Permission:Author": "Author",
24:     "Menu:Author": "MenuAuthor",
25:     "Author": "Author",
26:     "AuthorName": "AuthorName",
27:     "AuthorPhoneNumber": "AuthorPhoneNumber",
28:     "AuthorEmail": "AuthorEmail",
29:     "CreateAuthor": "CreateAuthor",
30:     "EditAuthor": "EditAuthor",
31:     "AuthorDeletionConfirmationMessage": "Are you sure to delete the author {0}?"
32:   }
33: }
```

## File: src/Aeq.CoreMvc.Domain.Shared/Localization/CoreMvc/zh-Hant.json
```json
 1: {
 2:   "culture": "zh-Hant",
 3:   "texts": {
 4:     "AppName": "CoreMvc",
 5:     "Menu:Home": "首頁",
 6:     "Welcome": "歡迎",
 7:     "LongWelcomeMessage": "歡迎來到此應用程式. 這是一個基於ABP框架的起始專案. 有關更多訊息, 請瀏覽 abp.io.",
 8:     "Permission:Book": "Book",
 9:     "Permission:Create": "Create",
10:     "Permission:Update": "Update",
11:     "Permission:Delete": "Delete",
12:     "Menu:Book": "MenuBook",
13:     "Book": "Book",
14:     "BookName": "BookName",
15:     "BookType": "BookType",
16:     "BookDescription": "BookDescription",
17:     "BookPublishDate": "BookPublishDate",
18:     "CreateBook": "CreateBook",
19:     "EditBook": "EditBook",
20:     "BookDeletionConfirmationMessage": "Are you sure to delete the book {0}?",
21:     "SuccessfullyDeleted": "Successfully deleted",
22:     "TableFilter": "TableFilter",
23:     "Permission:Author": "Author",
24:     "Menu:Author": "MenuAuthor",
25:     "Author": "Author",
26:     "AuthorName": "AuthorName",
27:     "AuthorPhoneNumber": "AuthorPhoneNumber",
28:     "AuthorEmail": "AuthorEmail",
29:     "CreateAuthor": "CreateAuthor",
30:     "EditAuthor": "EditAuthor",
31:     "AuthorDeletionConfirmationMessage": "Are you sure to delete the author {0}?"
32:   }
33: }
```

## File: src/Aeq.CoreMvc.Domain.Shared/Localization/CoreMvcResource.cs
```csharp
1: using Volo.Abp.Localization;
2: namespace Aeq.CoreMvc.Localization;
3: [LocalizationResourceName("CoreMvc")]
4: public class CoreMvcResource
5: {
6: }
```

## File: src/Aeq.CoreMvc.Domain.Shared/MultiTenancy/MultiTenancyConsts.cs
```csharp
1: namespace Aeq.CoreMvc.MultiTenancy;
2: public static class MultiTenancyConsts
3: {
4:     public const bool IsEnabled = true;
5: }
```

## File: src/Aeq.CoreMvc.Domain.Shared/Aeq.CoreMvc.Domain.Shared.csproj
```
 1: <Project Sdk="Microsoft.NET.Sdk">
 2: 
 3:   <Import Project="..\..\common.props" />
 4: 
 5:   <PropertyGroup>
 6:     <TargetFramework>net9.0</TargetFramework>
 7:     <Nullable>enable</Nullable>
 8:     <RootNamespace>Aeq.CoreMvc</RootNamespace>
 9:     <GenerateEmbeddedFilesManifest>true</GenerateEmbeddedFilesManifest>
10:   </PropertyGroup>
11: 
12:   <ItemGroup>
13:     <PackageReference Include="Volo.Abp.Identity.Domain.Shared" Version="9.0.8" />
14:     <PackageReference Include="Volo.Abp.BackgroundJobs.Domain.Shared" Version="9.0.8" />
15:     <PackageReference Include="Volo.Abp.AuditLogging.Domain.Shared" Version="9.0.8" />
16:     <PackageReference Include="Volo.Abp.TenantManagement.Domain.Shared" Version="9.0.8" />
17:     <PackageReference Include="Volo.Abp.FeatureManagement.Domain.Shared" Version="9.0.8" />
18:     <PackageReference Include="Volo.Abp.PermissionManagement.Domain.Shared" Version="9.0.8" />
19:     <PackageReference Include="Volo.Abp.SettingManagement.Domain.Shared" Version="9.0.8" />
20:     <PackageReference Include="Volo.Abp.OpenIddict.Domain.Shared" Version="9.0.8" />
21:   </ItemGroup>
22: 
23:   <ItemGroup>
24:     <EmbeddedResource Include="Localization\CoreMvc\*.json" />
25:     <Content Remove="Localization\CoreMvc\*.json" />
26:   </ItemGroup>
27: 
28:   <ItemGroup>
29:     <PackageReference Include="Microsoft.Extensions.FileProviders.Embedded" Version="9.0.0" />
30:   </ItemGroup>
31: 
32: </Project>
```

## File: src/Aeq.CoreMvc.Domain.Shared/CoreMvcDomainErrorCodes.cs
```csharp
1: namespace Aeq.CoreMvc;
2: public static class CoreMvcDomainErrorCodes
3: {
4: }
```

## File: src/Aeq.CoreMvc.Domain.Shared/CoreMvcDomainSharedModule.cs
```csharp
 1: using Aeq.CoreMvc.Localization;
 2: using Volo.Abp.AuditLogging;
 3: using Volo.Abp.BackgroundJobs;
 4: using Volo.Abp.FeatureManagement;
 5: using Volo.Abp.Identity;
 6: using Volo.Abp.Localization;
 7: using Volo.Abp.Localization.ExceptionHandling;
 8: using Volo.Abp.Modularity;
 9: using Volo.Abp.OpenIddict;
10: using Volo.Abp.PermissionManagement;
11: using Volo.Abp.SettingManagement;
12: using Volo.Abp.TenantManagement;
13: using Volo.Abp.Validation.Localization;
14: using Volo.Abp.VirtualFileSystem;
15: namespace Aeq.CoreMvc;
16: [DependsOn(
17:     typeof(AbpAuditLoggingDomainSharedModule),
18:     typeof(AbpBackgroundJobsDomainSharedModule),
19:     typeof(AbpFeatureManagementDomainSharedModule),
20:     typeof(AbpIdentityDomainSharedModule),
21:     typeof(AbpOpenIddictDomainSharedModule),
22:     typeof(AbpPermissionManagementDomainSharedModule),
23:     typeof(AbpSettingManagementDomainSharedModule),
24:     typeof(AbpTenantManagementDomainSharedModule)
25:     )]
26: public class CoreMvcDomainSharedModule : AbpModule
27: {
28:     public override void PreConfigureServices(ServiceConfigurationContext context)
29:     {
30:         CoreMvcGlobalFeatureConfigurator.Configure();
31:         CoreMvcModuleExtensionConfigurator.Configure();
32:     }
33:     public override void ConfigureServices(ServiceConfigurationContext context)
34:     {
35:         Configure<AbpVirtualFileSystemOptions>(options =>
36:         {
37:             options.FileSets.AddEmbedded<CoreMvcDomainSharedModule>();
38:         });
39:         Configure<AbpLocalizationOptions>(options =>
40:         {
41:             options.Resources
42:                 .Add<CoreMvcResource>("en")
43:                 .AddBaseTypes(typeof(AbpValidationResource))
44:                 .AddVirtualJson("/Localization/CoreMvc");
45:             options.DefaultResourceType = typeof(CoreMvcResource);
46:         });
47:         Configure<AbpExceptionLocalizationOptions>(options =>
48:         {
49:             options.MapCodeNamespace("CoreMvc", typeof(CoreMvcResource));
50:         });
51:     }
52: }
```

## File: src/Aeq.CoreMvc.Domain.Shared/CoreMvcGlobalFeatureConfigurator.cs
```csharp
 1: using Volo.Abp.Threading;
 2: namespace Aeq.CoreMvc;
 3: public static class CoreMvcGlobalFeatureConfigurator
 4: {
 5:     private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();
 6:     public static void Configure()
 7:     {
 8:         OneTimeRunner.Run(() =>
 9:         {
10:         });
11:     }
12: }
```

## File: src/Aeq.CoreMvc.Domain.Shared/CoreMvcModuleExtensionConfigurator.cs
```csharp
 1: using System.ComponentModel.DataAnnotations;
 2: using Volo.Abp.Identity;
 3: using Volo.Abp.ObjectExtending;
 4: using Volo.Abp.Threading;
 5: namespace Aeq.CoreMvc;
 6: public static class CoreMvcModuleExtensionConfigurator
 7: {
 8:     private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();
 9:     public static void Configure()
10:     {
11:         OneTimeRunner.Run(() =>
12:         {
13:             ConfigureExistingProperties();
14:             ConfigureExtraProperties();
15:         });
16:     }
17:     private static void ConfigureExistingProperties()
18:     {
19:     }
20:     private static void ConfigureExtraProperties()
21:     {
22:     }
23: }
```

## File: src/Aeq.CoreMvc.EntityFrameworkCore/Books/AuthorEfCoreQueryableExtensions.cs
```csharp
 1: using System.Linq;
 2: using Microsoft.EntityFrameworkCore;
 3: namespace Aeq.CoreMvc.Books;
 4: public static class AuthorEfCoreQueryableExtensions
 5: {
 6:     public static IQueryable<Author> IncludeDetails(this IQueryable<Author> queryable, bool include = true)
 7:     {
 8:         if (!include)
 9:         {
10:             return queryable;
11:         }
12:         return queryable
13:             ;
14:     }
15: }
```

## File: src/Aeq.CoreMvc.EntityFrameworkCore/Books/AuthorRepository.cs
```csharp
 1: using System;
 2: using System.Linq;
 3: using System.Threading.Tasks;
 4: using Aeq.CoreMvc.EntityFrameworkCore;
 5: using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
 6: using Volo.Abp.EntityFrameworkCore;
 7: namespace Aeq.CoreMvc.Books;
 8: public class AuthorRepository : EfCoreRepository<CoreMvcDbContext, Author, Guid>, IAuthorRepository
 9: {
10:     public AuthorRepository(IDbContextProvider<CoreMvcDbContext> dbContextProvider) : base(dbContextProvider)
11:     {
12:     }
13:     public override async Task<IQueryable<Author>> WithDetailsAsync()
14:     {
15:         return (await GetQueryableAsync()).IncludeDetails();
16:     }
17: }
```

## File: src/Aeq.CoreMvc.EntityFrameworkCore/Books/BookEfCoreQueryableExtensions.cs
```csharp
 1: using System.Linq;
 2: using Microsoft.EntityFrameworkCore;
 3: namespace Aeq.CoreMvc.Books;
 4: public static class BookEfCoreQueryableExtensions
 5: {
 6:     public static IQueryable<Book> IncludeDetails(this IQueryable<Book> queryable, bool include = true)
 7:     {
 8:         if (!include)
 9:         {
10:             return queryable;
11:         }
12:         return queryable
13:             ;
14:     }
15: }
```

## File: src/Aeq.CoreMvc.EntityFrameworkCore/Books/BookRepository.cs
```csharp
 1: using System;
 2: using System.Linq;
 3: using System.Threading.Tasks;
 4: using Aeq.CoreMvc.EntityFrameworkCore;
 5: using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
 6: using Volo.Abp.EntityFrameworkCore;
 7: namespace Aeq.CoreMvc.Books;
 8: public class BookRepository : EfCoreRepository<CoreMvcDbContext, Book, Guid>, IBookRepository
 9: {
10:     public BookRepository(IDbContextProvider<CoreMvcDbContext> dbContextProvider) : base(dbContextProvider)
11:     {
12:     }
13:     public override async Task<IQueryable<Book>> WithDetailsAsync()
14:     {
15:         return (await GetQueryableAsync()).IncludeDetails();
16:     }
17: }
```

## File: src/Aeq.CoreMvc.EntityFrameworkCore/EntityFrameworkCore/CoreMvcDbContext.cs
```csharp
 1: using Microsoft.EntityFrameworkCore;
 2: using Volo.Abp.AuditLogging.EntityFrameworkCore;
 3: using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
 4: using Volo.Abp.Data;
 5: using Volo.Abp.DependencyInjection;
 6: using Volo.Abp.EntityFrameworkCore;
 7: using Volo.Abp.FeatureManagement.EntityFrameworkCore;
 8: using Volo.Abp.Identity;
 9: using Volo.Abp.Identity.EntityFrameworkCore;
10: using Volo.Abp.OpenIddict.EntityFrameworkCore;
11: using Volo.Abp.PermissionManagement.EntityFrameworkCore;
12: using Volo.Abp.SettingManagement.EntityFrameworkCore;
13: using Volo.Abp.TenantManagement;
14: using Volo.Abp.TenantManagement.EntityFrameworkCore;
15: using Aeq.CoreMvc.Books;
16: using Volo.Abp.EntityFrameworkCore.Modeling;
17: namespace Aeq.CoreMvc.EntityFrameworkCore;
18: [ReplaceDbContext(typeof(IIdentityDbContext))]
19: [ReplaceDbContext(typeof(ITenantManagementDbContext))]
20: [ConnectionStringName("Default")]
21: public class CoreMvcDbContext :
22:     AbpDbContext<CoreMvcDbContext>,
23:     IIdentityDbContext,
24:     ITenantManagementDbContext
25: {
26:     #region Entities from the modules
27:     public DbSet<IdentityUser> Users { get; set; }
28:     public DbSet<IdentityRole> Roles { get; set; }
29:     public DbSet<IdentityClaimType> ClaimTypes { get; set; }
30:     public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
31:     public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
32:     public DbSet<IdentityLinkUser> LinkUsers { get; set; }
33:     public DbSet<IdentityUserDelegation> UserDelegations { get; set; }
34:     public DbSet<IdentitySession> Sessions { get; set; }
35:     public DbSet<Tenant> Tenants { get; set; }
36:     public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }
37:     #endregion
38:     public DbSet<Book> Books { get; set; }
39:     public DbSet<Author> Authors { get; set; }
40:     public CoreMvcDbContext(DbContextOptions<CoreMvcDbContext> options)
41:         : base(options)
42:     {
43:     }
44:     protected override void OnModelCreating(ModelBuilder builder)
45:     {
46:         base.OnModelCreating(builder);
47:         builder.ConfigurePermissionManagement();
48:         builder.ConfigureSettingManagement();
49:         builder.ConfigureBackgroundJobs();
50:         builder.ConfigureAuditLogging();
51:         builder.ConfigureIdentity();
52:         builder.ConfigureOpenIddict();
53:         builder.ConfigureFeatureManagement();
54:         builder.ConfigureTenantManagement();
55:         builder.Entity<Book>(b =>
56:         {
57:             b.ToTable(CoreMvcConsts.DbTablePrefix + "Books", CoreMvcConsts.DbSchema);
58:             b.ConfigureByConvention();
59:         });
60:         builder.Entity<Author>(b =>
61:         {
62:             b.ToTable(CoreMvcConsts.DbTablePrefix + "Authors", CoreMvcConsts.DbSchema);
63:             b.ConfigureByConvention();
64:         });
65:     }
66: }
```

## File: src/Aeq.CoreMvc.EntityFrameworkCore/EntityFrameworkCore/CoreMvcDbContextFactory.cs
```csharp
 1: using System;
 2: using System.IO;
 3: using Microsoft.EntityFrameworkCore;
 4: using Microsoft.EntityFrameworkCore.Design;
 5: using Microsoft.Extensions.Configuration;
 6: namespace Aeq.CoreMvc.EntityFrameworkCore;
 7: public class CoreMvcDbContextFactory : IDesignTimeDbContextFactory<CoreMvcDbContext>
 8: {
 9:     public CoreMvcDbContext CreateDbContext(string[] args)
10:     {
11:         CoreMvcEfCoreEntityExtensionMappings.Configure();
12:         var configuration = BuildConfiguration();
13:         var builder = new DbContextOptionsBuilder<CoreMvcDbContext>()
14:             .UseMySql(configuration.GetConnectionString("Default"), MySqlServerVersion.LatestSupportedServerVersion);
15:         return new CoreMvcDbContext(builder.Options);
16:     }
17:     private static IConfigurationRoot BuildConfiguration()
18:     {
19:         var builder = new ConfigurationBuilder()
20:             .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Aeq.CoreMvc.DbMigrator/"))
21:             .AddJsonFile("appsettings.json", optional: false);
22:         return builder.Build();
23:     }
24: }
```

## File: src/Aeq.CoreMvc.EntityFrameworkCore/EntityFrameworkCore/CoreMvcEfCoreEntityExtensionMappings.cs
```csharp
 1: using Microsoft.EntityFrameworkCore;
 2: using Volo.Abp.Identity;
 3: using Volo.Abp.ObjectExtending;
 4: using Volo.Abp.Threading;
 5: namespace Aeq.CoreMvc.EntityFrameworkCore;
 6: public static class CoreMvcEfCoreEntityExtensionMappings
 7: {
 8:     private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();
 9:     public static void Configure()
10:     {
11:         CoreMvcGlobalFeatureConfigurator.Configure();
12:         CoreMvcModuleExtensionConfigurator.Configure();
13:         OneTimeRunner.Run(() =>
14:         {
15:         });
16:     }
17: }
```

## File: src/Aeq.CoreMvc.EntityFrameworkCore/EntityFrameworkCore/CoreMvcEntityFrameworkCoreModule.cs
```csharp
 1: using Aeq.CoreMvc.Books;
 2: using System;
 3: using Microsoft.Extensions.DependencyInjection;
 4: using Volo.Abp.Uow;
 5: using Volo.Abp.AuditLogging.EntityFrameworkCore;
 6: using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
 7: using Volo.Abp.EntityFrameworkCore;
 8: using Volo.Abp.EntityFrameworkCore.MySQL;
 9: using Volo.Abp.FeatureManagement.EntityFrameworkCore;
10: using Volo.Abp.Identity.EntityFrameworkCore;
11: using Volo.Abp.Modularity;
12: using Volo.Abp.OpenIddict.EntityFrameworkCore;
13: using Volo.Abp.PermissionManagement.EntityFrameworkCore;
14: using Volo.Abp.SettingManagement.EntityFrameworkCore;
15: using Volo.Abp.TenantManagement.EntityFrameworkCore;
16: namespace Aeq.CoreMvc.EntityFrameworkCore;
17: [DependsOn(
18:     typeof(CoreMvcDomainModule),
19:     typeof(AbpIdentityEntityFrameworkCoreModule),
20:     typeof(AbpOpenIddictEntityFrameworkCoreModule),
21:     typeof(AbpPermissionManagementEntityFrameworkCoreModule),
22:     typeof(AbpSettingManagementEntityFrameworkCoreModule),
23:     typeof(AbpEntityFrameworkCoreMySQLModule),
24:     typeof(AbpBackgroundJobsEntityFrameworkCoreModule),
25:     typeof(AbpAuditLoggingEntityFrameworkCoreModule),
26:     typeof(AbpTenantManagementEntityFrameworkCoreModule),
27:     typeof(AbpFeatureManagementEntityFrameworkCoreModule)
28:     )]
29: public class CoreMvcEntityFrameworkCoreModule : AbpModule
30: {
31:     public override void PreConfigureServices(ServiceConfigurationContext context)
32:     {
33:         CoreMvcEfCoreEntityExtensionMappings.Configure();
34:     }
35:     public override void ConfigureServices(ServiceConfigurationContext context)
36:     {
37:         context.Services.AddAbpDbContext<CoreMvcDbContext>(options =>
38:         {
39:             options.AddDefaultRepositories(includeAllEntities: true);
40:             options.AddRepository<Book, BookRepository>();
41:             options.AddRepository<Author, AuthorRepository>();
42:         });
43:         Configure<AbpDbContextOptions>(options =>
44:         {
45:             options.UseMySQL();
46:         });
47:     }
48: }
```

## File: src/Aeq.CoreMvc.EntityFrameworkCore/EntityFrameworkCore/EntityFrameworkCoreCoreMvcDbSchemaMigrator.cs
```csharp
 1: using System;
 2: using System.Threading.Tasks;
 3: using Microsoft.EntityFrameworkCore;
 4: using Microsoft.Extensions.DependencyInjection;
 5: using Aeq.CoreMvc.Data;
 6: using Volo.Abp.DependencyInjection;
 7: namespace Aeq.CoreMvc.EntityFrameworkCore;
 8: public class EntityFrameworkCoreCoreMvcDbSchemaMigrator
 9:     : ICoreMvcDbSchemaMigrator, ITransientDependency
10: {
11:     private readonly IServiceProvider _serviceProvider;
12:     public EntityFrameworkCoreCoreMvcDbSchemaMigrator(
13:         IServiceProvider serviceProvider)
14:     {
15:         _serviceProvider = serviceProvider;
16:     }
17:     public async Task MigrateAsync()
18:     {
19:         await _serviceProvider
20:             .GetRequiredService<CoreMvcDbContext>()
21:             .Database
22:             .MigrateAsync();
23:     }
24: }
```

## File: src/Aeq.CoreMvc.EntityFrameworkCore/Properties/AssemblyInfo.cs
```csharp
1: using System.Runtime.CompilerServices;
2: [assembly:InternalsVisibleToAttribute("Aeq.CoreMvc.EntityFrameworkCore.Tests")]
```

## File: src/Aeq.CoreMvc.EntityFrameworkCore/Aeq.CoreMvc.EntityFrameworkCore.csproj
```
 1: <Project Sdk="Microsoft.NET.Sdk">
 2: 
 3:   <Import Project="..\..\common.props" />
 4: 
 5:   <PropertyGroup>
 6:     <TargetFramework>net9.0</TargetFramework>
 7:     <Nullable>enable</Nullable>
 8:     <RootNamespace>Aeq.CoreMvc</RootNamespace>
 9:   </PropertyGroup>
10: 
11:   <ItemGroup>
12:     <ProjectReference Include="..\Aeq.CoreMvc.Domain\Aeq.CoreMvc.Domain.csproj" />
13:     <PackageReference Include="Volo.Abp.EntityFrameworkCore.MySQL" Version="9.0.8" />
14:     <PackageReference Include="Volo.Abp.PermissionManagement.EntityFrameworkCore" Version="9.0.8" />
15:     <PackageReference Include="Volo.Abp.SettingManagement.EntityFrameworkCore" Version="9.0.8" />
16:     <PackageReference Include="Volo.Abp.Identity.EntityFrameworkCore" Version="9.0.8" />
17:     <PackageReference Include="Volo.Abp.BackgroundJobs.EntityFrameworkCore" Version="9.0.8" />
18:     <PackageReference Include="Volo.Abp.AuditLogging.EntityFrameworkCore" Version="9.0.8" />
19:     <PackageReference Include="Volo.Abp.TenantManagement.EntityFrameworkCore" Version="9.0.8" />
20:     <PackageReference Include="Volo.Abp.FeatureManagement.EntityFrameworkCore" Version="9.0.8" />
21:     <PackageReference Include="Volo.Abp.OpenIddict.EntityFrameworkCore" Version="9.0.8" />
22:   </ItemGroup>
23: 
24:   <ItemGroup>
25:     <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="9.0.0">
26:       <PrivateAssets>all</PrivateAssets>
27:       <IncludeAssets>runtime; build; native; contentfiles; analyzers</IncludeAssets>
28:     </PackageReference>
29:   </ItemGroup>
30: 
31: </Project>
```

## File: src/Aeq.CoreMvc.HttpApi/Controllers/CoreMvcController.cs
```csharp
 1: using Aeq.CoreMvc.Localization;
 2: using Volo.Abp.AspNetCore.Mvc;
 3: namespace Aeq.CoreMvc.Controllers;
 4: public abstract class CoreMvcController : AbpControllerBase
 5: {
 6:     protected CoreMvcController()
 7:     {
 8:         LocalizationResource = typeof(CoreMvcResource);
 9:     }
10: }
```

## File: src/Aeq.CoreMvc.HttpApi/Models/Test/TestModel.cs
```csharp
1: using System;
2: namespace Aeq.CoreMvc.Models.Test;
3: public class TestModel
4: {
5:     public string? Name { get; set; }
6:     public DateTime BirthDate { get; set; }
7: }
```

## File: src/Aeq.CoreMvc.HttpApi/Aeq.CoreMvc.HttpApi.csproj
```
 1: <Project Sdk="Microsoft.NET.Sdk">
 2: 
 3:   <Import Project="..\..\common.props" />
 4: 
 5:   <PropertyGroup>
 6:     <TargetFramework>net9.0</TargetFramework>
 7:     <Nullable>enable</Nullable>
 8:     <RootNamespace>Aeq.CoreMvc</RootNamespace>
 9:   </PropertyGroup>
10: 
11:   <ItemGroup>
12:     <ProjectReference Include="..\Aeq.CoreMvc.Application.Contracts\Aeq.CoreMvc.Application.Contracts.csproj" />
13:   </ItemGroup>
14: 
15:   <ItemGroup>
16:     <PackageReference Include="Volo.Abp.Account.HttpApi" Version="9.0.8" />
17:     <PackageReference Include="Volo.Abp.Identity.HttpApi" Version="9.0.8" />
18:     <PackageReference Include="Volo.Abp.PermissionManagement.HttpApi" Version="9.0.8" />
19:     <PackageReference Include="Volo.Abp.TenantManagement.HttpApi" Version="9.0.8" />
20:     <PackageReference Include="Volo.Abp.FeatureManagement.HttpApi" Version="9.0.8" />
21:     <PackageReference Include="Volo.Abp.SettingManagement.HttpApi" Version="9.0.8" />
22:   </ItemGroup>
23: 
24: </Project>
```

## File: src/Aeq.CoreMvc.HttpApi/CoreMvcHttpApiModule.cs
```csharp
 1: using Localization.Resources.AbpUi;
 2: using Aeq.CoreMvc.Localization;
 3: using Volo.Abp.Account;
 4: using Volo.Abp.FeatureManagement;
 5: using Volo.Abp.Identity;
 6: using Volo.Abp.Localization;
 7: using Volo.Abp.Modularity;
 8: using Volo.Abp.PermissionManagement.HttpApi;
 9: using Volo.Abp.SettingManagement;
10: using Volo.Abp.TenantManagement;
11: namespace Aeq.CoreMvc;
12: [DependsOn(
13:     typeof(CoreMvcApplicationContractsModule),
14:     typeof(AbpAccountHttpApiModule),
15:     typeof(AbpIdentityHttpApiModule),
16:     typeof(AbpPermissionManagementHttpApiModule),
17:     typeof(AbpTenantManagementHttpApiModule),
18:     typeof(AbpFeatureManagementHttpApiModule),
19:     typeof(AbpSettingManagementHttpApiModule)
20:     )]
21: public class CoreMvcHttpApiModule : AbpModule
22: {
23:     public override void ConfigureServices(ServiceConfigurationContext context)
24:     {
25:         ConfigureLocalization();
26:     }
27:     private void ConfigureLocalization()
28:     {
29:         Configure<AbpLocalizationOptions>(options =>
30:         {
31:             options.Resources
32:                 .Get<CoreMvcResource>()
33:                 .AddBaseTypes(
34:                     typeof(AbpUiResource)
35:                 );
36:         });
37:     }
38: }
```

## File: src/Aeq.CoreMvc.HttpApi.Client/Aeq.CoreMvc.HttpApi.Client.csproj
```
 1: <Project Sdk="Microsoft.NET.Sdk">
 2: 
 3:   <Import Project="..\..\common.props" />
 4: 
 5:   <PropertyGroup>
 6:     <TargetFramework>net9.0</TargetFramework>
 7:     <Nullable>enable</Nullable>
 8:     <RootNamespace>Aeq.CoreMvc</RootNamespace>
 9:   </PropertyGroup>
10: 
11:   <ItemGroup>
12:     <ProjectReference Include="..\Aeq.CoreMvc.Application.Contracts\Aeq.CoreMvc.Application.Contracts.csproj" />
13:   </ItemGroup>
14: 
15:   <ItemGroup>
16:     <PackageReference Include="Volo.Abp.Account.HttpApi.Client" Version="9.0.8" />
17:     <PackageReference Include="Volo.Abp.Identity.HttpApi.Client" Version="9.0.8" />
18:     <PackageReference Include="Volo.Abp.PermissionManagement.HttpApi.Client" Version="9.0.8" />
19:     <PackageReference Include="Volo.Abp.TenantManagement.HttpApi.Client" Version="9.0.8" />
20:     <PackageReference Include="Volo.Abp.FeatureManagement.HttpApi.Client" Version="9.0.8" />
21:     <PackageReference Include="Volo.Abp.SettingManagement.HttpApi.Client" Version="9.0.8" />
22:   </ItemGroup>
23: 
24:   <ItemGroup>
25:     <EmbeddedResource Include="**\*generate-proxy.json" />
26:     <Content Remove="**\*generate-proxy.json" />
27:   </ItemGroup>
28: 
29: </Project>
```

## File: src/Aeq.CoreMvc.HttpApi.Client/CoreMvcHttpApiClientModule.cs
```csharp
 1: using Microsoft.Extensions.DependencyInjection;
 2: using Volo.Abp.Account;
 3: using Volo.Abp.FeatureManagement;
 4: using Volo.Abp.Identity;
 5: using Volo.Abp.Modularity;
 6: using Volo.Abp.PermissionManagement;
 7: using Volo.Abp.TenantManagement;
 8: using Volo.Abp.SettingManagement;
 9: using Volo.Abp.VirtualFileSystem;
10: namespace Aeq.CoreMvc;
11: [DependsOn(
12:     typeof(CoreMvcApplicationContractsModule),
13:     typeof(AbpAccountHttpApiClientModule),
14:     typeof(AbpIdentityHttpApiClientModule),
15:     typeof(AbpPermissionManagementHttpApiClientModule),
16:     typeof(AbpTenantManagementHttpApiClientModule),
17:     typeof(AbpFeatureManagementHttpApiClientModule),
18:     typeof(AbpSettingManagementHttpApiClientModule)
19: )]
20: public class CoreMvcHttpApiClientModule : AbpModule
21: {
22:     public const string RemoteServiceName = "Default";
23:     public override void ConfigureServices(ServiceConfigurationContext context)
24:     {
25:         context.Services.AddHttpClientProxies(
26:             typeof(CoreMvcApplicationContractsModule).Assembly,
27:             RemoteServiceName
28:         );
29:         Configure<AbpVirtualFileSystemOptions>(options =>
30:         {
31:             options.FileSets.AddEmbedded<CoreMvcHttpApiClientModule>();
32:         });
33:     }
34: }
```

## File: src/Aeq.CoreMvc.Web/Components/_ViewImports.cshtml
```
1: @addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
2: @addTagHelper *, Volo.Abp.AspNetCore.Mvc.UI
3: @addTagHelper *, Volo.Abp.AspNetCore.Mvc.UI.Bootstrap
4: @addTagHelper *, Volo.Abp.AspNetCore.Mvc.UI.Bundling
```

## File: src/Aeq.CoreMvc.Web/Menus/CoreMvcMenuContributor.cs
```csharp
 1: using System.Threading.Tasks;
 2: using Aeq.CoreMvc.Permissions;
 3: using Aeq.CoreMvc.Localization;
 4: using Aeq.CoreMvc.MultiTenancy;
 5: using Volo.Abp.Identity.Web.Navigation;
 6: using Volo.Abp.SettingManagement.Web.Navigation;
 7: using Volo.Abp.TenantManagement.Web.Navigation;
 8: using Volo.Abp.UI.Navigation;
 9: namespace Aeq.CoreMvc.Web.Menus;
10: public class CoreMvcMenuContributor : IMenuContributor
11: {
12:     public async Task ConfigureMenuAsync(MenuConfigurationContext context)
13:     {
14:         if (context.Menu.Name == StandardMenus.Main)
15:         {
16:             await ConfigureMainMenuAsync(context);
17:         }
18:     }
19:     private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
20:     {
21:         var administration = context.Menu.GetAdministration();
22:         var l = context.GetLocalizer<CoreMvcResource>();
23:         context.Menu.Items.Insert(
24:             0,
25:             new ApplicationMenuItem(
26:                 CoreMvcMenus.Home,
27:                 l["Menu:Home"],
28:                 "~/",
29:                 icon: "fas fa-home",
30:                 order: 0
31:             )
32:         );
33:         if (MultiTenancyConsts.IsEnabled)
34:         {
35:             administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
36:         }
37:         else
38:         {
39:             administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
40:         }
41:         administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
42:         administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);
43:         if (await context.IsGrantedAsync(CoreMvcPermissions.Book.Default))
44:         {
45:             context.Menu.GetAdministration().AddItem(
46:                 new ApplicationMenuItem(CoreMvcMenus.Book, l["Menu:Book"], "/Books/Book")
47:             );
48:         }
49:         if (await context.IsGrantedAsync(CoreMvcPermissions.Author.Default))
50:         {
51:             context.Menu.GetAdministration().AddItem(
52:                 new ApplicationMenuItem(CoreMvcMenus.Author, l["Menu:Author"], "/Books/Author")
53:             );
54:         }
55:     }
56: }
```

## File: src/Aeq.CoreMvc.Web/Menus/CoreMvcMenus.cs
```csharp
1: namespace Aeq.CoreMvc.Web.Menus;
2: public class CoreMvcMenus
3: {
4:     private const string Prefix = "CoreMvc";
5:     public const string Home = Prefix + ".Home";
6:     public const string Book = Prefix + ".Book";
7:     public const string Author = Prefix + ".Author";
8: }
```

## File: src/Aeq.CoreMvc.Web/Pages/Books/Author/ViewModels/CreateEditAuthorViewModel.cs
```csharp
 1: using System;
 2: using System.ComponentModel.DataAnnotations;
 3: namespace Aeq.CoreMvc.Web.Pages.Books.Author.ViewModels;
 4: public class CreateEditAuthorViewModel
 5: {
 6:     [Display(Name = "AuthorName")]
 7:     public string Name { get; set; }
 8:     [Display(Name = "AuthorPhoneNumber")]
 9:     public string PhoneNumber { get; set; }
10:     [Display(Name = "AuthorEmail")]
11:     public string Email { get; set; }
12: }
```

## File: src/Aeq.CoreMvc.Web/Pages/Books/Author/CreateModal.cshtml
```
 1: @page
 2: @using Microsoft.AspNetCore.Mvc.Localization
 3: @using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Modal;
 4: @using Aeq.CoreMvc.Localization
 5: @inject IHtmlLocalizer<CoreMvcResource> L
 6: @model Aeq.CoreMvc.Web.Pages.Books.Author.CreateModalModel
 7: @{
 8:     Layout = null;
 9: }
10: <abp-dynamic-form abp-model="ViewModel" data-ajaxForm="true" asp-page="CreateModal">
11:     <abp-modal>
12:         <abp-modal-header title="@L["CreateAuthor"].Value"></abp-modal-header>
13:         <abp-modal-body>
14:             <abp-form-content />
15:         </abp-modal-body>
16:         <abp-modal-footer buttons="@(AbpModalButtons.Cancel|AbpModalButtons.Save)"></abp-modal-footer>
17:     </abp-modal>
18: </abp-dynamic-form>
```

## File: src/Aeq.CoreMvc.Web/Pages/Books/Author/CreateModal.cshtml.cs
```csharp
 1: using System.Threading.Tasks;
 2: using Microsoft.AspNetCore.Mvc;
 3: using Aeq.CoreMvc.Books;
 4: using Aeq.CoreMvc.Books.Dtos;
 5: using Aeq.CoreMvc.Web.Pages.Books.Author.ViewModels;
 6: namespace Aeq.CoreMvc.Web.Pages.Books.Author;
 7: public class CreateModalModel : CoreMvcPageModel
 8: {
 9:     [BindProperty]
10:     public CreateEditAuthorViewModel ViewModel { get; set; }
11:     private readonly IAuthorAppService _service;
12:     public CreateModalModel(IAuthorAppService service)
13:     {
14:         _service = service;
15:     }
16:     public virtual async Task<IActionResult> OnPostAsync()
17:     {
18:         var dto = ObjectMapper.Map<CreateEditAuthorViewModel, CreateUpdateAuthorDto>(ViewModel);
19:         await _service.CreateAsync(dto);
20:         return NoContent();
21:     }
22: }
```

## File: src/Aeq.CoreMvc.Web/Pages/Books/Author/EditModal.cshtml
```
 1: @page
 2: @using Aeq.CoreMvc.Localization
 3: @using Microsoft.AspNetCore.Mvc.Localization
 4: @using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Modal;
 5: @inject IHtmlLocalizer<CoreMvcResource> L
 6: @model Aeq.CoreMvc.Web.Pages.Books.Author.EditModalModel
 7: @{
 8:     Layout = null;
 9: }
10: <abp-dynamic-form abp-model="ViewModel" data-ajaxForm="true" asp-page="EditModal">
11:     <abp-modal>
12:         <abp-modal-header title="@L["EditAuthor"].Value"></abp-modal-header>
13:         <abp-modal-body>
14:             <abp-input asp-for="Id" />
15:             <abp-form-content />
16:         </abp-modal-body>
17:         <abp-modal-footer buttons="@(AbpModalButtons.Cancel|AbpModalButtons.Save)"></abp-modal-footer>
18:     </abp-modal>
19: </abp-dynamic-form>
```

## File: src/Aeq.CoreMvc.Web/Pages/Books/Author/EditModal.cshtml.cs
```csharp
 1: using System;
 2: using System.Threading.Tasks;
 3: using Microsoft.AspNetCore.Mvc;
 4: using Aeq.CoreMvc.Books;
 5: using Aeq.CoreMvc.Books.Dtos;
 6: using Aeq.CoreMvc.Web.Pages.Books.Author.ViewModels;
 7: namespace Aeq.CoreMvc.Web.Pages.Books.Author;
 8: public class EditModalModel : CoreMvcPageModel
 9: {
10:     [HiddenInput]
11:     [BindProperty(SupportsGet = true)]
12:     public Guid Id { get; set; }
13:     [BindProperty]
14:     public CreateEditAuthorViewModel ViewModel { get; set; }
15:     private readonly IAuthorAppService _service;
16:     public EditModalModel(IAuthorAppService service)
17:     {
18:         _service = service;
19:     }
20:     public virtual async Task OnGetAsync()
21:     {
22:         var dto = await _service.GetAsync(Id);
23:         ViewModel = ObjectMapper.Map<AuthorDto, CreateEditAuthorViewModel>(dto);
24:     }
25:     public virtual async Task<IActionResult> OnPostAsync()
26:     {
27:         var dto = ObjectMapper.Map<CreateEditAuthorViewModel, CreateUpdateAuthorDto>(ViewModel);
28:         await _service.UpdateAsync(Id, dto);
29:         return NoContent();
30:     }
31: }
```

## File: src/Aeq.CoreMvc.Web/Pages/Books/Author/Index.cshtml
```
 1: @page
 2: @using Aeq.CoreMvc.Permissions
 3: @using Microsoft.AspNetCore.Authorization
 4: @using Microsoft.AspNetCore.Mvc.Localization
 5: @using Volo.Abp.AspNetCore.Mvc.UI.Layout
 6: @using Aeq.CoreMvc.Web.Pages.Books.Author
 7: @using Aeq.CoreMvc.Localization
 8: @using Aeq.CoreMvc.Web.Menus
 9: @model IndexModel
10: @inject IPageLayout PageLayout
11: @inject IHtmlLocalizer<CoreMvcResource> L
12: @inject IAuthorizationService Authorization
13: @{
14:     PageLayout.Content.Title = L["Author"].Value;
15:     PageLayout.Content.BreadCrumb.Add(L["Menu:Author"].Value);
16:     PageLayout.Content.MenuItemName = CoreMvcMenus.Author;
17: }
18: 
19: @section scripts
20: {
21:     <abp-script src="/Pages/Books/Author/index.js" />
22: }
23: @section styles
24: {
25:     <abp-style src="/Pages/Books/Author/index.css"/>
26: }
27: @section content_toolbar
28: {
29: 	@if (await Authorization.IsGrantedAsync(CoreMvcPermissions.Author.Create))
30:     {
31:         <abp-button id="NewAuthorButton"
32:             text="@L["CreateAuthor"].Value"
33:             icon="plus" size="Small"
34:             button-type="Primary" />
35:     }
36: }
37: 
38: <abp-card>
39:     <abp-card-body>
40:         <abp-row class="mb-3">
41:             <a abp-collapse-id="AuthorCollapse" class="text-secondary">@L["TableFilter"] </a>
42:         </abp-row>
43:         <abp-dynamic-form abp-model="AuthorFilter" id="AuthorFilter" required-symbols="false" column-size="_3">
44:             <abp-collapse-body id="AuthorCollapse">
45:                 <abp-form-content />
46:             </abp-collapse-body>
47:         </abp-dynamic-form>
48:         <hr />
49:         <abp-table striped-rows="true" id="AuthorTable" class="nowrap"/>
50:     </abp-card-body>
51: </abp-card>
```

## File: src/Aeq.CoreMvc.Web/Pages/Books/Author/Index.cshtml.cs
```csharp
 1: using System;
 2: using System.Threading.Tasks;
 3: using System.ComponentModel.DataAnnotations;
 4: using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
 5: namespace Aeq.CoreMvc.Web.Pages.Books.Author;
 6: public class IndexModel : CoreMvcPageModel
 7: {
 8:     public AuthorFilterInput AuthorFilter { get; set; }
 9:     public virtual async Task OnGetAsync()
10:     {
11:         await Task.CompletedTask;
12:     }
13: }
14: public class AuthorFilterInput
15: {
16:     [FormControlSize(AbpFormControlSize.Small)]
17:     [Display(Name = "AuthorName")]
18:     public string? Name { get; set; }
19:     [FormControlSize(AbpFormControlSize.Small)]
20:     [Display(Name = "AuthorPhoneNumber")]
21:     public string? PhoneNumber { get; set; }
22:     [FormControlSize(AbpFormControlSize.Small)]
23:     [Display(Name = "AuthorEmail")]
24:     public string? Email { get; set; }
25: }
```

## File: src/Aeq.CoreMvc.Web/Pages/Books/Author/index.js
```javascript
 1: $(function () {
 2:     $("#AuthorFilter :input").on('input', function () {
 3:         dataTable.ajax.reload();
 4:     });
 5:     var getFilter = function () {
 6:         var input = {};
 7:         $("#AuthorFilter")
 8:             .serializeArray()
 9:             .forEach(function (data) {
10:                 if (data.value != '') {
11:                     input[abp.utils.toCamelCase(data.name.replace(/AuthorFilter./g, ''))] = data.value;
12:                 }
13:             })
14:         return input;
15:     };
16:     var l = abp.localization.getResource('CoreMvc');
17:     var service = aeq.coreMvc.books.author;
18:     var createModal = new abp.ModalManager(abp.appPath + 'Books/Author/CreateModal');
19:     var editModal = new abp.ModalManager(abp.appPath + 'Books/Author/EditModal');
20:     var dataTable = $('#AuthorTable').DataTable(abp.libs.datatables.normalizeConfiguration({
21:         processing: true,
22:         serverSide: true,
23:         paging: true,
24:         searching: false,
25:         autoWidth: false,
26:         scrollCollapse: true,
27:         order: [[0, "asc"]],
28:         ajax: abp.libs.datatables.createAjax(service.getList,getFilter),
29:         columnDefs: [
30:             {
31:                 rowAction: {
32:                     items:
33:                         [
34:                             {
35:                                 text: l('Edit'),
36:                                 visible: abp.auth.isGranted('CoreMvc.Author.Update'),
37:                                 action: function (data) {
38:                                     editModal.open({ id: data.record.id });
39:                                 }
40:                             },
41:                             {
42:                                 text: l('Delete'),
43:                                 visible: abp.auth.isGranted('CoreMvc.Author.Delete'),
44:                                 confirmMessage: function (data) {
45:                                     return l('AuthorDeletionConfirmationMessage', data.record.id);
46:                                 },
47:                                 action: function (data) {
48:                                     service.delete(data.record.id)
49:                                         .then(function () {
50:                                             abp.notify.info(l('SuccessfullyDeleted'));
51:                                             dataTable.ajax.reload();
52:                                         });
53:                                 }
54:                             }
55:                         ]
56:                 }
57:             },
58:             {
59:                 title: l('AuthorName'),
60:                 data: "name"
61:             },
62:             {
63:                 title: l('AuthorPhoneNumber'),
64:                 data: "phoneNumber"
65:             },
66:             {
67:                 title: l('AuthorEmail'),
68:                 data: "email"
69:             },
70:         ]
71:     }));
72:     createModal.onResult(function () {
73:         dataTable.ajax.reload();
74:     });
75:     editModal.onResult(function () {
76:         dataTable.ajax.reload();
77:     });
78:     $('#NewAuthorButton').click(function (e) {
79:         e.preventDefault();
80:         createModal.open();
81:     });
82: });
```

## File: src/Aeq.CoreMvc.Web/Pages/Books/Book/ViewModels/CreateEditBookViewModel.cs
```csharp
 1: using System;
 2: using System.ComponentModel.DataAnnotations;
 3: namespace Aeq.CoreMvc.Web.Pages.Books.Book.ViewModels;
 4: public class CreateEditBookViewModel
 5: {
 6:     [Display(Name = "BookName")]
 7:     public string Name { get; set; }
 8:     [Display(Name = "BookType")]
 9:     public string Type { get; set; }
10:     [Display(Name = "BookDescription")]
11:     public string Description { get; set; }
12:     [Display(Name = "BookPublishDate")]
13:     public DateTime PublishDate { get; set; }
14: }
```

## File: src/Aeq.CoreMvc.Web/Pages/Books/Book/CreateModal.cshtml
```
 1: @page
 2: @using Microsoft.AspNetCore.Mvc.Localization
 3: @using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Modal;
 4: @using Aeq.CoreMvc.Localization
 5: @inject IHtmlLocalizer<CoreMvcResource> L
 6: @model Aeq.CoreMvc.Web.Pages.Books.Book.CreateModalModel
 7: @{
 8:     Layout = null;
 9: }
10: <abp-dynamic-form abp-model="ViewModel" data-ajaxForm="true" asp-page="CreateModal">
11:     <abp-modal>
12:         <abp-modal-header title="@L["CreateBook"].Value"></abp-modal-header>
13:         <abp-modal-body>
14:             <abp-form-content />
15:         </abp-modal-body>
16:         <abp-modal-footer buttons="@(AbpModalButtons.Cancel|AbpModalButtons.Save)"></abp-modal-footer>
17:     </abp-modal>
18: </abp-dynamic-form>
```

## File: src/Aeq.CoreMvc.Web/Pages/Books/Book/CreateModal.cshtml.cs
```csharp
 1: using System.Threading.Tasks;
 2: using Microsoft.AspNetCore.Mvc;
 3: using Aeq.CoreMvc.Books;
 4: using Aeq.CoreMvc.Books.Dtos;
 5: using Aeq.CoreMvc.Web.Pages.Books.Book.ViewModels;
 6: namespace Aeq.CoreMvc.Web.Pages.Books.Book;
 7: public class CreateModalModel : CoreMvcPageModel
 8: {
 9:     [BindProperty]
10:     public CreateEditBookViewModel ViewModel { get; set; }
11:     private readonly IBookAppService _service;
12:     public CreateModalModel(IBookAppService service)
13:     {
14:         _service = service;
15:     }
16:     public virtual async Task<IActionResult> OnPostAsync()
17:     {
18:         var dto = ObjectMapper.Map<CreateEditBookViewModel, CreateUpdateBookDto>(ViewModel);
19:         await _service.CreateAsync(dto);
20:         return NoContent();
21:     }
22: }
```

## File: src/Aeq.CoreMvc.Web/Pages/Books/Book/EditModal.cshtml
```
 1: @page
 2: @using Aeq.CoreMvc.Localization
 3: @using Microsoft.AspNetCore.Mvc.Localization
 4: @using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Modal;
 5: @inject IHtmlLocalizer<CoreMvcResource> L
 6: @model Aeq.CoreMvc.Web.Pages.Books.Book.EditModalModel
 7: @{
 8:     Layout = null;
 9: }
10: <abp-dynamic-form abp-model="ViewModel" data-ajaxForm="true" asp-page="EditModal">
11:     <abp-modal>
12:         <abp-modal-header title="@L["EditBook"].Value"></abp-modal-header>
13:         <abp-modal-body>
14:             <abp-input asp-for="Id" />
15:             <abp-form-content />
16:         </abp-modal-body>
17:         <abp-modal-footer buttons="@(AbpModalButtons.Cancel|AbpModalButtons.Save)"></abp-modal-footer>
18:     </abp-modal>
19: </abp-dynamic-form>
```

## File: src/Aeq.CoreMvc.Web/Pages/Books/Book/EditModal.cshtml.cs
```csharp
 1: using System;
 2: using System.Threading.Tasks;
 3: using Microsoft.AspNetCore.Mvc;
 4: using Aeq.CoreMvc.Books;
 5: using Aeq.CoreMvc.Books.Dtos;
 6: using Aeq.CoreMvc.Web.Pages.Books.Book.ViewModels;
 7: namespace Aeq.CoreMvc.Web.Pages.Books.Book;
 8: public class EditModalModel : CoreMvcPageModel
 9: {
10:     [HiddenInput]
11:     [BindProperty(SupportsGet = true)]
12:     public Guid Id { get; set; }
13:     [BindProperty]
14:     public CreateEditBookViewModel ViewModel { get; set; }
15:     private readonly IBookAppService _service;
16:     public EditModalModel(IBookAppService service)
17:     {
18:         _service = service;
19:     }
20:     public virtual async Task OnGetAsync()
21:     {
22:         var dto = await _service.GetAsync(Id);
23:         ViewModel = ObjectMapper.Map<BookDto, CreateEditBookViewModel>(dto);
24:     }
25:     public virtual async Task<IActionResult> OnPostAsync()
26:     {
27:         var dto = ObjectMapper.Map<CreateEditBookViewModel, CreateUpdateBookDto>(ViewModel);
28:         await _service.UpdateAsync(Id, dto);
29:         return NoContent();
30:     }
31: }
```

## File: src/Aeq.CoreMvc.Web/Pages/Books/Book/Index.cshtml
```
 1: @page
 2: @using Aeq.CoreMvc.Permissions
 3: @using Microsoft.AspNetCore.Authorization
 4: @using Microsoft.AspNetCore.Mvc.Localization
 5: @using Volo.Abp.AspNetCore.Mvc.UI.Layout
 6: @using Aeq.CoreMvc.Web.Pages.Books.Book
 7: @using Aeq.CoreMvc.Localization
 8: @using Aeq.CoreMvc.Web.Menus
 9: @model IndexModel
10: @inject IPageLayout PageLayout
11: @inject IHtmlLocalizer<CoreMvcResource> L
12: @inject IAuthorizationService Authorization
13: @{
14:     PageLayout.Content.Title = L["Book"].Value;
15:     PageLayout.Content.BreadCrumb.Add(L["Menu:Book"].Value);
16:     PageLayout.Content.MenuItemName = CoreMvcMenus.Book;
17: }
18: 
19: @section scripts
20: {
21:     <abp-script src="/Pages/Books/Book/index.js" />
22: }
23: @section styles
24: {
25:     <abp-style src="/Pages/Books/Book/index.css"/>
26: }
27: @section content_toolbar
28: {
29: 	@if (await Authorization.IsGrantedAsync(CoreMvcPermissions.Book.Create))
30:     {
31:         <abp-button id="NewBookButton"
32:             text="@L["CreateBook"].Value"
33:             icon="plus"
34:             button-type="Primary" />
35:     }
36: }
37: 
38: <abp-card>
39:     <abp-card-body>
40:         <abp-row class="mb-3">
41:             <a abp-collapse-id="BookCollapse" class="text-secondary">@L["TableFilter"] </a>
42:         </abp-row>
43:         <abp-dynamic-form abp-model="BookFilter" id="BookFilter" required-symbols="false" column-size="_3">
44:             <abp-collapse-body id="BookCollapse">
45:                 <abp-form-content />
46:             </abp-collapse-body>
47:         </abp-dynamic-form>
48:         <hr />
49:         <abp-table striped-rows="true" id="BookTable" class="nowrap"/>
50:     </abp-card-body>
51: </abp-card>
```

## File: src/Aeq.CoreMvc.Web/Pages/Books/Book/Index.cshtml.cs
```csharp
 1: using System;
 2: using System.Threading.Tasks;
 3: using System.ComponentModel.DataAnnotations;
 4: using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
 5: namespace Aeq.CoreMvc.Web.Pages.Books.Book;
 6: public class IndexModel : CoreMvcPageModel
 7: {
 8:     public BookFilterInput BookFilter { get; set; }
 9:     public virtual async Task OnGetAsync()
10:     {
11:         await Task.CompletedTask;
12:     }
13: }
14: public class BookFilterInput
15: {
16:     [FormControlSize(AbpFormControlSize.Small)]
17:     [Display(Name = "BookName")]
18:     public string? Name { get; set; }
19:     [FormControlSize(AbpFormControlSize.Small)]
20:     [Display(Name = "BookType")]
21:     public string? Type { get; set; }
22:     [FormControlSize(AbpFormControlSize.Small)]
23:     [Display(Name = "BookDescription")]
24:     public string? Description { get; set; }
25:     [FormControlSize(AbpFormControlSize.Small)]
26:     [Display(Name = "BookPublishDate")]
27:     public DateTime? PublishDate { get; set; }
28: }
```

## File: src/Aeq.CoreMvc.Web/Pages/Books/Book/index.js
```javascript
 1: $(function () {
 2:     $("#BookFilter :input").on('input', function () {
 3:         dataTable.ajax.reload();
 4:     });
 5:     var getFilter = function () {
 6:         var input = {};
 7:         $("#BookFilter")
 8:             .serializeArray()
 9:             .forEach(function (data) {
10:                 if (data.value != '') {
11:                     input[abp.utils.toCamelCase(data.name.replace(/BookFilter./g, ''))] = data.value;
12:                 }
13:             })
14:         return input;
15:     };
16:     var l = abp.localization.getResource('CoreMvc');
17:     var service = aeq.coreMvc.books.book;
18:     var createModal = new abp.ModalManager(abp.appPath + 'Books/Book/CreateModal');
19:     var editModal = new abp.ModalManager(abp.appPath + 'Books/Book/EditModal');
20:     var dataTable = $('#BookTable').DataTable(abp.libs.datatables.normalizeConfiguration({
21:         processing: true,
22:         serverSide: true,
23:         paging: true,
24:         searching: false,
25:         autoWidth: false,
26:         scrollCollapse: true,
27:         order: [[0, "asc"]],
28:         ajax: abp.libs.datatables.createAjax(service.getList,getFilter),
29:         columnDefs: [
30:             {
31:                 rowAction: {
32:                     items:
33:                         [
34:                             {
35:                                 text: l('Edit'),
36:                                 visible: abp.auth.isGranted('CoreMvc.Book.Update'),
37:                                 action: function (data) {
38:                                     editModal.open({ id: data.record.id });
39:                                 }
40:                             },
41:                             {
42:                                 text: l('Delete'),
43:                                 visible: abp.auth.isGranted('CoreMvc.Book.Delete'),
44:                                 confirmMessage: function (data) {
45:                                     return l('BookDeletionConfirmationMessage', data.record.id);
46:                                 },
47:                                 action: function (data) {
48:                                     service.delete(data.record.id)
49:                                         .then(function () {
50:                                             abp.notify.info(l('SuccessfullyDeleted'));
51:                                             dataTable.ajax.reload();
52:                                         });
53:                                 }
54:                             }
55:                         ]
56:                 }
57:             },
58:             {
59:                 title: l('BookName'),
60:                 data: "name"
61:             },
62:             {
63:                 title: l('BookType'),
64:                 data: "type"
65:             },
66:             {
67:                 title: l('BookDescription'),
68:                 data: "description"
69:             },
70:             {
71:                 title: l('BookPublishDate'),
72:                 data: "publishDate"
73:             },
74:         ]
75:     }));
76:     createModal.onResult(function () {
77:         dataTable.ajax.reload();
78:     });
79:     editModal.onResult(function () {
80:         dataTable.ajax.reload();
81:     });
82:     $('#NewBookButton').click(function (e) {
83:         e.preventDefault();
84:         createModal.open();
85:     });
86: });
```

## File: src/Aeq.CoreMvc.Web/Pages/_ViewImports.cshtml
```
1: @addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
2: @addTagHelper *, Volo.Abp.AspNetCore.Mvc.UI
3: @addTagHelper *, Volo.Abp.AspNetCore.Mvc.UI.Bootstrap
4: @addTagHelper *, Volo.Abp.AspNetCore.Mvc.UI.Bundling
```

## File: src/Aeq.CoreMvc.Web/Pages/CoreMvcPageModel.cs
```csharp
 1: using Aeq.CoreMvc.Localization;
 2: using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
 3: namespace Aeq.CoreMvc.Web.Pages;
 4: public abstract class CoreMvcPageModel : AbpPageModel
 5: {
 6:     protected CoreMvcPageModel()
 7:     {
 8:         LocalizationResourceType = typeof(CoreMvcResource);
 9:     }
10: }
```

## File: src/Aeq.CoreMvc.Web/Pages/Index.cshtml
```
 1: @page
 2: <div class="row mb-3">
 3:     <div class="col-xl-6 col-12 d-flex">
 4:         <div class="card h-lg-100 w-100 overflow-hidden">
 5:             <div class="card-body">
 6:                 <div class="starting-content">
 7:                     <h3>Getting Started</h3>
 8:                     <p class="lead text-muted mb-2">Learn how to create and run a new web application using the application startup template.</p>
 9:                     <a href="https://docs.abp.io/en/commercial/latest/getting-started" class="btn btn-brand mb-4" target="_blank">Getting Started</a>
10: 
11:                     <h4>Web Application Development Tutorial</h4>
12:                     <p class="text-muted mb-2">Learn how to build an ABP based web application named Acme.BookStore.</p>
13:                     <a href="https://docs.abp.io/en/commercial/latest/tutorials/book-store/part-1?UI=MVC&DB=EF" class="btn btn-primary soft mb-4" target="_blank">Explore Tutorial</a>
14: 
15:                     <h4>Customize Lepton Theme</h4>
16:                     <p class="text-muted mb-2">Learn how to customize LeptonX Theme as you wish.</p>
17:                     <a href="https://docs.abp.io/en/commercial/latest/themes/lepton/customizing-lepton-theme" class="btn btn-primary soft mb-5 mb-xl-0" target="_blank">Customize Lepton</a>
18:                 </div>
19:                 <img class="card-bg-image" src="/images/getting-started/bg-01.png">
20:             </div>
21:         </div>
22:     </div>
23: 
24:     <div class="col-xl-3 col-md-6 d-flex">
25:         <div class="row">
26:             <div class="col-12 d-flex">
27:                 <div class="card overflow-hidden">
28:                     <div class="card-body pb-0">
29:                         <div class="abp-support abp-logo mb-2"></div>
30:                         <p class="text-muted mb-2">You can check for similar problems and solutions, or open a new topic to discuss your specific issue.</p>
31:                         <a href="https://support.abp.io/QA/Questions" class="btn btn-brand soft" target="_blank">Visit Support</a>
32:                         <img class="" src="/images/getting-started/img-support.png">
33:                     </div>
34:                 </div>
35:             </div>
36:             <div class="col-12 d-flex">
37:                 <div class="card h-md-100 overflow-hidden">
38:                     <div class="card-body pb-0">
39:                         <div class="abp-blog abp-logo mb-2"></div>
40:                         <p class="text-muted mb-2">You can find content on .NET development, cross-platform, ASP.NET application templates, ABP-related news, and more.</p>
41:                         <a href="https://blog.abp.io/abp" class="btn btn-brand soft" target="_blank">Visit Blog</a>
42:                         <img style="margin-bottom: -24px;" src="/images/getting-started/img-blog.png">
43:                     </div>
44:                 </div>
45:             </div>
46:         </div>
47:     </div>
48: 
49:     <div class="col-xl-3 col-md-6 d-flex">
50:         <div class="card h-100 overflow-hidden">
51:             <div class="card-body">
52:                 <div class="abp-community abp-logo mb-2"></div>
53:                 <p class="lead text-muted">A unique community platform for <span class="fw-bold">ABP Lovers!</span></p>
54:                 <p class="text-muted mb-2">Explore all ABP users' experiences with the ABP Framework, discover articles and videos on how to use ABP, and join raffles for a chance to win surprise gifts!</p>
55:                 <a class="btn btn-brand soft mb-3" href="https://community.abp.io/" target="_blank">Join ABP Community</a>
56:             </div>
57:             <img class="mt-3" src="/images/getting-started/img-community.png">
58:         </div>
59:     </div>
60: </div>
```

## File: src/Aeq.CoreMvc.Web/Pages/Index.cshtml.cs
```csharp
1: namespace Aeq.CoreMvc.Web.Pages;
2: public class IndexModel : CoreMvcPageModel
3: {
4:     public void OnGet()
5:     {
6:     }
7: }
```

## File: src/Aeq.CoreMvc.Web/Pages/Index.css
```css
 1: body {
 2: }
 3: .card-bg-image {
 4:     position: absolute;
 5:     width: 630px;
 6:     height: auto;
 7:     bottom: 0;
 8:     right: 0;
 9:     z-index: 1;
10: }
```

## File: src/Aeq.CoreMvc.Web/Pages/Index.js
```javascript
1: $(function () {
2:     abp.log.debug('Index.js initialized!');
3: });
```

## File: src/Aeq.CoreMvc.Web/Properties/AssemblyInfo.cs
```csharp
1: using System.Runtime.CompilerServices;
2: [assembly:InternalsVisibleToAttribute("Aeq.CoreMvc.Web.Tests")]
```

## File: src/Aeq.CoreMvc.Web/Properties/launchSettings.json
```json
 1: {
 2:   "iisSettings": {
 3:     "windowsAuthentication": false,
 4:     "anonymousAuthentication": true,
 5:     "iisExpress": {
 6:       "applicationUrl": "https://localhost:44313/",
 7:       "sslPort": 44313
 8:     }
 9:   },
10:   "profiles": {
11:     "IIS Express": {
12:       "commandName": "IISExpress",
13:       "launchBrowser": true,
14:       "environmentVariables": {
15:         "ASPNETCORE_ENVIRONMENT": "Development"
16:       }
17:     },
18:     "Aeq.CoreMvc.Web": {
19:       "commandName": "Project",
20:       "launchBrowser": true,
21:       "environmentVariables": {
22:         "ASPNETCORE_ENVIRONMENT": "Development"
23:       },
24:       "applicationUrl": "https://localhost:44313/"
25:     }
26:   }
27: }
```

## File: src/Aeq.CoreMvc.Web/Views/_ViewImports.cshtml
```
1: @addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
2: @addTagHelper *, Volo.Abp.AspNetCore.Mvc.UI
3: @addTagHelper *, Volo.Abp.AspNetCore.Mvc.UI.Bootstrap
4: @addTagHelper *, Volo.Abp.AspNetCore.Mvc.UI.Bundling
```

## File: src/Aeq.CoreMvc.Web/wwwroot/images/getting-started/discord.svg
```
1: <svg width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
2: <g id="Frame 1416">
3: <g id="Group">
4: <path id="Vector" d="M16.9419 3.29661C15.6473 2.69088 14.263 2.25066 12.8157 2C12.638 2.32134 12.4304 2.75355 12.2872 3.09738C10.7487 2.86601 9.22445 2.86601 7.7143 3.09738C7.57116 2.75355 7.3588 2.32134 7.17947 2C5.73067 2.25066 4.3448 2.6925 3.05016 3.29982C0.438869 7.24582 -0.269009 11.0938 0.0849305 14.8872C1.81688 16.1805 3.49534 16.9662 5.14548 17.4804C5.55291 16.9196 5.91628 16.3235 6.22931 15.6953C5.63313 15.4688 5.06211 15.1892 4.52256 14.8647C4.6657 14.7586 4.80571 14.6478 4.94098 14.5337C8.23183 16.0729 11.8074 16.0729 15.0589 14.5337C15.1958 14.6478 15.3358 14.7586 15.4774 14.8647C14.9362 15.1908 14.3637 15.4704 13.7675 15.697C14.0805 16.3235 14.4423 16.9212 14.8513 17.4819C16.503 16.9678 18.183 16.1822 19.915 14.8872C20.3303 10.4897 19.2056 6.67705 16.9419 3.29661ZM6.67765 12.5543C5.68977 12.5543 4.87963 11.632 4.87963 10.509C4.87963 9.38591 5.67247 8.46208 6.67765 8.46208C7.68285 8.46208 8.49297 9.38429 8.47567 10.509C8.47723 11.632 7.68285 12.5543 6.67765 12.5543ZM13.3223 12.5543C12.3344 12.5543 11.5243 11.632 11.5243 10.509C11.5243 9.38591 12.3171 8.46208 13.3223 8.46208C14.3275 8.46208 15.1376 9.38429 15.1203 10.509C15.1203 11.632 14.3275 12.5543 13.3223 12.5543Z" fill="#5865F2"/>
5: </g>
6: </g>
7: </svg>
```

## File: src/Aeq.CoreMvc.Web/wwwroot/images/getting-started/instagram.svg
```
 1: <svg width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
 2: <g clip-path="url(#clip0_425_4536)">
 3: <path d="M10.014 -0.00549316C5.8391 -0.00549316 4.6181 -0.00118628 4.38076 0.0185023C3.524 0.0897197 2.99087 0.224617 2.41005 0.513794C1.96244 0.73606 1.60943 0.993704 1.26104 1.35487C0.626541 2.01351 0.241998 2.82382 0.102793 3.78702C0.0351137 4.25463 0.0154251 4.35 0.0114258 6.73847C0.00988765 7.53463 0.0114258 8.58243 0.0114258 9.98786C0.0114258 14.1594 0.0160403 15.3792 0.0360366 15.616C0.105254 16.4497 0.235999 16.9742 0.51287 17.548C1.042 18.6462 2.05258 19.4707 3.24313 19.7783C3.65536 19.8845 4.11066 19.9429 4.69516 19.9706C4.94281 19.9814 7.46695 19.9891 9.99263 19.9891C12.5183 19.9891 15.044 19.986 15.2855 19.9737C15.9623 19.9418 16.3553 19.8891 16.7898 19.7768C17.988 19.4676 18.9802 18.6555 19.5201 17.5418C19.7916 16.9819 19.9292 16.4374 19.9915 15.6473C20.0051 15.475 20.0107 12.7283 20.0107 9.98524C20.0107 7.24176 20.0046 4.50012 19.9911 4.32785C19.928 3.52492 19.7903 2.98502 19.5101 2.41436C19.2801 1.94722 19.0248 1.59836 18.6541 1.24166C17.9925 0.609776 17.1834 0.225233 16.2193 0.0861819C15.7522 0.0186561 15.6591 -0.0013401 13.2688 -0.00549316H10.014Z" fill="url(#paint0_radial_425_4536)"/>
 4: <path d="M10.014 -0.00549316C5.8391 -0.00549316 4.6181 -0.00118628 4.38076 0.0185023C3.524 0.0897197 2.99087 0.224617 2.41005 0.513794C1.96244 0.73606 1.60943 0.993704 1.26104 1.35487C0.626541 2.01351 0.241998 2.82382 0.102793 3.78702C0.0351137 4.25463 0.0154251 4.35 0.0114258 6.73847C0.00988765 7.53463 0.0114258 8.58243 0.0114258 9.98786C0.0114258 14.1594 0.0160403 15.3792 0.0360366 15.616C0.105254 16.4497 0.235999 16.9742 0.51287 17.548C1.042 18.6462 2.05258 19.4707 3.24313 19.7783C3.65536 19.8845 4.11066 19.9429 4.69516 19.9706C4.94281 19.9814 7.46695 19.9891 9.99263 19.9891C12.5183 19.9891 15.044 19.986 15.2855 19.9737C15.9623 19.9418 16.3553 19.8891 16.7898 19.7768C17.988 19.4676 18.9802 18.6555 19.5201 17.5418C19.7916 16.9819 19.9292 16.4374 19.9915 15.6473C20.0051 15.475 20.0107 12.7283 20.0107 9.98524C20.0107 7.24176 20.0046 4.50012 19.9911 4.32785C19.928 3.52492 19.7903 2.98502 19.5101 2.41436C19.2801 1.94722 19.0248 1.59836 18.6541 1.24166C17.9925 0.609776 17.1834 0.225233 16.2193 0.0861819C15.7522 0.0186561 15.6591 -0.0013401 13.2688 -0.00549316H10.014Z" fill="url(#paint1_radial_425_4536)"/>
 5: <path d="M10.0093 2.60938C8.00417 2.60938 7.75252 2.61814 6.96498 2.65398C6.17897 2.68998 5.64246 2.81441 5.17301 2.99699C4.68741 3.18557 4.27549 3.43783 3.8651 3.84837C3.45441 4.25876 3.20215 4.67068 3.01295 5.15613C2.82991 5.62573 2.70532 6.1624 2.66994 6.9481C2.63472 7.73564 2.62549 7.98744 2.62549 9.9926C2.62549 11.9978 2.63441 12.2486 2.6701 13.0362C2.70624 13.8222 2.83068 14.3587 3.01311 14.8282C3.20184 15.3138 3.4541 15.7257 3.86464 16.1361C4.27487 16.5468 4.68679 16.7996 5.17209 16.9882C5.64184 17.1708 6.17851 17.2952 6.96436 17.3312C7.75191 17.3671 8.0034 17.3758 10.0084 17.3758C12.0137 17.3758 12.2646 17.3671 13.0521 17.3312C13.8381 17.2952 14.3753 17.1708 14.845 16.9882C15.3305 16.7996 15.7418 16.5468 16.152 16.1361C16.5627 15.7257 16.815 15.3138 17.0042 14.8283C17.1857 14.3587 17.3103 13.822 17.3472 13.0363C17.3826 12.2488 17.3918 11.9978 17.3918 9.9926C17.3918 7.98744 17.3826 7.7358 17.3472 6.94825C17.3103 6.16225 17.1857 5.62573 17.0042 5.15628C16.815 4.67068 16.5627 4.25876 16.152 3.84837C15.7413 3.43768 15.3306 3.18542 14.8446 2.99699C14.3739 2.81441 13.8371 2.68998 13.0511 2.65398C12.2635 2.61814 12.0128 2.60938 10.007 2.60938H10.0093ZM9.34699 3.93989C9.54357 3.93959 9.76291 3.93989 10.0093 3.93989C11.9807 3.93989 12.2143 3.94697 12.9928 3.98235C13.7126 4.01526 14.1033 4.13555 14.3636 4.23661C14.7081 4.37043 14.9538 4.5304 15.212 4.78881C15.4705 5.04722 15.6304 5.29333 15.7646 5.63788C15.8656 5.89783 15.9861 6.28853 16.0188 7.00839C16.0542 7.78671 16.0619 8.02051 16.0619 9.99091C16.0619 11.9613 16.0542 12.1951 16.0188 12.9734C15.9859 13.6933 15.8656 14.084 15.7646 14.3439C15.6307 14.6885 15.4705 14.9338 15.212 15.1921C14.9536 15.4505 14.7083 15.6105 14.3636 15.7443C14.1036 15.8458 13.7126 15.9658 12.9928 15.9987C12.2145 16.0341 11.9807 16.0418 10.0093 16.0418C8.03785 16.0418 7.80421 16.0341 7.02589 15.9987C6.30603 15.9655 5.91533 15.8452 5.65492 15.7441C5.31037 15.6103 5.06426 15.4503 4.80585 15.1919C4.54743 14.9335 4.38746 14.688 4.25334 14.3433C4.15228 14.0834 4.03184 13.6927 3.99908 12.9728C3.9637 12.1945 3.95662 11.9607 3.95662 9.98906C3.95662 8.01744 3.9637 7.78486 3.99908 7.00655C4.03199 6.28668 4.15228 5.89599 4.25334 5.63573C4.38716 5.29118 4.54743 5.04507 4.80585 4.78666C5.06426 4.52824 5.31037 4.36828 5.65492 4.23415C5.91518 4.13263 6.30603 4.01265 7.02589 3.97958C7.70699 3.94882 7.97094 3.93959 9.34699 3.93805V3.93989ZM13.9504 5.16582C13.4613 5.16582 13.0644 5.5622 13.0644 6.0515C13.0644 6.54064 13.4613 6.93748 13.9504 6.93748C14.4396 6.93748 14.8364 6.54064 14.8364 6.0515C14.8364 5.56236 14.4396 5.16551 13.9504 5.16551V5.16582ZM10.0093 6.20101C7.91542 6.20101 6.21774 7.89869 6.21774 9.9926C6.21774 12.0865 7.91542 13.7834 10.0093 13.7834C12.1032 13.7834 13.8003 12.0865 13.8003 9.9926C13.8003 7.89869 12.1032 6.20101 10.0093 6.20101ZM10.0093 7.53153C11.3685 7.53153 12.4704 8.63332 12.4704 9.9926C12.4704 11.3517 11.3685 12.4537 10.0093 12.4537C8.65005 12.4537 7.54825 11.3517 7.54825 9.9926C7.54825 8.63332 8.65005 7.53153 10.0093 7.53153Z" fill="white"/>
 6: </g>
 7: <defs>
 8: <radialGradient id="paint0_radial_425_4536" cx="0" cy="0" r="1" gradientUnits="userSpaceOnUse" gradientTransform="translate(5.32327 21.5291) rotate(-90) scale(19.8161 18.4355)">
 9: <stop stop-color="#FFDD55"/>
10: <stop offset="0.1" stop-color="#FFDD55"/>
11: <stop offset="0.5" stop-color="#FF543E"/>
12: <stop offset="1" stop-color="#C837AB"/>
13: </radialGradient>
14: <radialGradient id="paint1_radial_425_4536" cx="0" cy="0" r="1" gradientUnits="userSpaceOnUse" gradientTransform="translate(-3.33936 1.43488) rotate(78.6776) scale(8.85796 36.5221)">
15: <stop stop-color="#3771C8"/>
16: <stop offset="0.128" stop-color="#3771C8"/>
17: <stop offset="1" stop-color="#6600FF" stop-opacity="0"/>
18: </radialGradient>
19: <clipPath id="clip0_425_4536">
20: <rect width="20" height="20" fill="white"/>
21: </clipPath>
22: </defs>
23: </svg>
```

## File: src/Aeq.CoreMvc.Web/wwwroot/images/getting-started/stack-overflow.svg
```
1: <svg width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
2: <path d="M14.418 16.5774V12.291H15.8406V18H3V12.291H4.42263V16.5774H14.418Z" fill="#BCBBBB"/>
3: <path d="M5.99302 11.8845L12.9769 13.3441L13.2725 11.94L6.28863 10.4804L5.99302 11.8845ZM6.91681 8.55889L13.3833 11.5704L13.9745 10.2771L7.50803 7.24711L6.91681 8.55889ZM8.70896 5.38106L14.1963 9.94457L15.1016 8.8545L9.61427 4.29099L8.70896 5.38106ZM12.2563 2L11.1108 2.84988L15.3602 8.57737L16.5057 7.72748L12.2563 2ZM5.84521 15.1363H12.9769V13.7136H5.84521V15.1363Z" fill="#F48023"/>
4: </svg>
```

## File: src/Aeq.CoreMvc.Web/wwwroot/images/getting-started/x-white.svg
```
1: <svg width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
2: <path d="M11.5158 8.77569L17.4682 2H16.0582L10.8875 7.88203L6.76083 2H2L8.24173 10.8955L2 18H3.41003L8.86681 11.787L13.2258 18H17.9867M3.91893 3.04127H6.08513L16.0571 17.0099H13.8904" fill="white"/>
3: </svg>
```

## File: src/Aeq.CoreMvc.Web/wwwroot/images/getting-started/youtube.svg
```
 1: <svg width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
 2: <g clip-path="url(#clip0_425_4528)">
 3: <path d="M19.5818 5.18637C19.3513 4.32532 18.6746 3.64867 17.8136 3.41818C16.2545 3 9.99996 3 9.99996 3C9.99996 3 3.74547 3 2.18636 3.41818C1.32532 3.64867 0.648666 4.32532 0.418176 5.18637C1.25176e-07 6.74547 0 10.0003 0 10.0003C0 10.0003 1.25176e-07 13.2552 0.418176 14.8143C0.648666 15.6753 1.32532 16.352 2.18636 16.5825C3.74547 17.0007 9.99996 17.0007 9.99996 17.0007C9.99996 17.0007 16.2545 17.0007 17.8136 16.5825C18.6746 16.352 19.3513 15.6753 19.5818 14.8143C20 13.2552 20 10.0003 20 10.0003C20 10.0003 19.9983 6.74547 19.5818 5.18637Z" fill="#FF0000"/>
 4: <path d="M7.99854 13.0003L13.1945 10.0007L7.99854 7.00098V13.0003Z" fill="white"/>
 5: </g>
 6: <defs>
 7: <clipPath id="clip0_425_4528">
 8: <rect width="20" height="20" fill="white"/>
 9: </clipPath>
10: </defs>
11: </svg>
```

## File: src/Aeq.CoreMvc.Web/wwwroot/global-styles.css
```css
1: :root .lpx-brand-logo {
2:     --lpx-logo: url('/images/logo/leptonx/logo-light.png');
3:     --lpx-logo-icon: url('/images/logo/leptonx/logo-light-thumbnail.png');
4: }
```

## File: src/Aeq.CoreMvc.Web/abp.resourcemapping.js
```javascript
1: module.exports = {
2:     aliases: {
3:     },
4:     clean: [
5:     ],
6:     mappings: {
7:     }
8: };
```

## File: src/Aeq.CoreMvc.Web/Aeq.CoreMvc.Web.csproj
```
 1: <Project Sdk="Microsoft.NET.Sdk.Web">
 2: 
 3:   <Import Project="..\..\common.props" />
 4: 
 5:   <PropertyGroup>
 6:     <TargetFramework>net9.0</TargetFramework>
 7:     <Nullable>enable</Nullable>
 8:     <RootNamespace>Aeq.CoreMvc.Web</RootNamespace>
 9:     <AssetTargetFallback>$(AssetTargetFallback);portable-net45+win8+wp8+wpa81;</AssetTargetFallback>
10:     <AutoGenerateBindingRedirects>true</AutoGenerateBindingRedirects>
11:     <GenerateBindingRedirectsOutputType>true</GenerateBindingRedirectsOutputType>
12:     <GenerateRuntimeConfigurationFiles>true</GenerateRuntimeConfigurationFiles>
13:     <MvcRazorExcludeRefAssembliesFromPublish>false</MvcRazorExcludeRefAssembliesFromPublish>
14:     <PreserveCompilationReferences>true</PreserveCompilationReferences>
15:     <UserSecretsId>Aeq.CoreMvc-4681b4fd-151f-4221-84a4-929d86723e4c</UserSecretsId>
16:   </PropertyGroup>
17: 
18:   <ItemGroup>
19:     <Compile Remove="Logs\**" />
20:     <Content Remove="Logs\**" />
21:     <EmbeddedResource Remove="Logs\**" />
22:     <None Remove="Logs\**" />
23:   </ItemGroup>
24: 
25:   <ItemGroup>
26:     <None Update="Pages\**\*.js">
27:       <CopyToOutputDirectory>Always</CopyToOutputDirectory>
28:     </None>
29:     <None Update="Pages\**\*.css">
30:       <CopyToOutputDirectory>Always</CopyToOutputDirectory>
31:     </None>
32:   </ItemGroup>
33: 
34:   <ItemGroup Condition="Exists('./openiddict.pfx')">
35:     <None Remove="openiddict.pfx" />
36:     <EmbeddedResource Include="openiddict.pfx">
37:       <CopyToOutputDirectory>Always</CopyToOutputDirectory>
38:     </EmbeddedResource>
39:   </ItemGroup>
40: 
41:   <ItemGroup>
42:     <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="9.0.0">
43:       <PrivateAssets>all</PrivateAssets>
44:       <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
45:     </PackageReference>
46:     <PackageReference Include="Serilog.AspNetCore" Version="8.0.2" />
47:     <PackageReference Include="Serilog.Sinks.Async" Version="2.0.0" />
48:   </ItemGroup>
49: 
50:   <ItemGroup>
51:     <PackageReference Include="Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite" Version="3.2.0" />
52:   </ItemGroup>
53: 
54:   <ItemGroup>
55:     <ProjectReference Include="..\Aeq.CoreMvc.Application\Aeq.CoreMvc.Application.csproj" />
56:     <ProjectReference Include="..\Aeq.CoreMvc.HttpApi\Aeq.CoreMvc.HttpApi.csproj" />
57:     <ProjectReference Include="..\Aeq.CoreMvc.EntityFrameworkCore\Aeq.CoreMvc.EntityFrameworkCore.csproj" />
58:     <PackageReference Include="Volo.Abp.Autofac" Version="9.0.8" />
59:     <PackageReference Include="Volo.Abp.Swashbuckle" Version="9.0.8" />
60:     <PackageReference Include="Volo.Abp.AspNetCore.Serilog" Version="9.0.8" />
61:     <PackageReference Include="Volo.Abp.Identity.Web" Version="9.0.8" />
62:     <PackageReference Include="Volo.Abp.Account.Web.OpenIddict" Version="9.0.8" />
63:     <PackageReference Include="Volo.Abp.TenantManagement.Web" Version="9.0.8" />
64:     <PackageReference Include="Volo.Abp.SettingManagement.Web" Version="9.0.8" />
65:   </ItemGroup>
66: 
67: </Project>
```

## File: src/Aeq.CoreMvc.Web/appsettings.Development.json
```json
1: {
2: }
```

## File: src/Aeq.CoreMvc.Web/appsettings.json
```json
 1: {
 2:   "App": {
 3:     "SelfUrl": "https://localhost:44313"
 4:   },
 5:   "ConnectionStrings": {
 6:     "Default": "Server=localhost;Port=3306;Database=CoreMvc;Uid=root;Pwd=123456a@;"
 7:   },
 8:   "StringEncryption": {
 9:     "DefaultPassPhrase": "YjkFEGraKqfQ10z7"
10:   }
11: }
```

## File: src/Aeq.CoreMvc.Web/appsettings.secrets.json
```json
1: {
2: }
```

## File: src/Aeq.CoreMvc.Web/CoreMvcBrandingProvider.cs
```csharp
 1: using Microsoft.Extensions.Localization;
 2: using Aeq.CoreMvc.Localization;
 3: using Volo.Abp.Ui.Branding;
 4: using Volo.Abp.DependencyInjection;
 5: namespace Aeq.CoreMvc.Web;
 6: [Dependency(ReplaceServices = true)]
 7: public class CoreMvcBrandingProvider : DefaultBrandingProvider
 8: {
 9:     private IStringLocalizer<CoreMvcResource> _localizer;
10:     public CoreMvcBrandingProvider(IStringLocalizer<CoreMvcResource> localizer)
11:     {
12:         _localizer = localizer;
13:     }
14:     public override string AppName => _localizer["AppName"];
15: }
```

## File: src/Aeq.CoreMvc.Web/CoreMvcWebAutoMapperProfile.cs
```csharp
 1: using Aeq.CoreMvc.Books.Dtos;
 2: using Aeq.CoreMvc.Web.Pages.Books.Book.ViewModels;
 3: using Aeq.CoreMvc.Books.Dtos;
 4: using Aeq.CoreMvc.Web.Pages.Books.Author.ViewModels;
 5: using AutoMapper;
 6: namespace Aeq.CoreMvc.Web;
 7: public class CoreMvcWebAutoMapperProfile : Profile
 8: {
 9:     public CoreMvcWebAutoMapperProfile()
10:     {
11:         CreateMap<BookDto, CreateEditBookViewModel>();
12:         CreateMap<CreateEditBookViewModel, CreateUpdateBookDto>();
13:         CreateMap<AuthorDto, CreateEditAuthorViewModel>();
14:         CreateMap<CreateEditAuthorViewModel, CreateUpdateAuthorDto>();
15:     }
16: }
```

## File: src/Aeq.CoreMvc.Web/CoreMvcWebModule.cs
```csharp
  1: using System;
  2: using System.IO;
  3: using Microsoft.AspNetCore.Builder;
  4: using Microsoft.AspNetCore.Extensions.DependencyInjection;
  5: using Microsoft.AspNetCore.Hosting;
  6: using Microsoft.Extensions.Configuration;
  7: using Microsoft.Extensions.DependencyInjection;
  8: using Microsoft.Extensions.Hosting;
  9: using Aeq.CoreMvc.EntityFrameworkCore;
 10: using Aeq.CoreMvc.Localization;
 11: using Aeq.CoreMvc.MultiTenancy;
 12: using Aeq.CoreMvc.Web.Menus;
 13: using Microsoft.OpenApi.Models;
 14: using OpenIddict.Validation.AspNetCore;
 15: using Volo.Abp;
 16: using Volo.Abp.Account.Web;
 17: using Volo.Abp.AspNetCore.Mvc;
 18: using Volo.Abp.AspNetCore.Mvc.Localization;
 19: using Volo.Abp.AspNetCore.Mvc.UI;
 20: using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap;
 21: using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
 22: using Volo.Abp.AspNetCore.Mvc.UI.MultiTenancy;
 23: using Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite;
 24: using Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.Bundling;
 25: using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
 26: using Volo.Abp.AspNetCore.Serilog;
 27: using Volo.Abp.Autofac;
 28: using Volo.Abp.AutoMapper;
 29: using Volo.Abp.FeatureManagement;
 30: using Volo.Abp.Identity.Web;
 31: using Volo.Abp.Localization;
 32: using Volo.Abp.Modularity;
 33: using Volo.Abp.PermissionManagement.Web;
 34: using Volo.Abp.Security.Claims;
 35: using Volo.Abp.SettingManagement.Web;
 36: using Volo.Abp.Swashbuckle;
 37: using Volo.Abp.TenantManagement.Web;
 38: using Volo.Abp.OpenIddict;
 39: using Volo.Abp.UI.Navigation.Urls;
 40: using Volo.Abp.UI;
 41: using Volo.Abp.UI.Navigation;
 42: using Volo.Abp.VirtualFileSystem;
 43: namespace Aeq.CoreMvc.Web;
 44: [DependsOn(
 45:     typeof(CoreMvcHttpApiModule),
 46:     typeof(CoreMvcApplicationModule),
 47:     typeof(CoreMvcEntityFrameworkCoreModule),
 48:     typeof(AbpAutofacModule),
 49:     typeof(AbpIdentityWebModule),
 50:     typeof(AbpSettingManagementWebModule),
 51:     typeof(AbpAccountWebOpenIddictModule),
 52:     typeof(AbpAspNetCoreMvcUiLeptonXLiteThemeModule),
 53:     typeof(AbpTenantManagementWebModule),
 54:     typeof(AbpAspNetCoreSerilogModule),
 55:     typeof(AbpSwashbuckleModule)
 56:     )]
 57: public class CoreMvcWebModule : AbpModule
 58: {
 59:     public override void PreConfigureServices(ServiceConfigurationContext context)
 60:     {
 61:         var hostingEnvironment = context.Services.GetHostingEnvironment();
 62:         var configuration = context.Services.GetConfiguration();
 63:         context.Services.PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
 64:         {
 65:             options.AddAssemblyResource(
 66:                 typeof(CoreMvcResource),
 67:                 typeof(CoreMvcDomainModule).Assembly,
 68:                 typeof(CoreMvcDomainSharedModule).Assembly,
 69:                 typeof(CoreMvcApplicationModule).Assembly,
 70:                 typeof(CoreMvcApplicationContractsModule).Assembly,
 71:                 typeof(CoreMvcWebModule).Assembly
 72:             );
 73:         });
 74:         PreConfigure<OpenIddictBuilder>(builder =>
 75:         {
 76:             builder.AddValidation(options =>
 77:             {
 78:                 options.AddAudiences("CoreMvc");
 79:                 options.UseLocalServer();
 80:                 options.UseAspNetCore();
 81:             });
 82:         });
 83:         if (!hostingEnvironment.IsDevelopment())
 84:         {
 85:             PreConfigure<AbpOpenIddictAspNetCoreOptions>(options =>
 86:             {
 87:                 options.AddDevelopmentEncryptionAndSigningCertificate = false;
 88:             });
 89:             PreConfigure<OpenIddictServerBuilder>(serverBuilder =>
 90:             {
 91:                 serverBuilder.AddProductionEncryptionAndSigningCertificate("openiddict.pfx", "1507ab07-bfb3-470e-9d9d-23fcb7ae1845");
 92:             });
 93:         }
 94:     }
 95:     public override void ConfigureServices(ServiceConfigurationContext context)
 96:     {
 97:         var hostingEnvironment = context.Services.GetHostingEnvironment();
 98:         var configuration = context.Services.GetConfiguration();
 99:         ConfigureAuthentication(context);
100:         ConfigureUrls(configuration);
101:         ConfigureBundles();
102:         ConfigureAutoMapper();
103:         ConfigureVirtualFileSystem(hostingEnvironment);
104:         ConfigureNavigationServices();
105:         ConfigureAutoApiControllers();
106:         ConfigureSwaggerServices(context.Services);
107:     }
108:     private void ConfigureAuthentication(ServiceConfigurationContext context)
109:     {
110:         context.Services.ForwardIdentityAuthenticationForBearer(OpenIddictValidationAspNetCoreDefaults.AuthenticationScheme);
111:         context.Services.Configure<AbpClaimsPrincipalFactoryOptions>(options =>
112:         {
113:             options.IsDynamicClaimsEnabled = true;
114:         });
115:     }
116:     private void ConfigureUrls(IConfiguration configuration)
117:     {
118:         Configure<AppUrlOptions>(options =>
119:         {
120:             options.Applications["MVC"].RootUrl = configuration["App:SelfUrl"];
121:         });
122:     }
123:     private void ConfigureBundles()
124:     {
125:         Configure<AbpBundlingOptions>(options =>
126:         {
127:             options.StyleBundles.Configure(
128:                 LeptonXLiteThemeBundles.Styles.Global,
129:                 bundle =>
130:                 {
131:                     bundle.AddFiles("/global-styles.css");
132:                 }
133:             );
134:         });
135:     }
136:     private void ConfigureAutoMapper()
137:     {
138:         Configure<AbpAutoMapperOptions>(options =>
139:         {
140:             options.AddMaps<CoreMvcWebModule>();
141:         });
142:     }
143:     private void ConfigureVirtualFileSystem(IWebHostEnvironment hostingEnvironment)
144:     {
145:         if (hostingEnvironment.IsDevelopment())
146:         {
147:             Configure<AbpVirtualFileSystemOptions>(options =>
148:             {
149:                 options.FileSets.ReplaceEmbeddedByPhysical<CoreMvcDomainSharedModule>(Path.Combine(hostingEnvironment.ContentRootPath, $"..{Path.DirectorySeparatorChar}Aeq.CoreMvc.Domain.Shared"));
150:                 options.FileSets.ReplaceEmbeddedByPhysical<CoreMvcDomainModule>(Path.Combine(hostingEnvironment.ContentRootPath, $"..{Path.DirectorySeparatorChar}Aeq.CoreMvc.Domain"));
151:                 options.FileSets.ReplaceEmbeddedByPhysical<CoreMvcApplicationContractsModule>(Path.Combine(hostingEnvironment.ContentRootPath, $"..{Path.DirectorySeparatorChar}Aeq.CoreMvc.Application.Contracts"));
152:                 options.FileSets.ReplaceEmbeddedByPhysical<CoreMvcApplicationModule>(Path.Combine(hostingEnvironment.ContentRootPath, $"..{Path.DirectorySeparatorChar}Aeq.CoreMvc.Application"));
153:                 options.FileSets.ReplaceEmbeddedByPhysical<CoreMvcWebModule>(hostingEnvironment.ContentRootPath);
154:             });
155:         }
156:     }
157:     private void ConfigureNavigationServices()
158:     {
159:         Configure<AbpNavigationOptions>(options =>
160:         {
161:             options.MenuContributors.Add(new CoreMvcMenuContributor());
162:         });
163:     }
164:     private void ConfigureAutoApiControllers()
165:     {
166:         Configure<AbpAspNetCoreMvcOptions>(options =>
167:         {
168:             options.ConventionalControllers.Create(typeof(CoreMvcApplicationModule).Assembly);
169:         });
170:     }
171:     private void ConfigureSwaggerServices(IServiceCollection services)
172:     {
173:         services.AddAbpSwaggerGen(
174:             options =>
175:             {
176:                 options.SwaggerDoc("v1", new OpenApiInfo { Title = "CoreMvc API", Version = "v1" });
177:                 options.DocInclusionPredicate((docName, description) => true);
178:                 options.CustomSchemaIds(type => type.FullName);
179:             }
180:         );
181:     }
182:     public override void OnApplicationInitialization(ApplicationInitializationContext context)
183:     {
184:         var app = context.GetApplicationBuilder();
185:         var env = context.GetEnvironment();
186:         if (env.IsDevelopment())
187:         {
188:             app.UseDeveloperExceptionPage();
189:         }
190:         app.UseAbpRequestLocalization();
191:         if (!env.IsDevelopment())
192:         {
193:             app.UseErrorPage();
194:         }
195:         app.UseCorrelationId();
196:         app.MapAbpStaticAssets();
197:         app.UseRouting();
198:         app.UseAuthentication();
199:         app.UseAbpOpenIddictValidation();
200:         if (MultiTenancyConsts.IsEnabled)
201:         {
202:             app.UseMultiTenancy();
203:         }
204:         app.UseUnitOfWork();
205:         app.UseDynamicClaims();
206:         app.UseAuthorization();
207:         app.UseSwagger();
208:         app.UseAbpSwaggerUI(options =>
209:         {
210:             options.SwaggerEndpoint("/swagger/v1/swagger.json", "CoreMvc API");
211:         });
212:         app.UseAuditing();
213:         app.UseAbpSerilogEnrichers();
214:         app.UseConfiguredEndpoints();
215:     }
216: }
```

## File: src/Aeq.CoreMvc.Web/package.json
```json
1: {
2:   "version": "1.0.0",
3:   "name": "my-app",
4:   "private": true,
5:   "dependencies": {
6:     "@abp/aspnetcore.mvc.ui.theme.leptonxlite": "~4.0.9"
7:   }
8: }
```

## File: src/Aeq.CoreMvc.Web/Program.cs
```csharp
 1: using System;
 2: using System.Threading.Tasks;
 3: using Microsoft.AspNetCore.Builder;
 4: using Microsoft.Extensions.DependencyInjection;
 5: using Microsoft.Extensions.Hosting;
 6: using Serilog;
 7: using Serilog.Events;
 8: namespace Aeq.CoreMvc.Web;
 9: public class Program
10: {
11:     public async static Task<int> Main(string[] args)
12:     {
13:         Log.Logger = new LoggerConfiguration()
14: #if DEBUG
15:             .MinimumLevel.Debug()
16: #else
17:             .MinimumLevel.Information()
18: #endif
19:             .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
20:             .MinimumLevel.Override("Microsoft.EntityFrameworkCore", LogEventLevel.Warning)
21:             .Enrich.FromLogContext()
22:             .WriteTo.Async(c => c.File("Logs/logs.txt"))
23:             .WriteTo.Async(c => c.Console())
24:             .CreateLogger();
25:         try
26:         {
27:             Log.Information("Starting web host.");
28:             var builder = WebApplication.CreateBuilder(args);
29:             builder.Host.AddAppSettingsSecretsJson()
30:                 .UseAutofac()
31:                 .UseSerilog();
32:             await builder.AddApplicationAsync<CoreMvcWebModule>();
33:             var app = builder.Build();
34:             await app.InitializeApplicationAsync();
35:             await app.RunAsync();
36:             return 0;
37:         }
38:         catch (Exception ex)
39:         {
40:             if (ex is HostAbortedException)
41:             {
42:                 throw;
43:             }
44:             Log.Fatal(ex, "Host terminated unexpectedly!");
45:             return 1;
46:         }
47:         finally
48:         {
49:             Log.CloseAndFlush();
50:         }
51:     }
52: }
```

## File: src/Aeq.CoreMvc.Web/web.config
```
 1: <?xml version="1.0" encoding="utf-8"?>
 2: <configuration>
 3:   <location path="." inheritInChildApplications="false">
 4:     <system.webServer>
 5:       <handlers>
 6:         <add name="aspNetCore" path="*" verb="*" modules="AspNetCoreModuleV2" resourceType="Unspecified" />
 7:       </handlers>
 8:       <aspNetCore processPath="dotnet" arguments=".\Aeq.CoreMvc.Web.dll" stdoutLogEnabled="false" stdoutLogFile=".\Logs\stdout" hostingModel="inprocess" />
 9:     </system.webServer>
10:   </location>
11:   <system.webServer>
12:     <httpProtocol>
13:       <customHeaders>
14:         <remove name="x-powered-by" />
15:       </customHeaders>
16:     </httpProtocol>
17:   </system.webServer>
18: </configuration>
```

## File: test/Aeq.CoreMvc.Application.Tests/Books/BookAppServiceTests.cs
```csharp
 1: using Shouldly;
 2: using System.Threading.Tasks;
 3: using Xunit;
 4: namespace Aeq.CoreMvc.Books;
 5: public class BookAppServiceTests : CoreMvcApplicationTestBase
 6: {
 7:     private readonly IBookAppService _bookAppService;
 8:     public BookAppServiceTests()
 9:     {
10:         _bookAppService = GetRequiredService<IBookAppService>();
11:     }
12: }
```

## File: test/Aeq.CoreMvc.Application.Tests/Samples/SampleAppServiceTests.cs
```csharp
 1: using Shouldly;
 2: using System.Threading.Tasks;
 3: using Volo.Abp.Identity;
 4: using Volo.Abp.Modularity;
 5: using Xunit;
 6: namespace Aeq.CoreMvc.Samples;
 7: public abstract class SampleAppServiceTests<TStartupModule> : CoreMvcApplicationTestBase<TStartupModule>
 8:     where TStartupModule : IAbpModule
 9: {
10:     private readonly IIdentityUserAppService _userAppService;
11:     protected SampleAppServiceTests()
12:     {
13:         _userAppService = GetRequiredService<IIdentityUserAppService>();
14:     }
15:     [Fact]
16:     public async Task Initial_Data_Should_Contain_Admin_User()
17:     {
18:         var result = await _userAppService.GetListAsync(new GetIdentityUsersInput());
19:         result.TotalCount.ShouldBeGreaterThan(0);
20:         result.Items.ShouldContain(u => u.UserName == "admin");
21:     }
22: }
```

## File: test/Aeq.CoreMvc.Application.Tests/Aeq.CoreMvc.Application.Tests.csproj
```
 1: <Project Sdk="Microsoft.NET.Sdk">
 2: 
 3:   <Import Project="..\..\common.props" />
 4: 
 5:   <PropertyGroup>
 6:     <TargetFramework>net9.0</TargetFramework>
 7:     <Nullable>enable</Nullable>
 8:     <RootNamespace>Aeq.CoreMvc</RootNamespace>
 9:   </PropertyGroup>
10: 
11:   <ItemGroup>
12:     <ProjectReference Include="..\..\src\Aeq.CoreMvc.Application\Aeq.CoreMvc.Application.csproj" />
13:     <ProjectReference Include="..\Aeq.CoreMvc.Domain.Tests\Aeq.CoreMvc.Domain.Tests.csproj" />
14:   </ItemGroup>
15: 
16:   <ItemGroup>
17:     <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.11.1.0" />
18:   </ItemGroup>
19: 
20: </Project>
```

## File: test/Aeq.CoreMvc.Application.Tests/CoreMvcApplicationTestBase.cs
```csharp
1: using Volo.Abp.Modularity;
2: namespace Aeq.CoreMvc;
3: public abstract class CoreMvcApplicationTestBase<TStartupModule> : CoreMvcTestBase<TStartupModule>
4:     where TStartupModule : IAbpModule
5: {
6: }
```

## File: test/Aeq.CoreMvc.Application.Tests/CoreMvcApplicationTestModule.cs
```csharp
1: using Volo.Abp.Modularity;
2: namespace Aeq.CoreMvc;
3: [DependsOn(
4:     typeof(CoreMvcApplicationModule),
5:     typeof(CoreMvcDomainTestModule)
6: )]
7: public class CoreMvcApplicationTestModule : AbpModule
8: {
9: }
```

## File: test/Aeq.CoreMvc.Domain.Tests/Books/BookDomainTests.cs
```csharp
 1: using System.Threading.Tasks;
 2: using Shouldly;
 3: using Xunit;
 4: namespace Aeq.CoreMvc.Books;
 5: public class BookDomainTests : CoreMvcDomainTestBase
 6: {
 7:     public BookDomainTests()
 8:     {
 9:     }
10: }
```

## File: test/Aeq.CoreMvc.Domain.Tests/Samples/SampleDomainTests.cs
```csharp
 1: using System.Threading.Tasks;
 2: using Shouldly;
 3: using Volo.Abp.Identity;
 4: using Volo.Abp.Modularity;
 5: using Xunit;
 6: namespace Aeq.CoreMvc.Samples;
 7: public abstract class SampleDomainTests<TStartupModule> : CoreMvcDomainTestBase<TStartupModule>
 8:     where TStartupModule : IAbpModule
 9: {
10:     private readonly IIdentityUserRepository _identityUserRepository;
11:     private readonly IdentityUserManager _identityUserManager;
12:     protected SampleDomainTests()
13:     {
14:         _identityUserRepository = GetRequiredService<IIdentityUserRepository>();
15:         _identityUserManager = GetRequiredService<IdentityUserManager>();
16:     }
17:     [Fact]
18:     public async Task Should_Set_Email_Of_A_User()
19:     {
20:         IdentityUser adminUser;
21:         await WithUnitOfWorkAsync(async () =>
22:         {
23:             adminUser = await _identityUserRepository
24:                 .FindByNormalizedUserNameAsync("ADMIN");
25:             await _identityUserManager.SetEmailAsync(adminUser, "newemail@abp.io");
26:             await _identityUserRepository.UpdateAsync(adminUser);
27:         });
28:         adminUser = await _identityUserRepository.FindByNormalizedUserNameAsync("ADMIN");
29:         adminUser.Email.ShouldBe("newemail@abp.io");
30:     }
31: }
```

## File: test/Aeq.CoreMvc.Domain.Tests/Aeq.CoreMvc.Domain.Tests.csproj
```
 1: <Project Sdk="Microsoft.NET.Sdk">
 2: 
 3:   <Import Project="..\..\common.props" />
 4: 
 5:   <PropertyGroup>
 6:     <TargetFramework>net9.0</TargetFramework>
 7:     <Nullable>enable</Nullable>
 8:     <RootNamespace>Aeq.CoreMvc</RootNamespace>
 9:   </PropertyGroup>
10: 
11:   <ItemGroup>
12:     <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.11.1.0" />
13:   </ItemGroup>
14: 
15:   <ItemGroup>
16:     <ProjectReference Include="..\..\src\Aeq.CoreMvc.Domain\Aeq.CoreMvc.Domain.csproj" />
17:     <ProjectReference Include="..\Aeq.CoreMvc.TestBase\Aeq.CoreMvc.TestBase.csproj" />
18:   </ItemGroup>
19: 
20: </Project>
```

## File: test/Aeq.CoreMvc.Domain.Tests/CoreMvcDomainTestBase.cs
```csharp
1: using Volo.Abp.Modularity;
2: namespace Aeq.CoreMvc;
3: public abstract class CoreMvcDomainTestBase<TStartupModule> : CoreMvcTestBase<TStartupModule>
4:     where TStartupModule : IAbpModule
5: {
6: }
```

## File: test/Aeq.CoreMvc.Domain.Tests/CoreMvcDomainTestModule.cs
```csharp
1: using Volo.Abp.Modularity;
2: namespace Aeq.CoreMvc;
3: [DependsOn(
4:     typeof(CoreMvcDomainModule),
5:     typeof(CoreMvcTestBaseModule)
6: )]
7: public class CoreMvcDomainTestModule : AbpModule
8: {
9: }
```

## File: test/Aeq.CoreMvc.EntityFrameworkCore.Tests/EntityFrameworkCore/Applications/EfCoreSampleAppServiceTests.cs
```csharp
1: using Aeq.CoreMvc.Samples;
2: using Xunit;
3: namespace Aeq.CoreMvc.EntityFrameworkCore.Applications;
4: [Collection(CoreMvcTestConsts.CollectionDefinitionName)]
5: public class EfCoreSampleAppServiceTests : SampleAppServiceTests<CoreMvcEntityFrameworkCoreTestModule>
6: {
7: }
```

## File: test/Aeq.CoreMvc.EntityFrameworkCore.Tests/EntityFrameworkCore/Books/BookRepositoryTests.cs
```csharp
 1: using System;
 2: using System.Threading.Tasks;
 3: using Aeq.CoreMvc.Books;
 4: using Volo.Abp.Domain.Repositories;
 5: using Xunit;
 6: namespace Aeq.CoreMvc.EntityFrameworkCore.Books;
 7: public class BookRepositoryTests : CoreMvcEntityFrameworkCoreTestBase
 8: {
 9:     private readonly IBookRepository _bookRepository;
10:     public BookRepositoryTests()
11:     {
12:         _bookRepository = GetRequiredService<IBookRepository>();
13:     }
14: }
```

## File: test/Aeq.CoreMvc.EntityFrameworkCore.Tests/EntityFrameworkCore/Domains/EfCoreSampleDomainTests.cs
```csharp
1: using Aeq.CoreMvc.Samples;
2: using Xunit;
3: namespace Aeq.CoreMvc.EntityFrameworkCore.Domains;
4: [Collection(CoreMvcTestConsts.CollectionDefinitionName)]
5: public class EfCoreSampleDomainTests : SampleDomainTests<CoreMvcEntityFrameworkCoreTestModule>
6: {
7: }
```

## File: test/Aeq.CoreMvc.EntityFrameworkCore.Tests/EntityFrameworkCore/Samples/SampleRepositoryTests.cs
```csharp
 1: using Microsoft.EntityFrameworkCore;
 2: using Shouldly;
 3: using System;
 4: using System.Linq;
 5: using System.Threading.Tasks;
 6: using Volo.Abp.Domain.Repositories;
 7: using Volo.Abp.Identity;
 8: using Xunit;
 9: namespace Aeq.CoreMvc.EntityFrameworkCore.Samples;
10: [Collection(CoreMvcTestConsts.CollectionDefinitionName)]
11: public class SampleRepositoryTests : CoreMvcEntityFrameworkCoreTestBase
12: {
13:     private readonly IRepository<IdentityUser, Guid> _appUserRepository;
14:     public SampleRepositoryTests()
15:     {
16:         _appUserRepository = GetRequiredService<IRepository<IdentityUser, Guid>>();
17:     }
18:     [Fact]
19:     public async Task Should_Query_AppUser()
20:     {
21:         await WithUnitOfWorkAsync(async () =>
22:         {
23:                 var adminUser = await (await _appUserRepository.GetQueryableAsync())
24:                 .Where(u => u.UserName == "admin")
25:                 .FirstOrDefaultAsync();
26:                 adminUser.ShouldNotBeNull();
27:         });
28:     }
29: }
```

## File: test/Aeq.CoreMvc.EntityFrameworkCore.Tests/EntityFrameworkCore/CoreMvcEntityFrameworkCoreCollection.cs
```csharp
1: using Xunit;
2: namespace Aeq.CoreMvc.EntityFrameworkCore;
3: [CollectionDefinition(CoreMvcTestConsts.CollectionDefinitionName)]
4: public class CoreMvcEntityFrameworkCoreCollection : ICollectionFixture<CoreMvcEntityFrameworkCoreFixture>
5: {
6: }
```

## File: test/Aeq.CoreMvc.EntityFrameworkCore.Tests/EntityFrameworkCore/CoreMvcEntityFrameworkCoreCollectionFixtureBase.cs
```csharp
1: using Aeq.CoreMvc.EntityFrameworkCore;
2: using Xunit;
3: namespace Aeq.CoreMvc.EntityFrameworkCore;
4: public class CoreMvcEntityFrameworkCoreCollectionFixtureBase : ICollectionFixture<CoreMvcEntityFrameworkCoreFixture>
5: {
6: }
```

## File: test/Aeq.CoreMvc.EntityFrameworkCore.Tests/EntityFrameworkCore/CoreMvcEntityFrameworkCoreFixture.cs
```csharp
1: using System;
2: namespace Aeq.CoreMvc.EntityFrameworkCore;
3: public class CoreMvcEntityFrameworkCoreFixture : IDisposable
4: {
5:     public void Dispose()
6:     {
7:     }
8: }
```

## File: test/Aeq.CoreMvc.EntityFrameworkCore.Tests/EntityFrameworkCore/CoreMvcEntityFrameworkCoreTestBase.cs
```csharp
1: using Volo.Abp;
2: namespace Aeq.CoreMvc.EntityFrameworkCore;
3: public abstract class CoreMvcEntityFrameworkCoreTestBase : CoreMvcTestBase<CoreMvcEntityFrameworkCoreTestModule>
4: {
5: }
```

## File: test/Aeq.CoreMvc.EntityFrameworkCore.Tests/EntityFrameworkCore/CoreMvcEntityFrameworkCoreTestModule.cs
```csharp
 1: using Microsoft.Data.Sqlite;
 2: using Microsoft.EntityFrameworkCore;
 3: using Microsoft.EntityFrameworkCore.Infrastructure;
 4: using Microsoft.EntityFrameworkCore.Storage;
 5: using Microsoft.Extensions.DependencyInjection;
 6: using Volo.Abp;
 7: using Volo.Abp.EntityFrameworkCore;
 8: using Volo.Abp.EntityFrameworkCore.Sqlite;
 9: using Volo.Abp.FeatureManagement;
10: using Volo.Abp.Modularity;
11: using Volo.Abp.PermissionManagement;
12: using Volo.Abp.SettingManagement;
13: using Volo.Abp.Uow;
14: namespace Aeq.CoreMvc.EntityFrameworkCore;
15: [DependsOn(
16:     typeof(CoreMvcApplicationTestModule),
17:     typeof(CoreMvcEntityFrameworkCoreModule),
18:     typeof(AbpEntityFrameworkCoreSqliteModule)
19:     )]
20: public class CoreMvcEntityFrameworkCoreTestModule : AbpModule
21: {
22:     private SqliteConnection? _sqliteConnection;
23:     public override void ConfigureServices(ServiceConfigurationContext context)
24:     {
25:         Configure<FeatureManagementOptions>(options =>
26:         {
27:             options.SaveStaticFeaturesToDatabase = false;
28:             options.IsDynamicFeatureStoreEnabled = false;
29:         });
30:         Configure<PermissionManagementOptions>(options =>
31:         {
32:             options.SaveStaticPermissionsToDatabase = false;
33:             options.IsDynamicPermissionStoreEnabled = false;
34:         });
35:         Configure<SettingManagementOptions>(options =>
36:         {
37:             options.SaveStaticSettingsToDatabase = false;
38:             options.IsDynamicSettingStoreEnabled = false;
39:         });
40:         context.Services.AddAlwaysDisableUnitOfWorkTransaction();
41:         ConfigureInMemorySqlite(context.Services);
42:     }
43:     private void ConfigureInMemorySqlite(IServiceCollection services)
44:     {
45:         _sqliteConnection = CreateDatabaseAndGetConnection();
46:         services.Configure<AbpDbContextOptions>(options =>
47:         {
48:             options.Configure(context =>
49:             {
50:                 context.DbContextOptions.UseSqlite(_sqliteConnection);
51:             });
52:         });
53:     }
54:     public override void OnApplicationShutdown(ApplicationShutdownContext context)
55:     {
56:         _sqliteConnection?.Dispose();
57:     }
58:     private static SqliteConnection CreateDatabaseAndGetConnection()
59:     {
60:         var connection = new AbpUnitTestSqliteConnection("Data Source=:memory:");
61:         connection.Open();
62:         var options = new DbContextOptionsBuilder<CoreMvcDbContext>()
63:             .UseSqlite(connection)
64:             .Options;
65:         using (var context = new CoreMvcDbContext(options))
66:         {
67:             context.GetService<IRelationalDatabaseCreator>().CreateTables();
68:         }
69:         return connection;
70:     }
71: }
```

## File: test/Aeq.CoreMvc.EntityFrameworkCore.Tests/Aeq.CoreMvc.EntityFrameworkCore.Tests.csproj
```
 1: <Project Sdk="Microsoft.NET.Sdk">
 2: 
 3:   <Import Project="..\..\common.props" />
 4: 
 5:   <PropertyGroup>
 6:     <TargetFramework>net9.0</TargetFramework>
 7:     <Nullable>enable</Nullable>
 8:     <RootNamespace>Aeq.CoreMvc</RootNamespace>
 9:   </PropertyGroup>
10: 
11:   <ItemGroup>
12:     <ProjectReference Include="..\..\src\Aeq.CoreMvc.EntityFrameworkCore\Aeq.CoreMvc.EntityFrameworkCore.csproj" />
13:     <ProjectReference Include="..\Aeq.CoreMvc.Application.Tests\Aeq.CoreMvc.Application.Tests.csproj" />
14:     <PackageReference Include="Volo.Abp.EntityFrameworkCore.Sqlite" Version="9.0.8" />
15:   </ItemGroup>
16: 
17:   <ItemGroup>
18:     <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.11.1.0" />
19:   </ItemGroup>
20: 
21: </Project>
```

## File: test/Aeq.CoreMvc.HttpApi.Client.ConsoleTestApp/Aeq.CoreMvc.HttpApi.Client.ConsoleTestApp.csproj
```
 1: <Project Sdk="Microsoft.NET.Sdk">
 2: 
 3:   <PropertyGroup>
 4:     <OutputType>Exe</OutputType>
 5:     <TargetFramework>net9.0</TargetFramework>
 6:     <Nullable>enable</Nullable>
 7:   </PropertyGroup>
 8: 
 9:   <ItemGroup>
10:     <None Remove="appsettings.json" />
11:     <Content Include="appsettings.json">
12:       <CopyToPublishDirectory>PreserveNewest</CopyToPublishDirectory>
13:       <CopyToOutputDirectory>Always</CopyToOutputDirectory>
14:     </Content>
15:     <None Remove="appsettings.secrets.json" />
16:     <Content Include="appsettings.secrets.json">
17:       <CopyToPublishDirectory>PreserveNewest</CopyToPublishDirectory>
18:       <CopyToOutputDirectory>Always</CopyToOutputDirectory>
19:     </Content>
20:   </ItemGroup>
21: 
22:   <ItemGroup>
23:     <PackageReference Include="Volo.Abp.Http.Client.IdentityModel" Version="9.0.8" />
24:     <PackageReference Include="Volo.Abp.Autofac" Version="9.0.8" />
25:     <ProjectReference Include="..\..\src\Aeq.CoreMvc.HttpApi.Client\Aeq.CoreMvc.HttpApi.Client.csproj" />
26:   </ItemGroup>
27: 
28:   <ItemGroup>
29:     <PackageReference Include="Microsoft.Extensions.Hosting" Version="9.0.0" />
30:     <PackageReference Include="Microsoft.Extensions.Http.Polly" Version="9.0.0" />
31:   </ItemGroup>
32: 
33: </Project>
```

## File: test/Aeq.CoreMvc.HttpApi.Client.ConsoleTestApp/appsettings.json
```json
 1: {
 2:   "RemoteServices": {
 3:     "Default": {
 4:       "BaseUrl": "https://localhost:44313"
 5:     }
 6:   },
 7:   "IdentityClients": {
 8:     "Default": {
 9:       "GrantType": "password",
10:       "ClientId": "CoreMvc_App",
11:       "UserName": "admin",
12:       "UserPassword": "1q2w3E*",
13:       "Authority": "https://localhost:44313",
14:       "Scope": "CoreMvc"
15:     }
16:   }
17: }
```

## File: test/Aeq.CoreMvc.HttpApi.Client.ConsoleTestApp/appsettings.secrets.json
```json
1: {
2: }
```

## File: test/Aeq.CoreMvc.HttpApi.Client.ConsoleTestApp/ClientDemoService.cs
```csharp
 1: using System;
 2: using System.Threading.Tasks;
 3: using Volo.Abp.Account;
 4: using Volo.Abp.DependencyInjection;
 5: namespace Aeq.CoreMvc.HttpApi.Client.ConsoleTestApp;
 6: public class ClientDemoService : ITransientDependency
 7: {
 8:     private readonly IProfileAppService _profileAppService;
 9:     public ClientDemoService(IProfileAppService profileAppService)
10:     {
11:         _profileAppService = profileAppService;
12:     }
13:     public async Task RunAsync()
14:     {
15:         var output = await _profileAppService.GetAsync();
16:         Console.WriteLine($"UserName : {output.UserName}");
17:         Console.WriteLine($"Email    : {output.Email}");
18:         Console.WriteLine($"Name     : {output.Name}");
19:         Console.WriteLine($"Surname  : {output.Surname}");
20:     }
21: }
```

## File: test/Aeq.CoreMvc.HttpApi.Client.ConsoleTestApp/ConsoleTestAppHostedService.cs
```csharp
 1: using Microsoft.Extensions.Hosting;
 2: using System.Threading;
 3: using System.Threading.Tasks;
 4: using Microsoft.Extensions.Configuration;
 5: using Microsoft.Extensions.DependencyInjection;
 6: using Volo.Abp;
 7: namespace Aeq.CoreMvc.HttpApi.Client.ConsoleTestApp;
 8: public class ConsoleTestAppHostedService : IHostedService
 9: {
10:     private readonly IConfiguration _configuration;
11:     public ConsoleTestAppHostedService(IConfiguration configuration)
12:     {
13:         _configuration = configuration;
14:     }
15:     public async Task StartAsync(CancellationToken cancellationToken)
16:     {
17:         using (var application = await AbpApplicationFactory.CreateAsync<CoreMvcConsoleApiClientModule>(options =>
18:         {
19:            options.Services.ReplaceConfiguration(_configuration);
20:            options.UseAutofac();
21:         }))
22:         {
23:             await application.InitializeAsync();
24:             var demo = application.ServiceProvider.GetRequiredService<ClientDemoService>();
25:             await demo.RunAsync();
26:             await application.ShutdownAsync();
27:         }
28:     }
29:     public Task StopAsync(CancellationToken cancellationToken)
30:     {
31:         return Task.CompletedTask;
32:     }
33: }
```

## File: test/Aeq.CoreMvc.HttpApi.Client.ConsoleTestApp/CoreMvcConsoleApiClientModule.cs
```csharp
 1: using System;
 2: using Microsoft.Extensions.DependencyInjection;
 3: using Polly;
 4: using Volo.Abp.Autofac;
 5: using Volo.Abp.Http.Client;
 6: using Volo.Abp.Http.Client.IdentityModel;
 7: using Volo.Abp.Modularity;
 8: namespace Aeq.CoreMvc.HttpApi.Client.ConsoleTestApp;
 9: [DependsOn(
10:     typeof(AbpAutofacModule),
11:     typeof(CoreMvcHttpApiClientModule),
12:     typeof(AbpHttpClientIdentityModelModule)
13:     )]
14: public class CoreMvcConsoleApiClientModule : AbpModule
15: {
16:     public override void PreConfigureServices(ServiceConfigurationContext context)
17:     {
18:         PreConfigure<AbpHttpClientBuilderOptions>(options =>
19:         {
20:             options.ProxyClientBuildActions.Add((remoteServiceName, clientBuilder) =>
21:             {
22:                 clientBuilder.AddTransientHttpErrorPolicy(
23:                     policyBuilder => policyBuilder.WaitAndRetryAsync(3, i => TimeSpan.FromSeconds(Math.Pow(2, i)))
24:                 );
25:             });
26:         });
27:     }
28: }
```

## File: test/Aeq.CoreMvc.HttpApi.Client.ConsoleTestApp/Program.cs
```csharp
 1: using System.Threading.Tasks;
 2: using Microsoft.Extensions.Configuration;
 3: using Microsoft.Extensions.DependencyInjection;
 4: using Microsoft.Extensions.Hosting;
 5: namespace Aeq.CoreMvc.HttpApi.Client.ConsoleTestApp;
 6: class Program
 7: {
 8:     static async Task Main(string[] args)
 9:     {
10:         await CreateHostBuilder(args).RunConsoleAsync();
11:     }
12:     public static IHostBuilder CreateHostBuilder(string[] args) =>
13:         Host.CreateDefaultBuilder(args)
14:             .AddAppSettingsSecretsJson()
15:             .ConfigureServices((hostContext, services) =>
16:             {
17:                 services.AddHostedService<ConsoleTestAppHostedService>();
18:             });
19: }
```

## File: test/Aeq.CoreMvc.TestBase/Security/FakeCurrentPrincipalAccessor.cs
```csharp
 1: using System.Collections.Generic;
 2: using System.Security.Claims;
 3: using Volo.Abp.DependencyInjection;
 4: using Volo.Abp.Security.Claims;
 5: namespace Aeq.CoreMvc.Security;
 6: [Dependency(ReplaceServices = true)]
 7: public class FakeCurrentPrincipalAccessor : ThreadCurrentPrincipalAccessor
 8: {
 9:     protected override ClaimsPrincipal GetClaimsPrincipal()
10:     {
11:         return GetPrincipal();
12:     }
13:     private ClaimsPrincipal GetPrincipal()
14:     {
15:         return new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
16:         {
17:             new Claim(AbpClaimTypes.UserId, "2e701e62-0953-4dd3-910b-dc6cc93ccb0d"),
18:             new Claim(AbpClaimTypes.UserName, "admin"),
19:             new Claim(AbpClaimTypes.Email, "admin@abp.io")
20:         }));
21:     }
22: }
```

## File: test/Aeq.CoreMvc.TestBase/Aeq.CoreMvc.TestBase.csproj
```
 1: <Project Sdk="Microsoft.NET.Sdk">
 2: 
 3:   <Import Project="..\..\common.props" />
 4: 
 5:   <PropertyGroup>
 6:     <TargetFramework>net9.0</TargetFramework>
 7:     <Nullable>enable</Nullable>
 8:     <RootNamespace>Aeq.CoreMvc</RootNamespace>
 9:   </PropertyGroup>
10: 
11:   <ItemGroup>
12:     <PackageReference Include="Volo.Abp.TestBase" Version="9.0.8" />
13:     <PackageReference Include="Volo.Abp.Autofac" Version="9.0.8" />
14:     <PackageReference Include="Volo.Abp.Authorization" Version="9.0.8" />
15:     <PackageReference Include="Volo.Abp.BackgroundJobs.Abstractions" Version="9.0.8" />
16:   </ItemGroup>
17: 
18:   <ItemGroup>
19:     <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.11.1.0" />
20:     <PackageReference Include="NSubstitute" Version="5.1.0" />
21:     <PackageReference Include="NSubstitute.Analyzers.CSharp" Version="1.0.17.0">
22:       <PrivateAssets>all</PrivateAssets>
23:       <IncludeAssets>runtime; build; native; contentfiles; analyzers</IncludeAssets>
24:     </PackageReference>
25:     <PackageReference Include="Shouldly" Version="4.2.1" />
26:     <PackageReference Include="xunit" Version="2.9.2" />
27:     <PackageReference Include="xunit.extensibility.execution" Version="2.9.2" />
28:     <PackageReference Include="xunit.runner.visualstudio" Version="2.8.2" />
29:   </ItemGroup>
30: 
31: </Project>
```

## File: test/Aeq.CoreMvc.TestBase/CoreMvcTestBase.cs
```csharp
 1: using System;
 2: using System.Threading.Tasks;
 3: using Microsoft.Extensions.DependencyInjection;
 4: using Volo.Abp;
 5: using Volo.Abp.Modularity;
 6: using Volo.Abp.Uow;
 7: using Volo.Abp.Testing;
 8: namespace Aeq.CoreMvc;
 9: public abstract class CoreMvcTestBase<TStartupModule> : AbpIntegratedTest<TStartupModule>
10:     where TStartupModule : IAbpModule
11: {
12:     protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
13:     {
14:         options.UseAutofac();
15:     }
16:     protected virtual Task WithUnitOfWorkAsync(Func<Task> func)
17:     {
18:         return WithUnitOfWorkAsync(new AbpUnitOfWorkOptions(), func);
19:     }
20:     protected virtual async Task WithUnitOfWorkAsync(AbpUnitOfWorkOptions options, Func<Task> action)
21:     {
22:         using (var scope = ServiceProvider.CreateScope())
23:         {
24:             var uowManager = scope.ServiceProvider.GetRequiredService<IUnitOfWorkManager>();
25:             using (var uow = uowManager.Begin(options))
26:             {
27:                 await action();
28:                 await uow.CompleteAsync();
29:             }
30:         }
31:     }
32:     protected virtual Task<TResult> WithUnitOfWorkAsync<TResult>(Func<Task<TResult>> func)
33:     {
34:         return WithUnitOfWorkAsync(new AbpUnitOfWorkOptions(), func);
35:     }
36:     protected virtual async Task<TResult> WithUnitOfWorkAsync<TResult>(AbpUnitOfWorkOptions options, Func<Task<TResult>> func)
37:     {
38:         using (var scope = ServiceProvider.CreateScope())
39:         {
40:             var uowManager = scope.ServiceProvider.GetRequiredService<IUnitOfWorkManager>();
41:             using (var uow = uowManager.Begin(options))
42:             {
43:                 var result = await func();
44:                 await uow.CompleteAsync();
45:                 return result;
46:             }
47:         }
48:     }
49: }
```

## File: test/Aeq.CoreMvc.TestBase/CoreMvcTestBaseModule.cs
```csharp
 1: using Microsoft.Extensions.DependencyInjection;
 2: using Volo.Abp;
 3: using Volo.Abp.Authorization;
 4: using Volo.Abp.Autofac;
 5: using Volo.Abp.BackgroundJobs;
 6: using Volo.Abp.Data;
 7: using Volo.Abp.Modularity;
 8: using Volo.Abp.Threading;
 9: namespace Aeq.CoreMvc;
10: [DependsOn(
11:     typeof(AbpAutofacModule),
12:     typeof(AbpTestBaseModule),
13:     typeof(AbpAuthorizationModule),
14:     typeof(AbpBackgroundJobsAbstractionsModule)
15:     )]
16: public class CoreMvcTestBaseModule : AbpModule
17: {
18:     public override void ConfigureServices(ServiceConfigurationContext context)
19:     {
20:         Configure<AbpBackgroundJobOptions>(options =>
21:         {
22:             options.IsJobExecutionEnabled = false;
23:         });
24:         context.Services.AddAlwaysAllowAuthorization();
25:     }
26:     public override void OnApplicationInitialization(ApplicationInitializationContext context)
27:     {
28:         SeedTestData(context);
29:     }
30:     private static void SeedTestData(ApplicationInitializationContext context)
31:     {
32:         AsyncHelper.RunSync(async () =>
33:         {
34:             using (var scope = context.ServiceProvider.CreateScope())
35:             {
36:                 await scope.ServiceProvider
37:                     .GetRequiredService<IDataSeeder>()
38:                     .SeedAsync();
39:             }
40:         });
41:     }
42: }
```

## File: test/Aeq.CoreMvc.TestBase/CoreMvcTestConsts.cs
```csharp
1: namespace Aeq.CoreMvc;
2: public static class CoreMvcTestConsts
3: {
4:     public const string CollectionDefinitionName = "CoreMvc collection";
5: }
```

## File: test/Aeq.CoreMvc.TestBase/CoreMvcTestDataSeedContributor.cs
```csharp
 1: using System.Threading.Tasks;
 2: using Volo.Abp.Data;
 3: using Volo.Abp.DependencyInjection;
 4: namespace Aeq.CoreMvc;
 5: public class CoreMvcTestDataSeedContributor : IDataSeedContributor, ITransientDependency
 6: {
 7:     public Task SeedAsync(DataSeedContext context)
 8:     {
 9:         return Task.CompletedTask;
10:     }
11: }
```

## File: test/Aeq.CoreMvc.Web.Tests/Pages/Books/IndexTests.cs
```csharp
1: using System.Threading.Tasks;
2: using Shouldly;
3: using Xunit;
4: namespace Aeq.CoreMvc.Pages.Books;
5: public class Index_Tests : CoreMvcWebTestBase
6: {
7: }
```

## File: test/Aeq.CoreMvc.Web.Tests/Pages/Index_Tests.cs
```csharp
 1: using System.Threading.Tasks;
 2: using Shouldly;
 3: using Xunit;
 4: namespace Aeq.CoreMvc.Pages;
 5: public class Index_Tests : CoreMvcWebTestBase
 6: {
 7:     [Fact]
 8:     public async Task Welcome_Page()
 9:     {
10:         var response = await GetResponseAsStringAsync("/");
11:         response.ShouldNotBeNull();
12:     }
13: }
```

## File: test/Aeq.CoreMvc.Web.Tests/Aeq.CoreMvc.Web.Tests.csproj
```
 1: <Project Sdk="Microsoft.NET.Sdk">
 2: 
 3:   <Import Project="..\..\common.props" />
 4: 
 5:   <PropertyGroup>
 6:     <TargetFramework>net9.0</TargetFramework>
 7:     <Nullable>enable</Nullable>
 8:   </PropertyGroup>
 9: 
10:   <ItemGroup>
11:     <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.11.1.0" />
12:     <PackageReference Include="HtmlAgilityPack" Version="1.11.67.0" />
13:     <ProjectReference Include="..\Aeq.CoreMvc.Application.Tests\Aeq.CoreMvc.Application.Tests.csproj" />
14:     <ProjectReference Include="..\..\src\Aeq.CoreMvc.Web\Aeq.CoreMvc.Web.csproj" />
15:     <PackageReference Include="Volo.Abp.AspNetCore.TestBase" Version="9.0.8" />
16:     <ProjectReference Include="..\Aeq.CoreMvc.EntityFrameworkCore.Tests\Aeq.CoreMvc.EntityFrameworkCore.Tests.csproj" />
17:   </ItemGroup>
18: 
19:   <ItemGroup>
20:     <Content Include="xunit.runner.json">
21:       <CopyToOutputDirectory>Always</CopyToOutputDirectory>
22:       <CopyToPublishDirectory>PreserveNewest</CopyToPublishDirectory>
23:     </Content>
24:   </ItemGroup>
25: 
26:   <!-- https://github.com/NuGet/Home/issues/4412 -->
27:   <Target Name="CopyDepsFiles" AfterTargets="Build" Condition="'$(TargetFramework)'!=''">
28:     <ItemGroup>
29:       <DepsFilePaths Include="$([System.IO.Path]::ChangeExtension('%(_ResolvedProjectReferencePaths.FullPath)', '.deps.json'))" />
30:     </ItemGroup>
31: 
32:     <Copy SourceFiles="%(DepsFilePaths.FullPath)" DestinationFolder="$(OutputPath)" Condition="Exists('%(DepsFilePaths.FullPath)')" />
33:   </Target>
34: 
35: </Project>
```

## File: test/Aeq.CoreMvc.Web.Tests/CoreMvcWebTestBase.cs
```csharp
 1: using System.Net;
 2: using System.Net.Http;
 3: using System.Text.Json;
 4: using System.Threading.Tasks;
 5: using Shouldly;
 6: using Volo.Abp.AspNetCore;
 7: using Volo.Abp.AspNetCore.TestBase;
 8: namespace Aeq.CoreMvc;
 9: public abstract class CoreMvcWebTestBase : AbpWebApplicationFactoryIntegratedTest<Program>
10: {
11:     protected virtual async Task<T?> GetResponseAsObjectAsync<T>(string url, HttpStatusCode expectedStatusCode = HttpStatusCode.OK)
12:     {
13:         var strResponse = await GetResponseAsStringAsync(url, expectedStatusCode);
14:         return JsonSerializer.Deserialize<T>(strResponse, new JsonSerializerOptions(JsonSerializerDefaults.Web));
15:     }
16:     protected virtual async Task<string> GetResponseAsStringAsync(string url, HttpStatusCode expectedStatusCode = HttpStatusCode.OK)
17:     {
18:         var response = await GetResponseAsync(url, expectedStatusCode);
19:         return await response.Content.ReadAsStringAsync();
20:     }
21:     protected virtual async Task<HttpResponseMessage> GetResponseAsync(string url, HttpStatusCode expectedStatusCode = HttpStatusCode.OK)
22:     {
23:         var response = await Client.GetAsync(url);
24:         response.StatusCode.ShouldBe(expectedStatusCode);
25:         return response;
26:     }
27: }
```

## File: test/Aeq.CoreMvc.Web.Tests/CoreMvcWebTestModule.cs
```csharp
 1: using System.Collections.Generic;
 2: using System.Globalization;
 3: using Localization.Resources.AbpUi;
 4: using Microsoft.AspNetCore.Builder;
 5: using Microsoft.AspNetCore.Localization;
 6: using Microsoft.AspNetCore.Mvc.ApplicationParts;
 7: using Microsoft.Extensions.DependencyInjection;
 8: using Aeq.CoreMvc.EntityFrameworkCore;
 9: using Aeq.CoreMvc.Localization;
10: using Aeq.CoreMvc.Web;
11: using Aeq.CoreMvc.Web.Menus;
12: using Volo.Abp.AspNetCore.TestBase;
13: using Volo.Abp.Localization;
14: using Volo.Abp.Modularity;
15: using Volo.Abp.OpenIddict;
16: using Volo.Abp.UI.Navigation;
17: using Volo.Abp.Validation.Localization;
18: namespace Aeq.CoreMvc;
19: [DependsOn(
20:     typeof(AbpAspNetCoreTestBaseModule),
21:     typeof(CoreMvcWebModule),
22:     typeof(CoreMvcApplicationTestModule),
23:     typeof(CoreMvcEntityFrameworkCoreTestModule)
24: )]
25: public class CoreMvcWebTestModule : AbpModule
26: {
27:     public override void PreConfigureServices(ServiceConfigurationContext context)
28:     {
29:         context.Services.PreConfigure<IMvcBuilder>(builder =>
30:         {
31:             builder.PartManager.ApplicationParts.Add(new CompiledRazorAssemblyPart(typeof(CoreMvcWebModule).Assembly));
32:         });
33:         context.Services.GetPreConfigureActions<OpenIddictServerBuilder>().Clear();
34:         PreConfigure<AbpOpenIddictAspNetCoreOptions>(options =>
35:         {
36:             options.AddDevelopmentEncryptionAndSigningCertificate = true;
37:         });
38:     }
39:     public override void ConfigureServices(ServiceConfigurationContext context)
40:     {
41:         ConfigureLocalizationServices(context.Services);
42:         ConfigureNavigationServices(context.Services);
43:     }
44:     private static void ConfigureLocalizationServices(IServiceCollection services)
45:     {
46:         var cultures = new List<CultureInfo> { new CultureInfo("en"), new CultureInfo("tr") };
47:         services.Configure<RequestLocalizationOptions>(options =>
48:         {
49:             options.DefaultRequestCulture = new RequestCulture("en");
50:             options.SupportedCultures = cultures;
51:             options.SupportedUICultures = cultures;
52:         });
53:         services.Configure<AbpLocalizationOptions>(options =>
54:         {
55:             options.Resources
56:                 .Get<CoreMvcResource>()
57:                 .AddBaseTypes(
58:                     typeof(AbpValidationResource),
59:                     typeof(AbpUiResource)
60:                 );
61:         });
62:     }
63:     private static void ConfigureNavigationServices(IServiceCollection services)
64:     {
65:         services.Configure<AbpNavigationOptions>(options =>
66:         {
67:             options.MenuContributors.Add(new CoreMvcMenuContributor());
68:         });
69:     }
70: }
```

## File: test/Aeq.CoreMvc.Web.Tests/Program.cs
```csharp
1: using Microsoft.AspNetCore.Builder;
2: using Aeq.CoreMvc;
3: using Volo.Abp.AspNetCore.TestBase;
4: var builder = WebApplication.CreateBuilder();
5: builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("Aeq.CoreMvc.Web.csproj");
6: await builder.RunAbpModuleAsync<CoreMvcWebTestModule>(applicationName: "Aeq.CoreMvc.Web" );
7: public partial class Program
8: {
9: }
```

## File: test/Aeq.CoreMvc.Web.Tests/xunit.runner.json
```json
1: {
2:   "shadowCopy": false
3: }
```

## File: .gitattributes
```
1: **/wwwroot/libs/** linguist-vendored
```

## File: .gitignore
```
  1: ## Ignore Visual Studio temporary files, build results, and
  2: ## files generated by popular Visual Studio add-ons.
  3: 
  4: # User-specific files
  5: *.suo
  6: *.user
  7: *.userosscache
  8: *.sln.docstates
  9: 
 10: # User-specific files (MonoDevelop/Xamarin Studio)
 11: *.userprefs
 12: 
 13: # Build results
 14: [Dd]ebug/
 15: [Dd]ebugPublic/
 16: [Rr]elease/
 17: [Rr]eleases/
 18: x64/
 19: x86/
 20: bld/
 21: [Bb]in/
 22: [Oo]bj/
 23: [Ll]og/
 24: 
 25: # Visual Studio 2015 cache/options directory
 26: .vs/
 27: # Uncomment if you have tasks that create the project's static files in wwwroot
 28: #wwwroot/
 29: 
 30: # MSTest test Results
 31: [Tt]est[Rr]esult*/
 32: [Bb]uild[Ll]og.*
 33: 
 34: # NUNIT
 35: *.VisualState.xml
 36: TestResult.xml
 37: 
 38: # Build Results of an ATL Project
 39: [Dd]ebugPS/
 40: [Rr]eleasePS/
 41: dlldata.c
 42: 
 43: # DNX
 44: project.lock.json
 45: artifacts/
 46: 
 47: *_i.c
 48: *_p.c
 49: *_i.h
 50: *.ilk
 51: *.meta
 52: *.obj
 53: *.pch
 54: *.pdb
 55: *.pgc
 56: *.pgd
 57: *.rsp
 58: *.sbr
 59: *.tlb
 60: *.tli
 61: *.tlh
 62: *.tmp
 63: *.tmp_proj
 64: *.log
 65: *.vspscc
 66: *.vssscc
 67: .builds
 68: *.pidb
 69: *.svclog
 70: *.scc
 71: 
 72: # Chutzpah Test files
 73: _Chutzpah*
 74: 
 75: # Visual C++ cache files
 76: ipch/
 77: *.aps
 78: *.ncb
 79: *.opendb
 80: *.opensdf
 81: *.sdf
 82: *.cachefile
 83: *.VC.db
 84: *.VC.VC.opendb
 85: 
 86: # Visual Studio profiler
 87: *.psess
 88: *.vsp
 89: *.vspx
 90: *.sap
 91: 
 92: # TFS 2012 Local Workspace
 93: $tf/
 94: 
 95: # Guidance Automation Toolkit
 96: *.gpState
 97: 
 98: # ReSharper is a .NET coding add-in
 99: _ReSharper*/
100: *.[Rr]e[Ss]harper
101: *.DotSettings.user
102: 
103: # JustCode is a .NET coding add-in
104: .JustCode
105: 
106: # TeamCity is a build add-in
107: _TeamCity*
108: 
109: # DotCover is a Code Coverage Tool
110: *.dotCover
111: 
112: # NCrunch
113: _NCrunch_*
114: .*crunch*.local.xml
115: nCrunchTemp_*
116: 
117: # MightyMoose
118: *.mm.*
119: AutoTest.Net/
120: 
121: # Web workbench (sass)
122: .sass-cache/
123: 
124: # Installshield output folder
125: [Ee]xpress/
126: 
127: # DocProject is a documentation generator add-in
128: DocProject/buildhelp/
129: DocProject/Help/*.HxT
130: DocProject/Help/*.HxC
131: DocProject/Help/*.hhc
132: DocProject/Help/*.hhk
133: DocProject/Help/*.hhp
134: DocProject/Help/Html2
135: DocProject/Help/html
136: 
137: # Click-Once directory
138: publish/
139: 
140: # Publish Web Output
141: *.[Pp]ublish.xml
142: *.azurePubxml
143: # TODO: Comment the next line if you want to checkin your web deploy settings
144: # but database connection strings (with potential passwords) will be unencrypted
145: *.pubxml
146: *.publishproj
147: 
148: # Microsoft Azure Web App publish settings. Comment the next line if you want to
149: # checkin your Azure Web App publish settings, but sensitive information contained
150: # in these scripts will be unencrypted
151: PublishScripts/
152: 
153: # NuGet Packages
154: *.nupkg
155: # The packages folder can be ignored because of Package Restore
156: **/packages/*
157: # except build/, which is used as an MSBuild target.
158: !**/packages/build/
159: # Uncomment if necessary however generally it will be regenerated when needed
160: #!**/packages/repositories.config
161: # NuGet v3's project.json files produces more ignoreable files
162: *.nuget.props
163: *.nuget.targets
164: 
165: # Microsoft Azure Build Output
166: csx/
167: *.build.csdef
168: 
169: # Microsoft Azure Emulator
170: ecf/
171: rcf/
172: 
173: # Windows Store app package directories and files
174: AppPackages/
175: BundleArtifacts/
176: Package.StoreAssociation.xml
177: _pkginfo.txt
178: 
179: # Visual Studio cache files
180: # files ending in .cache can be ignored
181: *.[Cc]ache
182: # but keep track of directories ending in .cache
183: !*.[Cc]ache/
184: 
185: # Others
186: ClientBin/
187: ~$*
188: *~
189: *.dbmdl
190: *.dbproj.schemaview
191: *.pfx
192: *.publishsettings
193: node_modules/
194: orleans.codegen.cs
195: 
196: # Since there are multiple workflows, uncomment next line to ignore bower_components
197: # (https://github.com/github/gitignore/pull/1529#issuecomment-104372622)
198: #bower_components/
199: 
200: # RIA/Silverlight projects
201: Generated_Code/
202: 
203: # Backup & report files from converting an old project file
204: # to a newer Visual Studio version. Backup files are not needed,
205: # because we have git ;-)
206: _UpgradeReport_Files/
207: Backup*/
208: UpgradeLog*.XML
209: UpgradeLog*.htm
210: 
211: # SQL Server files
212: *.mdf
213: *.ldf
214: 
215: # Business Intelligence projects
216: *.rdl.data
217: *.bim.layout
218: *.bim_*.settings
219: 
220: # Microsoft Fakes
221: FakesAssemblies/
222: 
223: # GhostDoc plugin setting file
224: *.GhostDoc.xml
225: 
226: # Node.js Tools for Visual Studio
227: .ntvs_analysis.dat
228: 
229: # Visual Studio 6 build log
230: *.plg
231: 
232: # Visual Studio 6 workspace options file
233: *.opt
234: 
235: # Visual Studio LightSwitch build output
236: **/*.HTMLClient/GeneratedArtifacts
237: **/*.DesktopClient/GeneratedArtifacts
238: **/*.DesktopClient/ModelManifest.xml
239: **/*.Server/GeneratedArtifacts
240: **/*.Server/ModelManifest.xml
241: _Pvt_Extensions
242: 
243: # Paket dependency manager
244: .paket/paket.exe
245: paket-files/
246: 
247: # FAKE - F# Make
248: .fake/
249: 
250: # JetBrains Rider
251: .idea/
252: *.sln.iml
253: 
254: # CoreMvc
255: src/Aeq.CoreMvc.Web/Logs/*
256: src/Aeq.CoreMvc.Web.Host/Logs/*
257: src/Aeq.CoreMvc.AuthServer/Logs/*
258: src/Aeq.CoreMvc.HttpApi.Host/Logs/*
259: src/Aeq.CoreMvc.HttpApi.HostWithIds/Logs/*
260: src/Aeq.CoreMvc.DbMigrator/Logs/*
261: src/Aeq.CoreMvc.Blazor.Server/Logs/*
262: src/Aeq.CoreMvc.Blazor.Server.Tiered/Logs/*
263: 
264: # Use abp install-libs to restore.
265: **/wwwroot/libs/*
```

## File: Aeq.CoreMvc.sln
```
  1: Microsoft Visual Studio Solution File, Format Version 12.00
  2: # Visual Studio Version 16
  3: VisualStudioVersion = 16.0.29020.237
  4: MinimumVisualStudioVersion = 10.0.40219.1
  5: Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "Aeq.CoreMvc.Domain", "src\Aeq.CoreMvc.Domain\Aeq.CoreMvc.Domain.csproj", "{554AD327-6DBA-4F8F-96F8-81CE7A0C863F}"
  6: EndProject
  7: Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "Aeq.CoreMvc.Application", "src\Aeq.CoreMvc.Application\Aeq.CoreMvc.Application.csproj", "{1A94A50E-06DC-43C1-80B5-B662820EC3EB}"
  8: EndProject
  9: Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "Aeq.CoreMvc.EntityFrameworkCore", "src\Aeq.CoreMvc.EntityFrameworkCore\Aeq.CoreMvc.EntityFrameworkCore.csproj", "{C956DD76-69C8-4A9C-83EA-D17DF83340FD}"
 10: EndProject
 11: Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "Aeq.CoreMvc.Web", "src\Aeq.CoreMvc.Web\Aeq.CoreMvc.Web.csproj", "{068855E8-9240-4F1A-910B-CF825794513B}"
 12: EndProject
 13: Project("{2150E333-8FDC-42A3-9474-1A3956D46DE8}") = "src", "src", "{CA9AC87F-097E-4F15-8393-4BC07735A5B0}"
 14: EndProject
 15: Project("{2150E333-8FDC-42A3-9474-1A3956D46DE8}") = "test", "test", "{04DBDB01-70F4-4E06-B468-8F87850B22BE}"
 16: EndProject
 17: Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "Aeq.CoreMvc.Application.Tests", "test\Aeq.CoreMvc.Application.Tests\Aeq.CoreMvc.Application.Tests.csproj", "{50B2631D-129C-47B3-A587-029CCD6099BC}"
 18: EndProject
 19: Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "Aeq.CoreMvc.Web.Tests", "test\Aeq.CoreMvc.Web.Tests\Aeq.CoreMvc.Web.Tests.csproj", "{5F1B28C6-8D0C-4155-92D0-252F7EA5F674}"
 20: EndProject
 21: Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "Aeq.CoreMvc.Domain.Shared", "src\Aeq.CoreMvc.Domain.Shared\Aeq.CoreMvc.Domain.Shared.csproj", "{42F719ED-8413-4895-B5B4-5AB56079BC66}"
 22: EndProject
 23: Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "Aeq.CoreMvc.Application.Contracts", "src\Aeq.CoreMvc.Application.Contracts\Aeq.CoreMvc.Application.Contracts.csproj", "{520659C8-C734-4298-A3DA-B539DB9DFC0B}"
 24: EndProject
 25: Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "Aeq.CoreMvc.HttpApi", "src\Aeq.CoreMvc.HttpApi\Aeq.CoreMvc.HttpApi.csproj", "{4164BDF7-F527-4E85-9CE6-E3C2D7426A27}"
 26: EndProject
 27: Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "Aeq.CoreMvc.HttpApi.Client", "src\Aeq.CoreMvc.HttpApi.Client\Aeq.CoreMvc.HttpApi.Client.csproj", "{3B5A0094-670D-4BB1-BFDD-61B88A8773DC}"
 28: EndProject
 29: Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "Aeq.CoreMvc.EntityFrameworkCore.Tests", "test\Aeq.CoreMvc.EntityFrameworkCore.Tests\Aeq.CoreMvc.EntityFrameworkCore.Tests.csproj", "{1FE30EB9-74A9-47F5-A9F6-7B1FAB672D81}"
 30: EndProject
 31: Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "Aeq.CoreMvc.TestBase", "test\Aeq.CoreMvc.TestBase\Aeq.CoreMvc.TestBase.csproj", "{91853F21-9CD9-4132-BC29-A7D5D84FFFE7}"
 32: EndProject
 33: Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "Aeq.CoreMvc.Domain.Tests", "test\Aeq.CoreMvc.Domain.Tests\Aeq.CoreMvc.Domain.Tests.csproj", "{E512F4D9-9375-480F-A2F6-A46509F9D824}"
 34: EndProject
 35: Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "Aeq.CoreMvc.HttpApi.Client.ConsoleTestApp", "test\Aeq.CoreMvc.HttpApi.Client.ConsoleTestApp\Aeq.CoreMvc.HttpApi.Client.ConsoleTestApp.csproj", "{EF480016-9127-4916-8735-D2466BDBC582}"
 36: EndProject
 37: Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "Aeq.CoreMvc.DbMigrator", "src\Aeq.CoreMvc.DbMigrator\Aeq.CoreMvc.DbMigrator.csproj", "{AA94D832-1CCC-4715-95A9-A483F23A1A5D}"
 38: EndProject
 39: Global
 40: 	GlobalSection(SolutionConfigurationPlatforms) = preSolution
 41: 		Debug|Any CPU = Debug|Any CPU
 42: 		Release|Any CPU = Release|Any CPU
 43: 	EndGlobalSection
 44: 	GlobalSection(ProjectConfigurationPlatforms) = postSolution
 45: 		{554AD327-6DBA-4F8F-96F8-81CE7A0C863F}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
 46: 		{554AD327-6DBA-4F8F-96F8-81CE7A0C863F}.Debug|Any CPU.Build.0 = Debug|Any CPU
 47: 		{554AD327-6DBA-4F8F-96F8-81CE7A0C863F}.Release|Any CPU.ActiveCfg = Release|Any CPU
 48: 		{554AD327-6DBA-4F8F-96F8-81CE7A0C863F}.Release|Any CPU.Build.0 = Release|Any CPU
 49: 		{1A94A50E-06DC-43C1-80B5-B662820EC3EB}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
 50: 		{1A94A50E-06DC-43C1-80B5-B662820EC3EB}.Debug|Any CPU.Build.0 = Debug|Any CPU
 51: 		{1A94A50E-06DC-43C1-80B5-B662820EC3EB}.Release|Any CPU.ActiveCfg = Release|Any CPU
 52: 		{1A94A50E-06DC-43C1-80B5-B662820EC3EB}.Release|Any CPU.Build.0 = Release|Any CPU
 53: 		{C956DD76-69C8-4A9C-83EA-D17DF83340FD}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
 54: 		{C956DD76-69C8-4A9C-83EA-D17DF83340FD}.Debug|Any CPU.Build.0 = Debug|Any CPU
 55: 		{C956DD76-69C8-4A9C-83EA-D17DF83340FD}.Release|Any CPU.ActiveCfg = Release|Any CPU
 56: 		{C956DD76-69C8-4A9C-83EA-D17DF83340FD}.Release|Any CPU.Build.0 = Release|Any CPU
 57: 		{068855E8-9240-4F1A-910B-CF825794513B}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
 58: 		{068855E8-9240-4F1A-910B-CF825794513B}.Debug|Any CPU.Build.0 = Debug|Any CPU
 59: 		{068855E8-9240-4F1A-910B-CF825794513B}.Release|Any CPU.ActiveCfg = Release|Any CPU
 60: 		{068855E8-9240-4F1A-910B-CF825794513B}.Release|Any CPU.Build.0 = Release|Any CPU
 61: 		{50B2631D-129C-47B3-A587-029CCD6099BC}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
 62: 		{50B2631D-129C-47B3-A587-029CCD6099BC}.Debug|Any CPU.Build.0 = Debug|Any CPU
 63: 		{50B2631D-129C-47B3-A587-029CCD6099BC}.Release|Any CPU.ActiveCfg = Release|Any CPU
 64: 		{50B2631D-129C-47B3-A587-029CCD6099BC}.Release|Any CPU.Build.0 = Release|Any CPU
 65: 		{5F1B28C6-8D0C-4155-92D0-252F7EA5F674}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
 66: 		{5F1B28C6-8D0C-4155-92D0-252F7EA5F674}.Debug|Any CPU.Build.0 = Debug|Any CPU
 67: 		{5F1B28C6-8D0C-4155-92D0-252F7EA5F674}.Release|Any CPU.ActiveCfg = Release|Any CPU
 68: 		{5F1B28C6-8D0C-4155-92D0-252F7EA5F674}.Release|Any CPU.Build.0 = Release|Any CPU
 69: 		{42F719ED-8413-4895-B5B4-5AB56079BC66}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
 70: 		{42F719ED-8413-4895-B5B4-5AB56079BC66}.Debug|Any CPU.Build.0 = Debug|Any CPU
 71: 		{42F719ED-8413-4895-B5B4-5AB56079BC66}.Release|Any CPU.ActiveCfg = Release|Any CPU
 72: 		{42F719ED-8413-4895-B5B4-5AB56079BC66}.Release|Any CPU.Build.0 = Release|Any CPU
 73: 		{520659C8-C734-4298-A3DA-B539DB9DFC0B}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
 74: 		{520659C8-C734-4298-A3DA-B539DB9DFC0B}.Debug|Any CPU.Build.0 = Debug|Any CPU
 75: 		{520659C8-C734-4298-A3DA-B539DB9DFC0B}.Release|Any CPU.ActiveCfg = Release|Any CPU
 76: 		{520659C8-C734-4298-A3DA-B539DB9DFC0B}.Release|Any CPU.Build.0 = Release|Any CPU
 77: 		{4164BDF7-F527-4E85-9CE6-E3C2D7426A27}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
 78: 		{4164BDF7-F527-4E85-9CE6-E3C2D7426A27}.Debug|Any CPU.Build.0 = Debug|Any CPU
 79: 		{4164BDF7-F527-4E85-9CE6-E3C2D7426A27}.Release|Any CPU.ActiveCfg = Release|Any CPU
 80: 		{4164BDF7-F527-4E85-9CE6-E3C2D7426A27}.Release|Any CPU.Build.0 = Release|Any CPU
 81: 		{3B5A0094-670D-4BB1-BFDD-61B88A8773DC}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
 82: 		{3B5A0094-670D-4BB1-BFDD-61B88A8773DC}.Debug|Any CPU.Build.0 = Debug|Any CPU
 83: 		{3B5A0094-670D-4BB1-BFDD-61B88A8773DC}.Release|Any CPU.ActiveCfg = Release|Any CPU
 84: 		{3B5A0094-670D-4BB1-BFDD-61B88A8773DC}.Release|Any CPU.Build.0 = Release|Any CPU
 85: 		{1FE30EB9-74A9-47F5-A9F6-7B1FAB672D81}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
 86: 		{1FE30EB9-74A9-47F5-A9F6-7B1FAB672D81}.Debug|Any CPU.Build.0 = Debug|Any CPU
 87: 		{1FE30EB9-74A9-47F5-A9F6-7B1FAB672D81}.Release|Any CPU.ActiveCfg = Release|Any CPU
 88: 		{1FE30EB9-74A9-47F5-A9F6-7B1FAB672D81}.Release|Any CPU.Build.0 = Release|Any CPU
 89: 		{91853F21-9CD9-4132-BC29-A7D5D84FFFE7}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
 90: 		{91853F21-9CD9-4132-BC29-A7D5D84FFFE7}.Debug|Any CPU.Build.0 = Debug|Any CPU
 91: 		{91853F21-9CD9-4132-BC29-A7D5D84FFFE7}.Release|Any CPU.ActiveCfg = Release|Any CPU
 92: 		{91853F21-9CD9-4132-BC29-A7D5D84FFFE7}.Release|Any CPU.Build.0 = Release|Any CPU
 93: 		{E512F4D9-9375-480F-A2F6-A46509F9D824}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
 94: 		{E512F4D9-9375-480F-A2F6-A46509F9D824}.Debug|Any CPU.Build.0 = Debug|Any CPU
 95: 		{E512F4D9-9375-480F-A2F6-A46509F9D824}.Release|Any CPU.ActiveCfg = Release|Any CPU
 96: 		{E512F4D9-9375-480F-A2F6-A46509F9D824}.Release|Any CPU.Build.0 = Release|Any CPU
 97: 		{EF480016-9127-4916-8735-D2466BDBC582}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
 98: 		{EF480016-9127-4916-8735-D2466BDBC582}.Debug|Any CPU.Build.0 = Debug|Any CPU
 99: 		{EF480016-9127-4916-8735-D2466BDBC582}.Release|Any CPU.ActiveCfg = Release|Any CPU
100: 		{EF480016-9127-4916-8735-D2466BDBC582}.Release|Any CPU.Build.0 = Release|Any CPU
101: 		{AA94D832-1CCC-4715-95A9-A483F23A1A5D}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
102: 		{AA94D832-1CCC-4715-95A9-A483F23A1A5D}.Debug|Any CPU.Build.0 = Debug|Any CPU
103: 		{AA94D832-1CCC-4715-95A9-A483F23A1A5D}.Release|Any CPU.ActiveCfg = Release|Any CPU
104: 		{AA94D832-1CCC-4715-95A9-A483F23A1A5D}.Release|Any CPU.Build.0 = Release|Any CPU
105: 	EndGlobalSection
106: 	GlobalSection(SolutionProperties) = preSolution
107: 		HideSolutionNode = FALSE
108: 	EndGlobalSection
109: 	GlobalSection(NestedProjects) = preSolution
110: 		{554AD327-6DBA-4F8F-96F8-81CE7A0C863F} = {CA9AC87F-097E-4F15-8393-4BC07735A5B0}
111: 		{1A94A50E-06DC-43C1-80B5-B662820EC3EB} = {CA9AC87F-097E-4F15-8393-4BC07735A5B0}
112: 		{C956DD76-69C8-4A9C-83EA-D17DF83340FD} = {CA9AC87F-097E-4F15-8393-4BC07735A5B0}
113: 		{068855E8-9240-4F1A-910B-CF825794513B} = {CA9AC87F-097E-4F15-8393-4BC07735A5B0}
114: 		{50B2631D-129C-47B3-A587-029CCD6099BC} = {04DBDB01-70F4-4E06-B468-8F87850B22BE}
115: 		{5F1B28C6-8D0C-4155-92D0-252F7EA5F674} = {04DBDB01-70F4-4E06-B468-8F87850B22BE}
116: 		{42F719ED-8413-4895-B5B4-5AB56079BC66} = {CA9AC87F-097E-4F15-8393-4BC07735A5B0}
117: 		{520659C8-C734-4298-A3DA-B539DB9DFC0B} = {CA9AC87F-097E-4F15-8393-4BC07735A5B0}
118: 		{4164BDF7-F527-4E85-9CE6-E3C2D7426A27} = {CA9AC87F-097E-4F15-8393-4BC07735A5B0}
119: 		{3B5A0094-670D-4BB1-BFDD-61B88A8773DC} = {CA9AC87F-097E-4F15-8393-4BC07735A5B0}
120: 		{1FE30EB9-74A9-47F5-A9F6-7B1FAB672D81} = {04DBDB01-70F4-4E06-B468-8F87850B22BE}
121: 		{91853F21-9CD9-4132-BC29-A7D5D84FFFE7} = {04DBDB01-70F4-4E06-B468-8F87850B22BE}
122: 		{E512F4D9-9375-480F-A2F6-A46509F9D824} = {04DBDB01-70F4-4E06-B468-8F87850B22BE}
123: 		{EF480016-9127-4916-8735-D2466BDBC582} = {04DBDB01-70F4-4E06-B468-8F87850B22BE}
124: 		{AA94D832-1CCC-4715-95A9-A483F23A1A5D} = {CA9AC87F-097E-4F15-8393-4BC07735A5B0}
125: 	EndGlobalSection
126: 	GlobalSection(ExtensibilityGlobals) = postSolution
127: 		SolutionGuid = {28315BFD-90E7-4E14-A2EA-F3D23AF4126F}
128: 	EndGlobalSection
129: EndGlobal
```

## File: Aeq.CoreMvc.sln.DotSettings
```
 1: <wpf:ResourceDictionary xml:space="preserve" xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" xmlns:s="clr-namespace:System;assembly=mscorlib" xmlns:ss="urn:shemas-jetbrains-com:settings-storage-xaml" xmlns:wpf="http://schemas.microsoft.com/winfx/2006/xaml/presentation">
 2: 	<s:Boolean x:Key="/Default/CodeEditing/Intellisense/CodeCompletion/IntelliSenseCompletingCharacters/CSharpCompletingCharacters/UpgradedFromVSSettings/@EntryValue">True</s:Boolean>
 3: 	<s:String x:Key="/Default/CodeInspection/Highlighting/InspectionSeverities/=EnforceDoWhileStatementBraces/@EntryIndexedValue">WARNING</s:String>
 4: 	<s:String x:Key="/Default/CodeInspection/Highlighting/InspectionSeverities/=EnforceFixedStatementBraces/@EntryIndexedValue">WARNING</s:String>
 5: 	<s:String x:Key="/Default/CodeInspection/Highlighting/InspectionSeverities/=EnforceForeachStatementBraces/@EntryIndexedValue">WARNING</s:String>
 6: 	<s:String x:Key="/Default/CodeInspection/Highlighting/InspectionSeverities/=EnforceForStatementBraces/@EntryIndexedValue">WARNING</s:String>
 7: 	<s:String x:Key="/Default/CodeInspection/Highlighting/InspectionSeverities/=EnforceIfStatementBraces/@EntryIndexedValue">WARNING</s:String>
 8: 	<s:String x:Key="/Default/CodeInspection/Highlighting/InspectionSeverities/=EnforceLockStatementBraces/@EntryIndexedValue">WARNING</s:String>
 9: 	<s:String x:Key="/Default/CodeInspection/Highlighting/InspectionSeverities/=EnforceUsingStatementBraces/@EntryIndexedValue">WARNING</s:String>
10: 	<s:String x:Key="/Default/CodeInspection/Highlighting/InspectionSeverities/=EnforceWhileStatementBraces/@EntryIndexedValue">WARNING</s:String>
11: 	<s:String x:Key="/Default/CodeStyle/CodeFormatting/CSharpCodeStyle/BRACES_FOR_FOR/@EntryValue">Required</s:String>
12: 	<s:String x:Key="/Default/CodeStyle/CodeFormatting/CSharpCodeStyle/BRACES_FOR_FOREACH/@EntryValue">Required</s:String>
13: 	<s:String x:Key="/Default/CodeStyle/CodeFormatting/CSharpCodeStyle/BRACES_FOR_IFELSE/@EntryValue">Required</s:String>
14: 	<s:String x:Key="/Default/CodeStyle/CodeFormatting/CSharpCodeStyle/BRACES_FOR_WHILE/@EntryValue">Required</s:String>
15: 	<s:Boolean x:Key="/Default/CodeStyle/CodeFormatting/CSharpCodeStyle/BRACES_REDUNDANT/@EntryValue">False</s:Boolean>
16: 	<s:Boolean x:Key="/Default/CodeStyle/Generate/=Implementations/@KeyIndexDefined">True</s:Boolean>
17: 	<s:String x:Key="/Default/CodeStyle/Generate/=Implementations/Options/=Async/@EntryIndexedValue">False</s:String>
18: 	<s:String x:Key="/Default/CodeStyle/Generate/=Implementations/Options/=Mutable/@EntryIndexedValue">False</s:String>
19: 	<s:Boolean x:Key="/Default/CodeStyle/Generate/=Overrides/@KeyIndexDefined">True</s:Boolean>
20: 	<s:String x:Key="/Default/CodeStyle/Generate/=Overrides/Options/=Async/@EntryIndexedValue">False</s:String>
21: 	<s:String x:Key="/Default/CodeStyle/Generate/=Overrides/Options/=Mutable/@EntryIndexedValue">False</s:String>
22: 	<s:String x:Key="/Default/CodeStyle/Naming/CSharpNaming/Abbreviations/=SQL/@EntryIndexedValue">SQL</s:String>
23: </wpf:ResourceDictionary>
```
