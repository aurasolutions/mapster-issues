There is a batch file called mapster.bat in the Mapster.Issues project that is used to clean out the generated files and rebuild the project

To rebuild the generated files just run the batch file

**Issues noted:**

  # #337
  ## Include #nullable enable to generated files 
  Any files that are generated with nullable reference types will throw warnings when compiled. I have had to write a post-process tool to add the following to each file

  ```
    #nullable enable
    #nullable disable warnings
  ```

  # #349 
  ## When generating code using Mapster.Tool, if a property is of type Array then the generated type is not mapped properly
  Generate the files and check CountryDto.g.cs in Contracts\Lookup folder. The source Domain\Lookup has a `Province[]` property however
  the generated code does not translate this to a ProvinceDto unless the property is defined as `ICollection<Province>`

  # #350
  ## Files generated with Mapster.Tool do not include the proper using statements when multiple namespaces are used

