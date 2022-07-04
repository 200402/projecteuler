namespace projecteuler_Tests.T_101_200
{
    public class UnitTest_131_140
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_131_test()
        {
            if (tasksList.t_List.Length > 130)
                Assert.That(tasksList.t_List[130].answer(), Is.EqualTo("173"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_132_test()
        {
            if (tasksList.t_List.Length > 131)
                Assert.That(tasksList.t_List[131].answer(), Is.EqualTo("843296"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_133_test()
        {
            if (tasksList.t_List.Length > 132)
                Assert.That(tasksList.t_List[132].answer(), Is.EqualTo("453647705"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_134_test()
        {
            if (tasksList.t_List.Length > 133)
                Assert.That(tasksList.t_List[133].answer(), Is.EqualTo("18613426663617118"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_135_test()
        {
            if (tasksList.t_List.Length > 134)
                Assert.That(tasksList.t_List[134].answer(), Is.EqualTo("4989"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_136_test()
        {
            if (tasksList.t_List.Length > 135)
                Assert.That(tasksList.t_List[135].answer(), Is.EqualTo("2544559"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_137_test()
        {
            if (tasksList.t_List.Length > 136)
                Assert.That(tasksList.t_List[136].answer(), Is.EqualTo("1120149658760"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_138_test()
        {
            if (tasksList.t_List.Length > 137)
                Assert.That(tasksList.t_List[137].answer(), Is.EqualTo("1118049290473932"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_139_test()
        {
            if (tasksList.t_List.Length > 138)
                Assert.That(tasksList.t_List[138].answer(), Is.EqualTo("10057761"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_140_test()
        {
            if (tasksList.t_List.Length > 139)
                Assert.That(tasksList.t_List[139].answer(), Is.EqualTo("5673835352990"));
            else
                Assert.Ignore();
        }
    }
}
