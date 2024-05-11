namespace Tests
{
    public class CreateTests
    {
            [SetUp]
            public void Setup()
            {
                
                TemplatePath = Global.Setting.Blank.TemplatePath;
                Create.GenerateEmptyJson();
            }

            string TemplatePath { get; set; }

            [Test]
            public void CreateTest()
            {
                foreach (string filePath in Directory.GetFiles(TemplatePath, "*.json"))
                {
                    Assert.That(filePath, Does.Exist);
                }
            }

            [TestCase(BlankType.Clear)]
            [TestCase(BlankType.Person)]
            [TestCase(BlankType.Weapon)]
            [TestCase(BlankType.Skill)]
            [TestCase(BlankType.Spell)]
            [TestCase(BlankType.Notes)]
            [TestCase(BlankType.Equipment)]
            [TestCase(BlankType.Trait)]
            public void LoadTest(BlankType type)
            {
                string testFile = @$"{TemplatePath}/{type.ToString()}.json";
                Workspace.Blank testBlank = new (type);

                Assert.That(Workspace.Blank.Load(testFile),Is.EqualTo(testBlank));
            }
    }
}
