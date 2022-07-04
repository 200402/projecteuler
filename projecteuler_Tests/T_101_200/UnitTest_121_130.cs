namespace projecteuler_Tests.T_101_200
{
    public class UnitTest_121_130
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_121_test()
        {
            if (tasksList.t_List.Length > 120)
                Assert.That(tasksList.t_List[120].answer(), Is.EqualTo("2269"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_122_test()
        {
            if (tasksList.t_List.Length > 121)
                Assert.That(tasksList.t_List[121].answer(), Is.EqualTo("1582"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_123_test()
        {
            if (tasksList.t_List.Length > 122)
                Assert.That(tasksList.t_List[122].answer(), Is.EqualTo("21035"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_124_test()
        {
            if (tasksList.t_List.Length > 123)
                Assert.That(tasksList.t_List[123].answer(), Is.EqualTo("21417"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_125_test()
        {
            if (tasksList.t_List.Length > 124)
                Assert.That(tasksList.t_List[124].answer(), Is.EqualTo("2906969179"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_126_test()
        {
            if (tasksList.t_List.Length > 125)
                Assert.That(tasksList.t_List[125].answer(), Is.EqualTo("18522"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_127_test()
        {
            if (tasksList.t_List.Length > 126)
                Assert.That(tasksList.t_List[126].answer(), Is.EqualTo("18407904"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_128_test()
        {
            if (tasksList.t_List.Length > 127)
                Assert.That(tasksList.t_List[127].answer(), Is.EqualTo("14516824220"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_129_test()
        {
            if (tasksList.t_List.Length > 128)
                Assert.That(tasksList.t_List[128].answer(), Is.EqualTo("1000023"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_130_test()
        {
            if (tasksList.t_List.Length > 129)
                Assert.That(tasksList.t_List[129].answer(), Is.EqualTo("149253"));
            else
                Assert.Ignore();
        }
    }
}
