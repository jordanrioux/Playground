using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using VerifyXunit;

namespace MathLibrary.Tests;

[UsesVerify]
public class SnapshotTests : VerifyBase
{
    public SnapshotTests() : base()
    {
    }


    public class ClassDefinition
    {
        public string Name { get; set; }
        public string Visibility { get; set; }
    }

    public interface ILanguage
    {
        string GetProperty(string type);
    }

    public class CSharpLanguage : ILanguage
    {
        public string GetProperty(string type)
        {
            var property = "\t[JsonPropertyName(\"test\")]";
            property += Environment.NewLine;
            property += "\tpublic string Test { get; set; }";
            return property;
        }
    }

    [Fact]
    public async void GenerateTest()
    {
        var classes = new List<ClassDefinition>()
        {
            new () { Name = "Toto", Visibility = "public" }
        };
        
        var code = new StringBuilder();
        var language = new CSharpLanguage();
        foreach (var classDef in classes)
        {
            code.AppendLine($"public class {classDef.Name}");
            code.AppendLine("{");
            code.AppendLine(language.GetProperty("string"));
            code.Append('}');
        }

        await Verify(code);
    }
}