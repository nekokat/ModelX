namespace Tests
{
    public class ContainerIDTest
    {
        [SetUp]
        public void Setup()
        {
            Date = new (2024, 1, 1);
        }

        DateTime Date {get; set; }

        [TestCase(BlankType.Clear,      "a7e0830c-2746-2c1d-fe56-1d6f0394fc70")]
        [TestCase(BlankType.Person,     "3924046b-10d7-d284-f524-c5f6aa980627")]
        [TestCase(BlankType.Weapon,     "b676aaab-2a36-8d47-464a-586ed9fde95f")]
        [TestCase(BlankType.Skill,      "472ab129-2ceb-e31c-5c2e-cb76554ad7c1")]
        [TestCase(BlankType.Spell,      "c5473619-38f8-645a-b8b7-e4fe5d3f4072")]
        [TestCase(BlankType.Notes,      "1f2bc67c-9490-6a7f-4019-115b4c1b5eb9")]
        [TestCase(BlankType.Equipment,  "966ad20f-edcb-c5a7-df3c-12698ad3310b")]
        [TestCase(BlankType.Trait,      "9d7409e6-0d98-eaf2-ab8c-13017a19ce14")]
        public void IDTest(BlankType type, string id)
        {
            string _name = Enum.GetName(typeof(BlankType), type) ?? string.Empty;
            Assert.That(new ContainerID(_name, Date).ToString(), Is.EqualTo(id));
        }
    }
}
