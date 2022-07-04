namespace projecteuler_Tests.T_1_100
{
    public class UnitTest_61_70
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_61_test()
        {
            if (tasksList.t_List.Length > 60)
                Assert.That(tasksList.t_List[60].answer(), Is.EqualTo("28684"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_62_test()
        {
            if (tasksList.t_List.Length > 61)
                Assert.That(tasksList.t_List[61].answer(), Is.EqualTo("127035954683"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_63_test()
        {
            if (tasksList.t_List.Length > 62)
                Assert.That(tasksList.t_List[62].answer(), Is.EqualTo("49"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_64_test()
        {
            if (tasksList.t_List.Length > 63)
                Assert.That(tasksList.t_List[63].answer(), Is.EqualTo("1322"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_65_test()
        {
            if (tasksList.t_List.Length > 64)
                Assert.That(tasksList.t_List[64].answer(), Is.EqualTo("272"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_66_test()
        {
            if (tasksList.t_List.Length > 65)
                Assert.That(tasksList.t_List[65].answer(), Is.EqualTo("661"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_67_test()
        {
            if (tasksList.t_List.Length > 66)
                Assert.That(tasksList.t_List[66].answer(), Is.EqualTo("7273"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_68_test()
        {
            if (tasksList.t_List.Length > 67)
                Assert.That(tasksList.t_List[67].answer(), Is.EqualTo("6531031914842725"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_69_test()
        {
            if (tasksList.t_List.Length > 68)
                Assert.That(tasksList.t_List[68].answer(), Is.EqualTo("510510"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_70_test()
        {
            if (tasksList.t_List.Length > 69)
                Assert.That(tasksList.t_List[69].answer(), Is.EqualTo("8319823"));
            else
                Assert.Ignore();
        }
    }
}
