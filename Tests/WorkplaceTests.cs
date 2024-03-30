using ModelX.Workspace;
using ModelX.Workspace.Create;
using System;
using System.IO;
using Support;

namespace Tests
{
    public class CreateTests
    {
        [SetUp]
            public void Setup()
            {
                Create.GenerateEmptyJson();
            }

            public void CreateTest()
            {
                foreach (string filePath in Directory.GetFiles(@"./Template", "*.json"))
                {
                    Assert.That(filePath, Does.Exist);
                }
            }
    }
}
