namespace projecteuler_Tests.T_1_100
{
    public class UnitTest_91_100
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_91_test()
        {
            if (tasksList.t_List.Length > 90)
                Assert.That(tasksList.t_List[90].answer(), Is.EqualTo("14234"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_92_test()
        {
            if (tasksList.t_List.Length > 91)
                Assert.That(tasksList.t_List[91].answer(), Is.EqualTo("8581146"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_93_test()
        {
            if (tasksList.t_List.Length > 92)
                Assert.That(tasksList.t_List[92].answer(), Is.EqualTo("1258"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_94_test()
        {
            if (tasksList.t_List.Length > 93)
                Assert.That(tasksList.t_List[93].answer(), Is.EqualTo("518408346"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_95_test()
        {
            if (tasksList.t_List.Length > 94)
                Assert.That(tasksList.t_List[94].answer(), Is.EqualTo("14316"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_96_test()
        {
            if (tasksList.t_List.Length > 95)
                Assert.That(tasksList.t_List[95].answer(), Is.EqualTo("24702"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_97_test()
        {
            if (tasksList.t_List.Length > 96)
                Assert.That(tasksList.t_List[96].answer(), Is.EqualTo("8739992577"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_98_test()
        {
            if (tasksList.t_List.Length > 97)
                Assert.That(tasksList.t_List[97].answer(), Is.EqualTo("18769"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_99_test()
        {
            if (tasksList.t_List.Length > 98)
                Assert.That(tasksList.t_List[98].answer(), Is.EqualTo("709"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_100_test()
        {
            if (tasksList.t_List.Length > 99)
                Assert.That(tasksList.t_List[99].answer(), Is.EqualTo("756872327473"));
            else
                Assert.Ignore();
        }
    }
}
